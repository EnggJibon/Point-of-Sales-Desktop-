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
    public partial class ProductStoreForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private PurchaseReceiveDetailsForm _purchaseReceiveDetailsForm;
        private ProductPriceForm _productPriceForm;

        private ProductStoreModel _productStore;
        private PurchaseReceiveDetailModel _purchaseReceiveDetail;
        private List<ProductStoreModel> _productStoreList;
        private List<PurchaseReceiveModel> _purchaseReceiveList;
        private List<PurchaseReceiveDetailModel> _purchaseReceiveDetailList;
        private List<ProductUnitModel> _productUnitList;
        private List<ProductSectionModel> _productSectionList;


        private readonly IProductStoreService _productStoreService;
        private readonly IPurchaseReceiveService _purchaseReceiveService;
        private readonly IPurchaseReceiveDetailService _purchaseReceiveDetailService;
        private readonly IProductUnitService _productUnitService;
        private readonly IProductSectionService _productSectionService;

        #endregion

        #region Constructor

        public ProductStoreForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _productStoreService = kernel.GetService(typeof(ProductStoreService)) as ProductStoreService;
            _purchaseReceiveService = kernel.GetService(typeof(PurchaseReceiveService)) as PurchaseReceiveService;
            _purchaseReceiveDetailService = kernel.GetService(typeof(PurchaseReceiveDetailService)) as PurchaseReceiveDetailService;
            _productUnitService = kernel.GetService(typeof(ProductUnitService)) as ProductUnitService;
            _productSectionService = kernel.GetService(typeof(ProductSectionService)) as ProductSectionService;

            _productStore = new ProductStoreModel();
        }

        #endregion

        #region Private Functions

        private void LoadPurchaseReceiveComboBox()
        {
            Helper.InitializeComboBox(cbxPurchaseReceive);

            Cursor = Cursors.WaitCursor;
            _purchaseReceiveList = _purchaseReceiveService.GetAllPurchaseReceive().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;

            cbxPurchaseReceive.SelectedIndexChanged -= cbxPurchaseReceive_SelectedIndexChanged;
            cbxPurchaseReceive.DataSource = _purchaseReceiveList;
            cbxPurchaseReceive.DisplayMember = "ReceiveNumber";
            cbxPurchaseReceive.ValueMember = "Id";
            cbxPurchaseReceive.SelectedIndexChanged += cbxPurchaseReceive_SelectedIndexChanged;
        }

        private void LoadPurchaseReceiveDetailComboBox()
        {
            Helper.InitializeComboBox(cbxPurchaseReceiveDetail);

            Cursor = Cursors.WaitCursor;
            var selectedPurchaseReceiveId = Convert.ToInt64(cbxPurchaseReceive.SelectedValue);
            _purchaseReceiveDetailList = _purchaseReceiveDetailService.GetAllPurchaseReceiveDetail(selectedPurchaseReceiveId).Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;

            cbxPurchaseReceiveDetail.SelectedIndexChanged -= cbxPurchaseReceiveDetail_SelectedIndexChanged;
            cbxPurchaseReceiveDetail.DataSource = _purchaseReceiveDetailList;
            cbxPurchaseReceiveDetail.DisplayMember = "PurchaseChallanDetailId";
            cbxPurchaseReceiveDetail.ValueMember = "Id";
            cbxPurchaseReceiveDetail.SelectedIndexChanged += cbxPurchaseReceiveDetail_SelectedIndexChanged;
        }

        private void LoadProductUnitComboBox()
        {
            Helper.InitializeComboBox(cbxProductUnit);

            Cursor = Cursors.WaitCursor;
            _productUnitList = _productUnitService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxProductUnit.DataSource = _productUnitList;
            cbxProductUnit.DisplayMember = "ProductUnitName";
            cbxProductUnit.ValueMember = "Id";
        }

        private void LoadProductSectionComboBox()
        {
            Helper.InitializeComboBox(cbxProductSection);

            Cursor = Cursors.WaitCursor;
            _productSectionList = _productSectionService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxProductSection.DataSource = _productSectionList;
            cbxProductSection.DisplayMember = "ProductSectionName";
            cbxProductSection.ValueMember = "Id";
        }

        private void ClearForm()
        {
            if (cbxPurchaseReceiveDetail.SelectedItem != null && cbxPurchaseReceiveDetail.SelectedIndex > 0)
            {
                btnPriceDetail.Enabled = true;
                long purchaseReceiveDetailId = Convert.ToInt64(cbxPurchaseReceiveDetail.SelectedValue);

                var serial = _productStoreService.GenerateSerialForProductStoreDetail(purchaseReceiveDetailId);
                txtSerial.Text = Convert.ToString(serial);
            }

            var remainToStoreEntry = Convert.ToString(_purchaseReceiveDetail.ProductQuantity - _productStoreList.Sum(s => s.ProductQuantity));
            txtProductQuantity.Text = txtRemainToStoreEntry.Text = remainToStoreEntry;

            //cbxPurchaseReceive.SelectedIndex = -1;
            //cbxPurchaseReceiveDetail.SelectedIndex = -1;
            //txtProductId.Text = "";
            //txtSerial.Text = "";
            cbxProductSection.SelectedIndex = -1;
            cbxProductUnit.SelectedIndex = -1;
            //txtProductQuantity.Text = "";
            txtProductSizeCode.Text = "";
            txtProductSizeNumber.Text = "";
            txtProductSizeAge.Text = "";
            txtProductColor.Text = "";
            txtProductStyle.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;

            //txtProductName.Text = "";
            //txtProductCategory.Text = "";
            //txtSupplier.Text = "";
            //txtRemainToStoreEntry.Text = "";
        }

        private bool ValidateModel()
        {
            if (cbxPurchaseReceive.SelectedItem == null || cbxPurchaseReceive.SelectedIndex < 0)
            {
                MessageBox.Show("Purchase receive selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxPurchaseReceiveDetail.SelectedItem == null || cbxPurchaseReceiveDetail.SelectedIndex < 0)
            {
                MessageBox.Show("Purchase receive detail selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Product selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductQuantity.Text))
            {
                MessageBox.Show("Product quantity is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxProductUnit.SelectedItem == null || cbxProductUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Product unit selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxProductSection.SelectedItem == null || cbxProductSection.SelectedIndex < 0)
            {
                MessageBox.Show("Product item selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadFormWithData()
        {
            if (_productStoreList == null || _productStoreList.Count <= 0)
            {
                _isAddNewMode = true;
                ClearForm();
                //btnPurchaseReceiveDetails.Enabled = false;
                return;
            }

            btnPurchaseReceiveDetails.Enabled = true;
            _productStore = _productStoreList[_currentIndex];
            txtRemainToStoreEntry.Text = Convert.ToString(_purchaseReceiveDetail.ProductQuantity - _productStoreList.Sum(s => s.ProductQuantity));

            txtProductStoreId.Text = Convert.ToString(_productStore.Id);
            //cbxPurchaseReceiveDetail.SelectedValue = _productStore.PurchaseReceiveDetailId;
            //txtProductId.Text = Convert.ToString(_productStore.ProductId);
            txtSerial.Text = Convert.ToString(_productStore.Serial);
            cbxProductSection.SelectedValue = _productStore.ProductSectionId;
            cbxProductUnit.SelectedValue = _productStore.ProductUnitId;
            txtProductQuantity.Text = Convert.ToString(_productStore.ProductQuantity);
            txtProductSizeCode.Text = _productStore.ProductSizeCode;
            txtProductSizeNumber.Text = _productStore.ProductSizeNumber;
            txtProductSizeAge.Text = _productStore.ProductSizeAge;
            txtProductColor.Text = _productStore.ProductColor;
            txtProductStyle.Text = _productStore.ProductStyle;
            chkIsActive.Checked = _productStore.IsActive;
            txtDescription.Text = _productStore.Description;

            //txtProductName.Text = _productStore.ProductName;
            //txtProductCategory.Text = _productStore.ProductCategoryName;
            //txtSupplier.Text = _productStore.ProductSupplierName;

            dgvProductList.Rows[_currentIndex].Selected = true;
            dgvProductList.CurrentCell = dgvProductList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            if (_purchaseReceiveDetail == null)
            {
                MessageBox.Show("Purchase receive detail selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Helper.InitializeDataGridView(dgvProductList);

            Cursor = Cursors.WaitCursor;
            _productStoreList = _productStoreService.GetProductStoreInformation(_purchaseReceiveDetail.Id).Where(w => !w.IsDeleted).ToList();
            dgvProductList.DataSource = _productStoreList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _productStore.Id = Convert.ToInt64(txtProductStoreId.Text.Trim());
            }

            _productStore.PurchaseReceiveDetailId = Convert.ToInt64(cbxPurchaseReceiveDetail.SelectedValue);
            _productStore.ProductId = Convert.ToInt64(txtProductId.Text);
            _productStore.Serial = Convert.ToInt16(txtSerial.Text);
            _productStore.ProductSectionId = Convert.ToInt64(cbxProductSection.SelectedValue);
            _productStore.ProductUnitId = Convert.ToInt64(cbxProductUnit.SelectedValue);
            _productStore.ProductQuantity = Convert.ToInt16(txtProductQuantity.Text);
            _productStore.ProductSizeCode = txtProductSizeCode.Text;
            _productStore.ProductSizeNumber = txtProductSizeNumber.Text;
            _productStore.ProductSizeAge = txtProductSizeAge.Text;
            _productStore.ProductColor = txtProductColor.Text;
            _productStore.ProductStyle = txtProductStyle.Text;
            _productStore.Description = txtDescription.Text;
            _productStore.SetOn = DateTime.UtcNow;
            _productStore.SetBy = 1;
            _productStore.IsActive = chkIsActive.Checked;
        }

        private void LoadProductInformation()
        {
            if (cbxPurchaseReceiveDetail.SelectedItem == null || cbxPurchaseReceiveDetail.SelectedIndex < 0)
            {
                btnPriceDetail.Enabled = false;
                return;
            }

            btnPriceDetail.Enabled = true;
            long purchaseReceiveDetailId = Convert.ToInt64(cbxPurchaseReceiveDetail.SelectedValue);
            _purchaseReceiveDetail = _purchaseReceiveDetailList.FirstOrDefault(p => p.Id == purchaseReceiveDetailId);
            if (_purchaseReceiveDetail != null)
            {
                txtProductId.Text = Convert.ToString(_purchaseReceiveDetail.ProductId);
                txtProductName.Text = _purchaseReceiveDetail.ProductName;
                txtProductCategory.Text = _purchaseReceiveDetail.ProductCategoryName;
                txtSupplier.Text = _purchaseReceiveDetail.SupplierName;
                txtPurchaseReceiveQuantity.Text = Convert.ToString(_purchaseReceiveDetail.ProductQuantity);
            }

            LoadDataGridView();
            _currentIndex = 0;
            LoadFormWithData();
        }

        #endregion

        #region Private Events

        private void ProductStoreForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPurchaseReceiveComboBox();
                LoadPurchaseReceiveDetailComboBox();
                LoadProductUnitComboBox();
                LoadProductSectionComboBox();
                LoadProductInformation();
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
                    _productStore.Id = _productStoreService.Insert(_productStore);
                }
                else
                {
                    _productStoreService.Update(_productStore);
                }

                LoadDataGridView();
                _currentIndex = _productStoreList.FindIndex(r => r.Id == _productStore.Id);
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

                _productStoreService.DeleteSoftly(_productStore.Id);
                LoadDataGridView();
                MessageBox.Show(Resources.DeleteMessage, MessageBoxCaptions.Success.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPurchaseReceiveDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnPriceDetail_Click(object sender, EventArgs e)
        {
            if (_purchaseReceiveDetail == null)
            {
                MessageBox.Show("Purchase receive detail selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_productPriceForm != null && _productPriceForm.Visible)
            {
                return;
            }
            _productPriceForm = new ProductPriceForm(_purchaseReceiveDetail);
            _productPriceForm.Show();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductList.Rows.Count > 0)
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
                if (dgvProductList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvProductList.Rows.Count > 0 && _currentIndex != (dgvProductList.Rows.Count - 1))
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
                if (dgvProductList.Rows.Count > 0)
                {
                    _currentIndex = dgvProductList.Rows.Count - 1;
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

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductList.Rows.Count > 0)
                {
                    if (dgvProductList.CurrentRow != null)
                    {
                        _currentIndex = dgvProductList.CurrentRow.Index;
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

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxProductUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxProductSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtProductSizeCode_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtProductSizeNumber_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtProductSizeAge_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtProductColor_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtProductStyle_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxPurchaseReceive_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPurchaseReceiveDetailComboBox();
            LoadProductInformation();
        }

        private void cbxPurchaseReceiveDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductInformation();
        }

        #endregion
    }
}
