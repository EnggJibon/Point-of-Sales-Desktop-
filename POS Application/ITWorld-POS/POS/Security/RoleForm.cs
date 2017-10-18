using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using POS.BLL;
using POS.BLL.Security;
using POS.BLL.Security.Domain;
using POS.Properties;
using POS.UTILS;

namespace POS.Security
{
    public partial class RoleForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private RoleModel _role;
        private List<RoleModel> _roleList;

        private readonly IRoleService _roleService;

        #endregion

        #region Constructor

        public RoleForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _roleService = kernel.GetService(typeof(RoleService)) as RoleService;

            _role = new RoleModel();
        }

        #endregion

        #region Private Functions

        private void ClearForm()
        {
            txtRoleId.Text = "";
            txtRoleName.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
            {
                MessageBox.Show("Role name is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadFormWithData()
        {
            if (_roleList == null || _roleList.Count <= 0)
            {
                _isAddNewMode = true;
                return;
            }

            _role = _roleList[_currentIndex];
            txtRoleId.Text = Convert.ToString(_role.Id);
            txtRoleName.Text = _role.Name;
            txtDescription.Text = _role.Description;
            chkIsActive.Checked = _role.IsActive;

            dgvRoleList.Rows[_currentIndex].Selected = true;
            dgvRoleList.CurrentCell = dgvRoleList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvRoleList);

            Cursor = Cursors.WaitCursor;
            _roleList = _roleService.GetAll().Where(w => !w.IsDeleted).ToList();
            dgvRoleList.DataSource = _roleList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _role.Id = Convert.ToInt32(txtRoleId.Text.Trim());
            }
            _role.Name = txtRoleName.Text;
            _role.Description = txtDescription.Text;
            _role.SetOn = DateTime.UtcNow;
            _role.SetBy = 1;
            _role.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void RoleForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataGridView();
                _currentIndex = 0;
                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _isAddNewMode = true;
            ClearForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isChanged)
                {
                    var result = MessageBox.Show(POSText.ResetWarningMessage, MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    LoadFormWithData();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_isChanged)
                {
                    return;
                }

                if (!ValidateModel())
                {
                    return;
                }

                SetModel();

                if (_isAddNewMode)
                {
                    _role.Id = _roleService.Insert(_role);
                }
                else
                {
                    _roleService.Update(_role);
                }

                LoadDataGridView();
                _currentIndex = _roleList.FindIndex(r => r.Id == _role.Id);
                LoadFormWithData();
                MessageBox.Show(POSText.SaveMessage, MessageBoxCaptions.Success.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(Resources.DeleteWarningMessage, MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                _roleService.DeleteSoftly(_role.Id);
                LoadDataGridView();
                MessageBox.Show(Resources.DeleteMessage, MessageBoxCaptions.Success.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoleList.Rows.Count > 0)
                {
                    _currentIndex = 0;
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoleList.Rows.Count > 0 && _currentIndex != 0)
                {
                    _currentIndex = _currentIndex - 1;
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoleList.Rows.Count > 0 && _currentIndex != (dgvRoleList.Rows.Count - 1))
                {
                    _currentIndex = _currentIndex + 1;
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoleList.Rows.Count > 0)
                {
                    _currentIndex = dgvRoleList.Rows.Count - 1;
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvRoleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvRoleList.Rows.Count > 0)
                {
                    if (dgvRoleList.CurrentRow != null)
                    {
                        _currentIndex = dgvRoleList.CurrentRow.Index;
                    }
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModuleId_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtModuleName_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        #endregion
    }
}
