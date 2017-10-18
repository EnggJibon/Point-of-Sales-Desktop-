using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using POS.BLL;
using POS.BLL.Inventory.Domain;
using POS.BLL.Inventory.Service;
using POS.DAL.Inventory;
using POS.Properties;
using POS.UTILS;

namespace POS.Inventory
{
    public partial class PurchaseChallanForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private PurchaseChallanDetailsForm _purchaseChallanDetailsForm;
        private PurchaseChallanModel _purchaseChallan;
        private List<PurchaseChallanModel> _purchaseChallanList;
        private List<SupplierModel> _supplierList;

        private readonly IPurchaseChallanService _purchaseChallanService;
        private readonly ISupplierService _supplierService;

        #endregion

        #region Constructor

        public PurchaseChallanForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _purchaseChallanService = kernel.GetService(typeof(PurchaseChallanService)) as PurchaseChallanService;
            _supplierService = kernel.GetService(typeof(SupplierService)) as SupplierService;

            _purchaseChallan = new PurchaseChallanModel();
        }

        #endregion

        #region Private Functions

        private void LoadSupplierComboBox()
        {
            Helper.InitializeComboBox(cbxSupplier);

            Cursor = Cursors.WaitCursor;
            _supplierList = _supplierService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxSupplier.DataSource = _supplierList;
            cbxSupplier.DisplayMember = "SupplierName";
            cbxSupplier.ValueMember = "Id";
        }

        private void ClearForm()
        {
            txtPurchaseChallanId.Text = "";
            txtChallanNumber.Text = "";
            txtChallanDate.Text = "";
            cbxSupplier.SelectedIndex = -1;
            txtOrderBy.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtChallanNumber.Text))
            {
                MessageBox.Show("Challan number is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtChallanDate.Text))
            {
                MessageBox.Show("Challan date is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxSupplier.SelectedItem == null || cbxSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Supplier selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrderBy.Text))
            {
                MessageBox.Show("Received from is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_purchaseChallanList == null || _purchaseChallanList.Count <= 0)
            {
                _isAddNewMode = true;
                ClearForm();
                btnDetails.Enabled = false;
                return;
            }

            btnDetails.Enabled = true;
            _purchaseChallan = _purchaseChallanList[_currentIndex];

            txtPurchaseChallanId.Text = Convert.ToString(_purchaseChallan.Id);
            txtChallanNumber.Text = _purchaseChallan.ChallanNumber;
            txtChallanDate.Text = Convert.ToString(_purchaseChallan.ChallanDate);
            cbxSupplier.SelectedValue = _purchaseChallan.SupplierId;
            txtOrderBy.Text = Convert.ToString(_purchaseChallan.OrderBy);
            txtDescription.Text = _purchaseChallan.Description;
            chkIsActive.Checked = _purchaseChallan.IsActive;

            dgvPurchaseChallanList.Rows[_currentIndex].Selected = true;
            dgvPurchaseChallanList.CurrentCell = dgvPurchaseChallanList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvPurchaseChallanList);

            Cursor = Cursors.WaitCursor;
            _purchaseChallanList = _purchaseChallanService.GetAllPurchaseChallan().Where(w => !w.IsDeleted).ToList();
            dgvPurchaseChallanList.DataSource = _purchaseChallanList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _purchaseChallan.Id = Convert.ToInt32(txtPurchaseChallanId.Text.Trim());
            }

            _purchaseChallan.ChallanNumber = txtChallanNumber.Text;
            _purchaseChallan.ChallanDate = Convert.ToDateTime(txtChallanDate.Text);
            _purchaseChallan.SupplierId = Convert.ToInt32(cbxSupplier.SelectedValue);
            _purchaseChallan.OrderBy = txtOrderBy.Text;
            _purchaseChallan.Description = txtDescription.Text;
            _purchaseChallan.SetOn = DateTime.UtcNow;
            _purchaseChallan.SetBy = 1;
            _purchaseChallan.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void PurchaseChallanForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSupplierComboBox();
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
                    _purchaseChallan.Id = _purchaseChallanService.Insert(_purchaseChallan);
                }
                else
                {
                    _purchaseChallanService.Update(_purchaseChallan);
                }

                LoadDataGridView();
                _currentIndex = _purchaseChallanList.FindIndex(r => r.Id == _purchaseChallan.Id);
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

                _purchaseChallanService.DeleteSoftly(_purchaseChallan.Id);
                LoadDataGridView();
                MessageBox.Show(Resources.DeleteMessage, MessageBoxCaptions.Success.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (_purchaseChallan != null)
            {
                if (_purchaseChallanDetailsForm != null && _purchaseChallanDetailsForm.Visible)
                {
                    return;
                }
                _purchaseChallanDetailsForm = new PurchaseChallanDetailsForm(_purchaseChallan);
                _purchaseChallanDetailsForm.Show();
            }
            else
            {
                MessageBox.Show("To see the details please select a purchase challan first.", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPurchaseChallanList.Rows.Count > 0)
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
                if (dgvPurchaseChallanList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvPurchaseChallanList.Rows.Count > 0 && _currentIndex != (dgvPurchaseChallanList.Rows.Count - 1))
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
                if (dgvPurchaseChallanList.Rows.Count > 0)
                {
                    _currentIndex = dgvPurchaseChallanList.Rows.Count - 1;
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

        private void dgvPurchaseChallanList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPurchaseChallanList.Rows.Count > 0)
                {
                    if (dgvPurchaseChallanList.CurrentRow != null)
                    {
                        _currentIndex = dgvPurchaseChallanList.CurrentRow.Index;
                    }
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProductCategoryName_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtSupplierUnitPrice_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtOrderBy_TextChanged(object sender, EventArgs e)
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
