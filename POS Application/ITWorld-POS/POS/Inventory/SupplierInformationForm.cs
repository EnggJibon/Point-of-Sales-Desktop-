using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using POS.BLL;
using POS.BLL.Inventory.Domain;
using POS.BLL.Inventory.Service;
using POS.Properties;
using POS.UTILS;

namespace POS.Inventory
{
    public partial class SupplierInformationForm : Form
    {

        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private SupplierModel _supplierModel;
        private List<SupplierModel> _supplierModelList;

        private readonly ISupplierService _supplierService;

        #endregion

        #region Constructor
        public SupplierInformationForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _supplierService = kernel.GetService(typeof(SupplierService)) as SupplierService;
            _supplierModel = new SupplierModel();
        }
        #endregion

        #region Private Functions

        private void ClearForm()
        {
            txtSupplierId.Text = "";
            txtSupplierName.Text = "";
            txtSupplierCode.Text = "";
            txtAddress.Text = "";
            txtOwnNumber.Text = "";
            txtContactNumber.Text = "";
            txtEmail.Text = "";
            txtNID.Text = "";
            txtBankAccountNumber.Text = "";
            txtTIN.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierCode.Text))
            {
                MessageBox.Show("Supplier Code is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier Name is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Contact Number is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadFormWithData()
        {
            if (_supplierModelList == null || _supplierModelList.Count <= 0)
            {
                _isAddNewMode = true;
                return;
            }

            _supplierModel = _supplierModelList[_currentIndex];
            txtSupplierId.Text = Convert.ToString(_supplierModel.Id);
            txtSupplierCode.Text = _supplierModel.SupplierCode;
            txtSupplierName.Text = _supplierModel.SupplierName;
            txtAddress.Text = _supplierModel.Address;
            txtOwnNumber.Text = _supplierModel.OwnerName;
            txtContactNumber.Text = _supplierModel.ContactNumber;
            txtEmail.Text = _supplierModel.Email;
            txtNID.Text = _supplierModel.NID;
            txtBankAccountNumber.Text = _supplierModel.BankAccountNumber;
            txtTIN.Text = _supplierModel.TIN;
            txtDescription.Text = _supplierModel.Description;
            chkIsActive.Checked = _supplierModel.IsActive;

            dgvSupplierList.Rows[_currentIndex].Selected = true;
            dgvSupplierList.CurrentCell = dgvSupplierList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvSupplierList);

            Cursor = Cursors.WaitCursor;
            _supplierModelList = _supplierService.GetAll().Where(w => !w.IsDeleted).ToList();
            dgvSupplierList.DataSource = _supplierModelList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _supplierModel.Id = Convert.ToInt32(txtSupplierId.Text.Trim());
            }
            _supplierModel.SupplierName = txtSupplierName.Text;
            _supplierModel.SupplierCode = txtSupplierCode.Text;
            _supplierModel.Address = txtAddress.Text;
            _supplierModel.OwnerName = txtOwnNumber.Text;
            _supplierModel.ContactNumber = txtContactNumber.Text;
            _supplierModel.Email = txtEmail.Text;
            _supplierModel.NID = txtNID.Text;
            _supplierModel.TIN = txtTIN.Text;
            _supplierModel.Description = txtDescription.Text;
            _supplierModel.SetOn = DateTime.UtcNow;
            _supplierModel.SetBy = 1;
            _supplierModel.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void SupplierInformationForm_Load(object sender, EventArgs e)
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
                    _supplierModel.Id = _supplierService.Insert(_supplierModel);
                }
                else
                {
                    _supplierService.Update(_supplierModel);
                }

                LoadDataGridView();
                _currentIndex = _supplierModelList.FindIndex(r => r.Id == _supplierModel.Id);
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

                _supplierService.DeleteSoftly(_supplierModel.Id);
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
                if (dgvSupplierList.Rows.Count > 0)
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
                if (dgvSupplierList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvSupplierList.Rows.Count > 0 && _currentIndex != (dgvSupplierList.Rows.Count - 1))
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
                if (dgvSupplierList.Rows.Count > 0)
                {
                    _currentIndex = dgvSupplierList.Rows.Count - 1;
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

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSupplierList.Rows.Count > 0)
                {
                    if (dgvSupplierList.CurrentRow != null)
                    {
                        _currentIndex = dgvSupplierList.CurrentRow.Index;
                    }
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSupplierCode_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtOwnNumber_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtNID_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtBankAccountNumber_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtTIN_TextChanged(object sender, EventArgs e)
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


