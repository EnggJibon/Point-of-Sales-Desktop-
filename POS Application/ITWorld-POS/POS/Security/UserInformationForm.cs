using System;
using System.Collections.Generic;
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
    public partial class UserInformationForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private UserInformationModel _userInformation;
        private List<UserInformationModel> _userInformationList;
        private List<UserTypeModel> _userTypeList;
        private List<EmployeeInformationModel> _employeeList;
        private List<RoleModel> _roleList;

        private readonly IUserInformationService _userInformationService;
        private readonly IUserTypeService _userTypeService;
        private readonly IEmployeeInformationService _employeeInformationService;
        private readonly IRoleService _roleService;

        #endregion

        #region Constructor

        public UserInformationForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _userInformationService = kernel.GetService(typeof(UserInformationService)) as UserInformationService;
            _userTypeService = kernel.GetService(typeof(UserTypeService)) as UserTypeService;
            _employeeInformationService = kernel.GetService(typeof(EmployeeInformationService)) as EmployeeInformationService;
            _roleService = kernel.GetService(typeof(RoleService)) as RoleService;

            _userInformation = new UserInformationModel();
        }

        #endregion

        #region Private Functions

        private void LoadUserTypeComboBox()
        {
            Helper.InitializeComboBox(cbxUserType);

            Cursor = Cursors.WaitCursor;
            _userTypeList = _userTypeService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxUserType.DataSource = _userTypeList;
            cbxUserType.DisplayMember = "Name";
            cbxUserType.ValueMember = "Id";
        }

        private void LoadEmployeeComboBox()
        {
            Helper.InitializeComboBox(cbxEmployee);

            Cursor = Cursors.WaitCursor;
            _employeeList = _employeeInformationService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxEmployee.DataSource = _employeeList;
            cbxEmployee.DisplayMember = "Name";
            cbxEmployee.ValueMember = "Id";
        }

        private void LoadRoleComboBox()
        {
            Helper.InitializeComboBox(cbxRole);

            Cursor = Cursors.WaitCursor;
            _roleList = _roleService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxRole.DataSource = _roleList;
            cbxRole.DisplayMember = "Name";
            cbxRole.ValueMember = "Id";
        }

        private void ClearForm()
        {
            txtUserId.Text = "";
            cbxUserType.SelectedIndex = -1;
            cbxEmployee.SelectedIndex = -1;
            cbxRole.SelectedIndex = -1;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPasswordAge.Text = "";
            txtLastPasswordChangedDate.Text = "";
            txtLastLockedDate.Text = "";
            txtWrongPasswordTryLimit.Text = "";
            chkIsPasswordChanged.Checked = false;
            chkIsLocked.Checked = false;
            chkIsSuperAdmin.Checked = false;
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (cbxUserType.SelectedItem == null || cbxUserType.SelectedIndex < 0)
            {
                MessageBox.Show("User type selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxEmployee.SelectedItem == null || cbxEmployee.SelectedIndex < 0)
            {
                MessageBox.Show("Employee selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxRole.SelectedItem == null || cbxRole.SelectedIndex < 0)
            {
                MessageBox.Show("Role selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPasswordAge.Text))
            {
                MessageBox.Show("Password age is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtWrongPasswordTryLimit.Text))
            {
                MessageBox.Show("Wrong password try limit is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadFormWithData()
        {
            if (_userInformationList == null || _userInformationList.Count <= 0)
            {
                _isAddNewMode = true;
                return;
            }

            _userInformation = _userInformationList[_currentIndex];
            txtUserId.Text = Convert.ToString(_userInformation.Id);
            cbxUserType.SelectedValue = _userInformation.UserTypeId;
            cbxEmployee.SelectedValue = _userInformation.EmployeeId;
            cbxRole.SelectedValue = _userInformation.RoleId;
            txtUsername.Text = _userInformation.Username;
            //txtPassword.Text = _userInformation.Password;
            txtPasswordAge.Text = Convert.ToString(_userInformation.PasswordAgeLimit);
            if (_userInformation.LastPasswordChangedDate != null)
            {
                txtLastPasswordChangedDate.Text = Convert.ToDateTime(_userInformation.LastPasswordChangedDate).ToString("dd-MMM-yyyy");
            }
            if (_userInformation.LastLockedDate != null)
            {
                txtLastLockedDate.Text = Convert.ToDateTime(_userInformation.LastLockedDate).ToString("dd-MMM-yyyy");
            }
            txtWrongPasswordTryLimit.Text = Convert.ToString(_userInformation.WrongPasswordTryLimit);
            chkIsPasswordChanged.Checked = _userInformation.IsPasswordChanged;
            chkIsLocked.Checked = _userInformation.IsLocked;
            chkIsSuperAdmin.Checked = _userInformation.IsSuperAdmin;
            chkIsActive.Checked = _userInformation.IsActive;

            dgvUserList.Rows[_currentIndex].Selected = true;
            dgvUserList.CurrentCell = dgvUserList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvUserList);

            Cursor = Cursors.WaitCursor;
            _userInformationList = _userInformationService.GetAllUserInformation().Where(w => !w.IsDeleted).ToList();
            dgvUserList.DataSource = _userInformationList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _userInformation.Id = Convert.ToInt32(txtUserId.Text.Trim());
            }

            chkIsPasswordChanged.Checked = false;
            chkIsLocked.Checked = false;
            chkIsSuperAdmin.Checked = false;
            chkIsActive.Checked = false;

            _userInformation.UserTypeId = Convert.ToInt32(cbxUserType.SelectedValue);
            _userInformation.EmployeeId = Convert.ToInt32(cbxEmployee.SelectedValue);
            _userInformation.RoleId = Convert.ToInt32(cbxRole.SelectedValue);
            _userInformation.Username = txtUsername.Text;
            _userInformation.Password = txtPassword.Text;
            _userInformation.PasswordAgeLimit = Convert.ToInt32(txtPasswordAge.Text);
            _userInformation.LastPasswordChangedDate = Convert.ToDateTime(txtLastPasswordChangedDate.Text);
            _userInformation.LastLockedDate = Convert.ToDateTime(txtLastLockedDate.Text);
            _userInformation.WrongPasswordTryLimit = Convert.ToInt32(txtWrongPasswordTryLimit.Text);
            _userInformation.SetOn = DateTime.UtcNow;
            _userInformation.SetBy = 1;
            _userInformation.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void UserInformationForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUserTypeComboBox();
                LoadEmployeeComboBox();
                LoadRoleComboBox();
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
                    _userInformation.Id = _userInformationService.Insert(_userInformation);
                }
                else
                {
                    _userInformationService.Update(_userInformation);
                }

                LoadDataGridView();
                _currentIndex = _userInformationList.FindIndex(r => r.Id == _userInformation.Id);
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

                _userInformationService.DeleteSoftly(_userInformation.Id);
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
                if (dgvUserList.Rows.Count > 0)
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
                if (dgvUserList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvUserList.Rows.Count > 0 && _currentIndex != (dgvUserList.Rows.Count - 1))
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
                if (dgvUserList.Rows.Count > 0)
                {
                    _currentIndex = dgvUserList.Rows.Count - 1;
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

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvUserList.Rows.Count > 0)
                {
                    if (dgvUserList.CurrentRow != null)
                    {
                        _currentIndex = dgvUserList.CurrentRow.Index;
                    }
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtPasswordAge_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtLastPasswordChangedDate_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtLastLockedDate_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtWrongPasswordTryLimit_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void chkIsPasswordChanged_CheckedChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void chkIsLocked_CheckedChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void chkIsSuperAdmin_CheckedChanged(object sender, EventArgs e)
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
