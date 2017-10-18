using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Ninject;
using POS.BLL;
using POS.BLL.Inventory.Domain;
using POS.BLL.Inventory.Service;
using POS.Properties;
using POS.UTILS;

namespace POS.Inventory
{
    public partial class PurchaseChallanDetailsForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private PurchaseChallanDetailModel _purchaseChallanDetail;
        private PurchaseChallanModel _purchaseChallan;
        private List<PurchaseChallanDetailModel> _purchaseChallanDetailList;
        private List<ProductCategoryModel> _productCategoryList;
        private List<ProductModel> _productList;

        private readonly IPurchaseChallanDetailService _purchaseChallanDetailService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductService _productService;

        #endregion

        #region Constructor

        public PurchaseChallanDetailsForm(PurchaseChallanModel purchaseChallan)
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();

            _purchaseChallanDetailService = kernel.GetService(typeof(PurchaseChallanDetailService)) as PurchaseChallanDetailService;
            _productCategoryService = kernel.GetService(typeof(ProductCategoryService)) as ProductCategoryService;
            _productService = kernel.GetService(typeof(ProductService)) as ProductService;

            _purchaseChallan = purchaseChallan;
            _purchaseChallanDetail = new PurchaseChallanDetailModel();
        }

        #endregion

        #region Private Functions

        private void LoadProductCategoryComboBox()
        {
            Helper.InitializeComboBox(cbxProductCategory);

            Cursor = Cursors.WaitCursor;
            _productCategoryList = _productCategoryService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;

            cbxProductCategory.SelectedIndexChanged -= cbxProductCategory_SelectedIndexChanged;
            cbxProductCategory.DataSource = _productCategoryList;
            cbxProductCategory.DisplayMember = "ProductCategoryName";
            cbxProductCategory.ValueMember = "Id";
            cbxProductCategory.SelectedIndexChanged += cbxProductCategory_SelectedIndexChanged;
        }

        private void LoadProductComboBox()
        {
            if (cbxProductCategory.SelectedItem != null)
            {
                Helper.InitializeComboBox(cbxProduct);

                if (_productList == null)
                {
                    Cursor = Cursors.WaitCursor;
                    _productList = _productService.GetAll().Where(w => !w.IsDeleted).ToList();
                    Cursor = Cursors.Default;
                }

                var selectedProductCategoryId = Convert.ToInt64(cbxProductCategory.SelectedValue);
                var categoryWiseProductList = _productList.Where(w => w.ProductCategoryId == selectedProductCategoryId).ToList();
                if (categoryWiseProductList.Any())
                {
                    cbxProduct.SelectedIndexChanged -= cbxProduct_SelectedIndexChanged;
                    cbxProduct.DataSource = categoryWiseProductList;
                    cbxProduct.DisplayMember = "ProductName";
                    cbxProduct.ValueMember = "Id";
                    cbxProduct.SelectedIndexChanged += cbxProduct_SelectedIndexChanged;
                }
            }
        }

        private void ClearForm()
        {
            cbxProduct.SelectedIndex = -1;
            txtProductName.Text = "";
            txtDescription.Text = "";
            txtProductUnitPrice.Text = POSText.MinAmount;
            txtProductQuantity.Text = "";
            txtTotalProductPrice.Text = POSText.MinAmount;
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (cbxProduct.SelectedItem == null || cbxProduct.SelectedIndex < 0)
            {
                MessageBox.Show("Product selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductUnitPrice.Text))
            {
                MessageBox.Show("Product unit price is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductQuantity.Text))
            {
                MessageBox.Show("Product quantity is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadFormWithData()
        {
            if (_purchaseChallanDetailList == null || _purchaseChallanDetailList.Count <= 0)
            {
                _isAddNewMode = true;
                ClearForm();
                return;
            }

            _purchaseChallanDetail = _purchaseChallanDetailList[_currentIndex];

            txtPurchaseChallanDetailId.Text = Convert.ToString(_purchaseChallanDetail.Id);
            cbxProductCategory.SelectedValue = _purchaseChallanDetail.ProductCategoryId;
            cbxProduct.SelectedValue = _purchaseChallanDetail.ProductId;
            txtProductName.Text = _purchaseChallanDetail.ProductName;

            txtProductUnitPrice.TextChanged -= txtProductUnitPrice_TextChanged;
            txtProductUnitPrice.Text = Convert.ToString(_purchaseChallanDetail.ProductUnitPrice);
            txtProductUnitPrice.TextChanged += txtProductUnitPrice_TextChanged;

            txtProductQuantity.TextChanged -= txtProductQuantity_TextChanged;
            txtProductQuantity.Text = Convert.ToString(_purchaseChallanDetail.ProductQuantity);
            txtProductQuantity.TextChanged += txtProductQuantity_TextChanged;
          
            txtTotalProductPrice.Text = Convert.ToString(_purchaseChallanDetail.TotalPrice);
            txtDescription.Text = _purchaseChallanDetail.Description;
            chkIsActive.Checked = _purchaseChallanDetail.IsActive;

            dgvProductDetailList.Rows[_currentIndex].Selected = true;
            dgvProductDetailList.CurrentCell = dgvProductDetailList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvProductDetailList);

            Cursor = Cursors.WaitCursor;
            _purchaseChallanDetailList = _purchaseChallanDetailService.GetAllPurchaseChallanDetail(_purchaseChallan.Id).Where(w => !w.IsDeleted).ToList();
            dgvProductDetailList.DataSource = _purchaseChallanDetailList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (_purchaseChallan != null)
            {
                _purchaseChallanDetail.PurchaseChallanId = _purchaseChallan.Id;
            }

            if (!_isAddNewMode)
            {
                _purchaseChallanDetail.Id = Convert.ToInt64(txtPurchaseChallanDetailId.Text.Trim());
            }

            _purchaseChallanDetail.ProductId = Convert.ToInt64(cbxProduct.SelectedValue);
            _purchaseChallanDetail.ProductUnitPrice = Convert.ToDecimal(txtProductUnitPrice.Text);
            _purchaseChallanDetail.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
            _purchaseChallanDetail.TotalPrice = Convert.ToDecimal(txtTotalProductPrice.Text);
            //_purchaseChallanDetail.TotalPrice = _purchaseChallanDetail.ProductUnitPrice * _purchaseChallanDetail.ProductQuantity;
            _purchaseChallanDetail.Description = txtDescription.Text;
            _purchaseChallanDetail.IsActive = chkIsActive.Checked;
            _purchaseChallanDetail.SetOn = DateTime.UtcNow;
            _purchaseChallanDetail.SetBy = 1;
        }

        private void CalculateTotalProductPrice()
        {
            decimal productUnitPrice = 0;
            int productQuantity = 0;

            if (!string.IsNullOrWhiteSpace(txtProductUnitPrice.Text))
            {
                productUnitPrice = Convert.ToDecimal(txtProductUnitPrice.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(txtProductQuantity.Text))
            {
                productQuantity = Convert.ToInt32(txtProductQuantity.Text.Trim());
            }

            txtTotalProductPrice.Text = Convert.ToString(productUnitPrice * productQuantity);
        }

        #endregion

        #region Private Events

        private void PurchaseChallanDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_purchaseChallan == null)
                {
                    _isAddNewMode = true;
                    ClearForm();
                    return;
                }
                txtPurchaseChallanId.Text = Convert.ToString(_purchaseChallan.Id);
                txtPurchaseChallanNumber.Text = _purchaseChallan.ChallanNumber;

                LoadProductCategoryComboBox();
                LoadProductComboBox();
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
                    _purchaseChallanDetail.Id = _purchaseChallanDetailService.Insert(_purchaseChallanDetail);
                }
                else
                {
                    _purchaseChallanDetailService.Update(_purchaseChallanDetail);
                }

                LoadDataGridView();
                _currentIndex = _purchaseChallanDetailList.FindIndex(r => r.Id == _purchaseChallanDetail.Id);
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

                _purchaseChallanDetailService.DeleteSoftly(_purchaseChallanDetail.Id);
                LoadFormWithData();
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
                if (dgvProductDetailList.Rows.Count > 0)
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
                if (dgvProductDetailList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvProductDetailList.Rows.Count > 0 && _currentIndex != (dgvProductDetailList.Rows.Count - 1))
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
                if (dgvProductDetailList.Rows.Count > 0)
                {
                    _currentIndex = dgvProductDetailList.Rows.Count - 1;
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

        private void dgvProductDetailList_CellClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductDetailList.Rows.Count > 0)
                {
                    if (dgvProductDetailList.CurrentRow != null)
                    {
                        _currentIndex = dgvProductDetailList.CurrentRow.Index;
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

        private void txtProductUnitPrice_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
            CalculateTotalProductPrice();
        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
            CalculateTotalProductPrice();
        }

        private void txtTotalProductPrice_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void cbxProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductComboBox();
        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_productList.Any())
            {
                var selectedProduct = _productList.FirstOrDefault(p => p.Id == Convert.ToInt64(cbxProduct.SelectedValue));
                if (selectedProduct != null)
                {
                    txtProductName.Text = selectedProduct.ProductName;
                }
            }
        }

        #endregion
    }
}
