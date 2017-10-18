using System;
using System.Collections.Generic;
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
    public partial class ModuleForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private ModuleModel _module;
        private List<ModuleModel> _moduleList;
        private List<ApplicationModel> _applicationList;

        private readonly IModuleService _moduleService;
        private readonly IApplicationService _applicationService;

        #endregion

        #region Constructor

        public ModuleForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _moduleService = kernel.GetService(typeof(ModuleService)) as ModuleService;
            _applicationService = kernel.GetService(typeof(ApplicationService)) as ApplicationService;

            _module = new ModuleModel();
        }

        #endregion

        #region Private Functions

        private void ClearForm()
        {
            txtModuleId.Text = "";
            txtModuleName.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtModuleName.Text))
            {
                MessageBox.Show("Module name is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_moduleList == null || _moduleList.Count <= 0)
            {
                _isAddNewMode = true;
                return;
            }

            _module = _moduleList[_currentIndex];
            txtModuleId.Text = Convert.ToString(_module.Id);
            txtModuleName.Text = _module.Name;
            txtDescription.Text = _module.Description;
            cbxApplication.SelectedValue = _module.ApplicationId;
            chkIsActive.Checked = _module.IsActive;

            dgvModuleList.Rows[_currentIndex].Selected = true;
            dgvModuleList.CurrentCell = dgvModuleList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadApplicationComboBox()
        {
            Helper.InitializeComboBox(cbxApplication);

            Cursor = Cursors.WaitCursor;
            _applicationList = _applicationService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxApplication.DataSource = _applicationList;
            cbxApplication.DisplayMember = "Name";
            cbxApplication.ValueMember = "Id";
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvModuleList);

            Cursor = Cursors.WaitCursor;
            _moduleList = _moduleService.GetAll().Where(w => !w.IsDeleted).ToList();
            dgvModuleList.DataSource = _moduleList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _module.Id = Convert.ToInt32(txtModuleId.Text.Trim());
            }
            _module.Name = txtModuleName.Text;
            _module.Description = txtDescription.Text;
            _module.ApplicationId = Convert.ToInt16(cbxApplication.SelectedValue);
            _module.SetOn = DateTime.UtcNow;
            _module.SetBy = 1;
            _module.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void ModuleForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadApplicationComboBox();
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
                    _module.Id = _moduleService.Insert(_module);
                }
                else
                {
                    _moduleService.Update(_module);
                }

                LoadDataGridView();
                _currentIndex = _moduleList.FindIndex(r => r.Id == _module.Id);
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

                _moduleService.DeleteSoftly(_module.Id);
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
                if (dgvModuleList.Rows.Count > 0)
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
                if (dgvModuleList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvModuleList.Rows.Count > 0 && _currentIndex != (dgvModuleList.Rows.Count - 1))
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
                if (dgvModuleList.Rows.Count > 0)
                {
                    _currentIndex = dgvModuleList.Rows.Count - 1;
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

        private void dgvModuleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvModuleList.Rows.Count > 0)
                {
                    if (dgvModuleList.CurrentRow != null)
                    {
                        _currentIndex = dgvModuleList.CurrentRow.Index;
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

        private void cbxApplication_SelectedIndexChanged(object sender, EventArgs e)
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
