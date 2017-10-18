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
    public partial class PurchaseReceiveForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private PurchaseReceiveDetailsForm _purchaseReceiveDetailsForm;
        private PurchaseReceiveModel _purchaseReceive;
        private List<PurchaseReceiveModel> _purchaseReceiveList;
        private List<PurchaseChallanModel> _purchaseChallanList;

        private readonly IPurchaseReceiveService _purchaseReceiveService;
        private readonly IPurchaseChallanService _purchaseChallanService;

        #endregion

        #region Constructor

        public PurchaseReceiveForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _purchaseReceiveService = kernel.GetService(typeof(PurchaseReceiveService)) as PurchaseReceiveService;
            _purchaseChallanService = kernel.GetService(typeof(PurchaseChallanService)) as PurchaseChallanService;

            _purchaseReceive = new PurchaseReceiveModel();
        }

        #endregion

        #region Private Functions

        private void LoadChallanComboBox()
        {
            Helper.InitializeComboBox(cbxChallan);

            Cursor = Cursors.WaitCursor;
            _purchaseChallanList = _purchaseChallanService.GetAllPurchaseChallan().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;

            cbxChallan.SelectedIndexChanged -= cbxChallan_SelectedIndexChanged;
            cbxChallan.DataSource = _purchaseChallanList;
            cbxChallan.DisplayMember = "ChallanNumber";
            cbxChallan.ValueMember = "Id";
            cbxChallan.SelectedIndexChanged += cbxChallan_SelectedIndexChanged;
        }

        private void ClearForm()
        {
            txtPurchaseReceiveId.Text = "";
            txtReceiveNumber.Text = "";
            txtReceiveDate.Text = "";
            txtReceivedBy.Text = "";
            cbxChallan.SelectedIndex = -1;
            txtChallanNumber.Text = "";
            txtChallanDate.Text = "";
            txtSupplierName.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtReceiveNumber.Text))
            {
                MessageBox.Show("Challan receive number is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtReceiveDate.Text))
            {
                MessageBox.Show("Challan receive date is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtReceivedBy.Text))
            {
                MessageBox.Show("Receive by for challan is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxChallan.SelectedItem == null || cbxChallan.SelectedIndex < 0)
            {
                MessageBox.Show("Challan selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_purchaseReceiveList == null || _purchaseReceiveList.Count <= 0)
            {
                _isAddNewMode = true;
                ClearForm();
                btnDetails.Enabled = false;
                return;
            }

            btnDetails.Enabled = true;
            _purchaseReceive = _purchaseReceiveList[_currentIndex];

            txtPurchaseReceiveId.Text = Convert.ToString(_purchaseReceive.Id);
            txtReceiveNumber.Text = _purchaseReceive.ReceiveNumber;
            txtReceiveDate.Text = Convert.ToString(_purchaseReceive.ReceiveDate);
            txtReceivedBy.Text = Convert.ToString(_purchaseReceive.ReceivedBy);
            cbxChallan.SelectedValue = _purchaseReceive.ChallanId;
            txtChallanNumber.Text = _purchaseReceive.ChallanNumber;
            txtChallanDate.Text = Convert.ToString(_purchaseReceive.ChallanDate);
            txtSupplierName.Text = _purchaseReceive.SupplierName;
            txtDescription.Text = _purchaseReceive.Description;
            chkIsActive.Checked = _purchaseReceive.IsActive;

            dgvPurchaseChallanList.Rows[_currentIndex].Selected = true;
            dgvPurchaseChallanList.CurrentCell = dgvPurchaseChallanList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvPurchaseChallanList);

            Cursor = Cursors.WaitCursor;
            _purchaseReceiveList = _purchaseReceiveService.GetAllPurchaseReceive().Where(w => !w.IsDeleted).ToList();
            dgvPurchaseChallanList.DataSource = _purchaseReceiveList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _purchaseReceive.Id = Convert.ToInt32(txtPurchaseReceiveId.Text.Trim());
            }

            _purchaseReceive.ReceiveNumber = txtReceiveNumber.Text;
            _purchaseReceive.ReceiveDate = Convert.ToDateTime(txtReceiveDate.Text);
            _purchaseReceive.ReceivedBy = txtReceivedBy.Text;
            _purchaseReceive.ChallanId = Convert.ToInt32(cbxChallan.SelectedValue);
            _purchaseReceive.Description = txtDescription.Text;
            _purchaseReceive.SetOn = DateTime.UtcNow;
            _purchaseReceive.SetBy = 1;
            _purchaseReceive.IsActive = chkIsActive.Checked;
        }

        private void FillChallanInfo()
        {
            if (_purchaseChallanList.Any())
            {
                var selectedPurchaseChallan = _purchaseChallanList.FirstOrDefault(pc => pc.Id == Convert.ToInt64(cbxChallan.SelectedValue));
                if (selectedPurchaseChallan != null)
                {
                    txtChallanNumber.Text = selectedPurchaseChallan.ChallanNumber;
                    txtChallanDate.Text = Convert.ToString(selectedPurchaseChallan.ChallanDate);
                    txtSupplierName.Text = selectedPurchaseChallan.SupplierName;
                }
            }
        }

        #endregion

        #region Private Events

        private void PurchaseChallanForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadChallanComboBox();
                LoadDataGridView();
                _currentIndex = 0;
                LoadFormWithData();
                //FillChallanInfo();
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
                    _purchaseReceive.Id = _purchaseReceiveService.Insert(_purchaseReceive);
                }
                else
                {
                    _purchaseReceiveService.Update(_purchaseReceive);
                }

                LoadDataGridView();
                _currentIndex = _purchaseReceiveList.FindIndex(r => r.Id == _purchaseReceive.Id);
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

                _purchaseReceiveService.DeleteSoftly(_purchaseReceive.Id);
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
            if (_purchaseReceive != null)
            {
                if (_purchaseReceiveDetailsForm != null && _purchaseReceiveDetailsForm.Visible)
                {
                    return;
                }
                _purchaseReceiveDetailsForm = new PurchaseReceiveDetailsForm(_purchaseReceive);
                _purchaseReceiveDetailsForm.Show();
            }
            else
            {
                MessageBox.Show("To see the details please select a purchase receive first.", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtDiscountInPercentage_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxChallan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillChallanInfo();
        }

        #endregion
    }
}
