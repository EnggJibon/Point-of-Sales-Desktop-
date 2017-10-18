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
    public partial class ProductPriceForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private bool _isChanged;

        private ProductPriceModel _productPrice;
        private PurchaseReceiveDetailModel _purchaseReceiveDetail;
        private readonly IProductPriceService _productPriceService;

        #endregion

        #region Constructor

        public ProductPriceForm(PurchaseReceiveDetailModel purchaseReceiveDetail)
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _productPriceService = kernel.GetService(typeof(ProductPriceService)) as ProductPriceService;
            _purchaseReceiveDetail = purchaseReceiveDetail;
        }

        #endregion

        #region Private Functions

        private void ClearForm()
        {
            txtProductPriceId.Text = "";
            txtPurchaseUnitPrice.Text = Convert.ToString(_purchaseReceiveDetail.ProductUnitPrice);

            txtDiscountInPercentage.TextChanged -= txtDiscountInPercentage_TextChanged;
            txtDiscountInPercentage.Text = POSText.MinAmount;
            txtDiscountInPercentage.TextChanged += txtDiscountInPercentage_TextChanged;

            txtProductCost.TextChanged -= txtProductCost_TextChanged;
            txtProductCost.Text = POSText.MinAmount;
            txtProductCost.TextChanged += txtProductCost_TextChanged;

            txtProductSalePrice.Text = POSText.MinAmount;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtPurchaseUnitPrice.Text))
            {
                MessageBox.Show("Purchase unit price is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiscountInPercentage.Text))
            {
                MessageBox.Show("Discount is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductCost.Text))
            {
                MessageBox.Show("Product cost is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductSalePrice.Text))
            {
                MessageBox.Show("Product sale price is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadFormWithData()
        {
            txtPurchaseReceiveId.Text = Convert.ToString(_purchaseReceiveDetail.PurchaseReceiveId);
            txtPurchaseReceiveDetailId.Text = Convert.ToString(_purchaseReceiveDetail.Id);
            txtProductId.Text = Convert.ToString(_purchaseReceiveDetail.ProductId);
            txtProductName.Text = _purchaseReceiveDetail.ProductName;
            txtProductCategory.Text = _purchaseReceiveDetail.ProductCategoryName;
            txtSupplier.Text = _purchaseReceiveDetail.SupplierName;

            _productPrice = _productPriceService.GetAll().FirstOrDefault(p => p.PurchaseReceiveDetailId == _purchaseReceiveDetail.Id);
            if (_productPrice == null)
            {
                _isAddNewMode = true;
                ClearForm();
                return;
            }

            txtProductPriceId.Text = Convert.ToString(_productPrice.Id);
            txtPurchaseUnitPrice.Text = Convert.ToString(_productPrice.PurchaseUnitPrice);

            txtDiscountInPercentage.TextChanged -= txtDiscountInPercentage_TextChanged;
            txtDiscountInPercentage.Text = Convert.ToString(_productPrice.DiscountInPercentage);
            txtDiscountInPercentage.TextChanged += txtDiscountInPercentage_TextChanged;

            txtProductCost.TextChanged -= txtProductCost_TextChanged;
            txtProductCost.Text = Convert.ToString(_productPrice.ProductCost);
            txtProductCost.TextChanged += txtProductCost_TextChanged;

            txtProductSalePrice.Text = Convert.ToString(_productPrice.ProductSalePrice);
            txtDescription.Text = _productPrice.Description;
            chkIsActive.Checked = _productPrice.IsActive;
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _productPrice.Id = Convert.ToInt32(txtProductPriceId.Text.Trim());
            }
            else
            {
                _productPrice = new ProductPriceModel();
            }
            
            _productPrice.PurchaseReceiveDetailId = _purchaseReceiveDetail.Id;
            _productPrice.PurchaseUnitPrice = Convert.ToDecimal(txtPurchaseUnitPrice.Text);
            _productPrice.DiscountInPercentage = Convert.ToDecimal(txtDiscountInPercentage.Text);
            _productPrice.ProductCost = Convert.ToDecimal(txtProductCost.Text);
            _productPrice.ProductSalePrice = Convert.ToDecimal(txtProductSalePrice.Text);

            _productPrice.Description = txtDescription.Text;
            _productPrice.SetOn = DateTime.UtcNow;
            _productPrice.SetBy = 1;
            _productPrice.IsActive = chkIsActive.Checked;
        }

        private void CalculateProductSalePrice()
        {
            decimal purchaseUnitPrice = 0;
            decimal discountInPercentage = 0;
            decimal productCost = 0;

            if (!string.IsNullOrWhiteSpace(txtPurchaseUnitPrice.Text))
            {
                purchaseUnitPrice = Convert.ToDecimal(txtPurchaseUnitPrice.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(txtDiscountInPercentage.Text))
            {
                discountInPercentage = Convert.ToDecimal(txtDiscountInPercentage.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(txtProductCost.Text))
            {
                productCost = Convert.ToDecimal(txtProductCost.Text.Trim());
            }

            decimal discount = (purchaseUnitPrice + productCost) * discountInPercentage / 100;
            txtProductSalePrice.Text = Convert.ToString(purchaseUnitPrice + productCost - discount);
        }


        #endregion

        #region Private Events

        private void ProductPriceForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_purchaseReceiveDetail == null)
                {
                    Close();
                }
                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    _productPrice.Id = _productPriceService.Insert(_productPrice);
                }
                else
                {
                    _productPriceService.Update(_productPrice);
                }

                LoadFormWithData();
                MessageBox.Show(POSText.SaveMessage, MessageBoxCaptions.Success.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _isChanged = true;
        }

        private void txtDiscountInPercentage_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
            CalculateProductSalePrice();
        }

        private void txtProductCost_TextChanged(object sender, EventArgs e)
        {
            _isChanged = true;
            CalculateProductSalePrice();
        }

        #endregion
    }
}
