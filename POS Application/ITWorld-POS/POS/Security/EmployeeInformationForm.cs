using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using POS.BLL;
using POS.BLL.HRM.Domain;
using POS.BLL.HRM.Service;
using POS.BLL.Security;
using POS.BLL.Security.Domain;
using POS.Properties;
using POS.UTILS;

namespace POS.Security
{
    public partial class EmployeeInformationForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private EmployeeInformationModel _employeeInformation;
        private List<EmployeeInformationModel> _employeeInformationList;
        private List<DepartmentModel> _departmentList;
        private List<DesignationModel> _designationList;

        private readonly IEmployeeInformationService _employeeInformationService;
        private readonly IDepartmentService _departmentService;
        private readonly IDesignationService _designationService;

        #endregion

        #region Constructor

        public EmployeeInformationForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _employeeInformationService = kernel.GetService(typeof(EmployeeInformationService)) as EmployeeInformationService;
            _departmentService = kernel.GetService(typeof(DepartmentService)) as DepartmentService;
            _designationService = kernel.GetService(typeof(DesignationService)) as DesignationService;

            _employeeInformation = new EmployeeInformationModel();
        }

        #endregion

        #region Private Functions

        private void LoadTitleComboBox()
        {
            Helper.InitializeComboBox(cbxTitle);

            var titleList = new List<ComboboxItem>
            {
                new ComboboxItem
                {
                    Text = "Mr.",
                    Value = "Mr."
                },
                new ComboboxItem
                {
                    Text = "Mrs.",
                    Value = "Mrs."
                }
            };

            //cbxTitle.Items.Insert(0, new ComboboxItem { Text = "-- Select --", Value = -1 });
            //cbxTitle.Items.Insert(0, "-- Select --");

            cbxTitle.DataSource = titleList;
            cbxTitle.DisplayMember = "Text";
            cbxTitle.ValueMember = "Value";
        }

        private void LoadGenderComboBox()
        {
            Helper.InitializeComboBox(cbxGender);

            var genderList = new List<ComboboxItem>
            {
                new ComboboxItem
                {
                    Text = "Male",
                    Value = "M"
                },
                new ComboboxItem
                {
                    Text = "Female",
                    Value = "F"
                }
            };

            cbxGender.DataSource = genderList;
            cbxGender.DisplayMember = "Text";
            cbxGender.ValueMember = "Value";
        }

        private void LoadMaritalStatusComboBox()
        {
            Helper.InitializeComboBox(cbxMaritalStatus);

            var marrialStatusList = new List<ComboboxItem>
            {
                new ComboboxItem
                {
                    Text = "Married",
                    Value = "M"
                },
                new ComboboxItem
                {
                    Text = "Unmarried",
                    Value = "U"
                }
            };

            cbxMaritalStatus.DataSource = marrialStatusList;
            cbxMaritalStatus.DisplayMember = "Text";
            cbxMaritalStatus.ValueMember = "Value";
        }

        private void LoadDepartmentComboBox()
        {
            Helper.InitializeComboBox(cbxDepartment);

            Cursor = Cursors.WaitCursor;
            _departmentList = _departmentService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxDepartment.DataSource = _departmentList;
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.ValueMember = "Id";
        }

        private void LoadDesignationComboBox()
        {
            Helper.InitializeComboBox(cbxDesignation);

            Cursor = Cursors.WaitCursor;
            _designationList = _designationService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxDesignation.DataSource = _designationList;
            cbxDesignation.DisplayMember = "Name";
            cbxDesignation.ValueMember = "Id";
        }

        private void ClearForm()
        {
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            txtEmployeeCode.Text = "";
            cbxDepartment.SelectedIndex = -1;
            cbxDesignation.SelectedIndex = -1;
            txtPhone.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtBirthDate.Text = "";
            txtJoinDate.Text = "";
            cbxGender.SelectedIndex = -1;
            cbxMaritalStatus.SelectedIndex = -1;
            txtReligion.Text = "";
            txtNationality.Text = "";
            txtNationalId.Text = "";
            txtPermanentAddress.Text = "";
            txtPresentAddress.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("Employee name is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmployeeCode.Text))
            {
                MessageBox.Show("Employee code is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                MessageBox.Show("Mobile number is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtReligion.Text))
            {
                MessageBox.Show("Religion is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNationality.Text))
            {
                MessageBox.Show("Nationality is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxTitle.SelectedItem == null || cbxTitle.SelectedIndex < 0)
            {
                MessageBox.Show("Title selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxGender.SelectedItem == null || cbxGender.SelectedIndex < 0)
            {
                MessageBox.Show("Gender selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxMaritalStatus.SelectedItem == null || cbxMaritalStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Marital status selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxDepartment.SelectedItem == null || cbxDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("Department selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxDesignation.SelectedItem == null || cbxDesignation.SelectedIndex < 0)
            {
                MessageBox.Show("Designation selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadFormWithData()
        {
            if (_employeeInformationList == null || _employeeInformationList.Count <= 0)
            {
                _isAddNewMode = true;
                return;
            }

            _employeeInformation = _employeeInformationList[_currentIndex];
            txtEmployeeId.Text = Convert.ToString(_employeeInformation.Id);
            txtEmployeeName.Text = _employeeInformation.Name;
            txtEmployeeCode.Text = _employeeInformation.EmployeeCode;
            cbxTitle.SelectedValue = _employeeInformation.Title;
            cbxDepartment.SelectedValue = _employeeInformation.DepartmentId;
            cbxDesignation.SelectedValue = _employeeInformation.DesignationId;
            txtPhone.Text = _employeeInformation.Phone;
            txtMobile.Text = _employeeInformation.Mobile;
            txtEmail.Text = _employeeInformation.Email;
            txtBirthDate.Text = Convert.ToString(_employeeInformation.BirthDate);
            txtJoinDate.Text = Convert.ToString(_employeeInformation.JoiningDate);
            cbxGender.SelectedValue = _employeeInformation.Gender;
            cbxMaritalStatus.SelectedValue = _employeeInformation.MaritalStatus;
            txtReligion.Text = _employeeInformation.Religion;
            txtNationality.Text = _employeeInformation.Nationality;
            txtNationalId.Text = _employeeInformation.NationalId;
            txtPermanentAddress.Text = _employeeInformation.Address1;
            txtPresentAddress.Text = _employeeInformation.Address2;
            chkIsActive.Checked = _employeeInformation.IsActive;

            dgvEmployeeList.Rows[_currentIndex].Selected = true;
            dgvEmployeeList.CurrentCell = dgvEmployeeList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvEmployeeList);
            //dgvEmployeeList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Cursor = Cursors.WaitCursor;
            _employeeInformationList = _employeeInformationService.GetAllEmployeeInformation().Where(w => !w.IsDeleted).ToList();
            dgvEmployeeList.DataSource = _employeeInformationList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _employeeInformation.Id = Convert.ToInt32(txtEmployeeId.Text.Trim());
            }
            _employeeInformation.Title = Convert.ToString(cbxTitle.SelectedValue);
            _employeeInformation.Name = txtEmployeeName.Text;
            _employeeInformation.EmployeeCode = txtEmployeeCode.Text;
            _employeeInformation.DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
            _employeeInformation.DesignationId = Convert.ToInt32(cbxDesignation.SelectedValue);
            _employeeInformation.Phone = txtPhone.Text;
            _employeeInformation.Mobile = txtMobile.Text;
            _employeeInformation.Email = txtEmail.Text;
            _employeeInformation.BirthDate = Convert.ToDateTime(txtBirthDate.Text);
            _employeeInformation.JoiningDate = Convert.ToDateTime(txtJoinDate.Text);
            _employeeInformation.Gender = Convert.ToString(cbxGender.SelectedValue);
            _employeeInformation.MaritalStatus = Convert.ToString(cbxMaritalStatus.SelectedValue);
            _employeeInformation.Religion = txtReligion.Text;
            _employeeInformation.Nationality = txtNationality.Text;
            _employeeInformation.NationalId = txtNationalId.Text;
            _employeeInformation.Address1 = txtPermanentAddress.Text;
            _employeeInformation.Address2 = txtPresentAddress.Text;

            _employeeInformation.SetOn = DateTime.UtcNow;
            _employeeInformation.SetBy = 1;
            _employeeInformation.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTitleComboBox();
                LoadGenderComboBox();
                LoadMaritalStatusComboBox();
                LoadDepartmentComboBox();
                LoadDesignationComboBox();
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
                    _employeeInformation.Id = _employeeInformationService.Insert(_employeeInformation);
                }
                else
                {
                    _employeeInformationService.Update(_employeeInformation);
                }

                LoadDataGridView();
                _currentIndex = _employeeInformationList.FindIndex(r => r.Id == _employeeInformation.Id);
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

                _employeeInformationService.DeleteSoftly(_employeeInformation.Id);
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
                if (dgvEmployeeList.Rows.Count > 0)
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
                if (dgvEmployeeList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvEmployeeList.Rows.Count > 0 && _currentIndex != (dgvEmployeeList.Rows.Count - 1))
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
                if (dgvEmployeeList.Rows.Count > 0)
                {
                    _currentIndex = dgvEmployeeList.Rows.Count - 1;
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

        private void dgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEmployeeList.Rows.Count > 0)
                {
                    if (dgvEmployeeList.CurrentRow != null)
                    {
                        _currentIndex = dgvEmployeeList.CurrentRow.Index;
                    }
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxMaritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtReligion_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtPermanentAddress_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtNationalId_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtPresentAddress_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtJoinDate_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        #endregion
    }
}
