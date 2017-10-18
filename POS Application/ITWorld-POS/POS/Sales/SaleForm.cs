using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using POS.BLL;
using POS.BLL.Inventory.Domain;
using POS.BLL.Inventory.Service;
using POS.BLL.Sales.Domain;
using POS.BLL.Sales.Service;
using POS.BLL.Security;
using POS.DAL.Inventory;
using POS.DAL.Sales;
using POS.Properties;
using POS.UTILS;

namespace POS.Sales
{
    public partial class SaleForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private ProductSearchForm _productSearchForm;

        private SaleModel _sale;
        private List<SaleDetailModel> _saleDetailList;
        private SaleDetailModel _saleDetail;
        internal ProductSearchInformation _productSearchInformation;
        private List<ProductSearchInformation> _productSearchInfoList;

        private readonly ISaleService _saleService;
        private readonly ISaleDetailService _saleDetailService;

        //decimal _totalSalePrice = 0;
        decimal _totalProductDiscountAmount = 0;
        //decimal _descountInPercentage = 0;
        //decimal _discountAmount = 0;
        //decimal _vatInPercentage = 0;
        //decimal _vatAmount = 0;
        //decimal _serviceCharge = 0;
        //decimal _netAmount = 0;

        #endregion

        #region Constructor

        public SaleForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();

            _saleService = kernel.GetService(typeof(SaleService)) as SaleService;
            _saleDetailService = kernel.GetService(typeof(SaleDetailService)) as SaleDetailService;

            _sale = new SaleModel();
            _saleDetail = new SaleDetailModel();
            _saleDetailList = new List<SaleDetailModel>();
        }

        #endregion

        #region Private Functions

        private void ClearForm()
        {
            txtSaleId.Text = "";
            txtSaleDate.Text = DateTime.UtcNow.ToShortDateString();
            txtSaleBy.Text = "user";//LoginInformation.UserInformation.Username;
            txtSaleInvoiceId.Text = "123";
            txtSaleInvoiceDate.Text = DateTime.UtcNow.ToShortDateString();
            txtDescription.Text = "";

            txtTotalPrice.Text = POSText.MinAmount;
            txtDiscountInPercentage.Text = POSText.MinAmount;
            txtDiscountAmount.Text = POSText.MinAmount;
            txtVATInPercentage.Text = POSText.MinAmount;
            txtVATAmount.Text = POSText.MinAmount;
            txtServiceCharge.Text = POSText.MinAmount;
            txtNetAmount.Text = POSText.MinAmount;

            _isAddNewMode = true;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtSaleDate.Text))
            {
                MessageBox.Show("Sale date is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSaleBy.Text))
            {
                MessageBox.Show("Sale by information is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSaleInvoiceId.Text))
            {
                MessageBox.Show("Sale invoice id is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSaleInvoiceDate.Text))
            {
                MessageBox.Show("Sale invoice date is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dgvProductList.Rows.Count <= 0)
            {
                MessageBox.Show("Product selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTotalPrice.Text))
            {
                MessageBox.Show("Total sale price is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiscountInPercentage.Text))
            {
                MessageBox.Show("Discount in percentage is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiscountAmount.Text))
            {
                MessageBox.Show("Discount amount is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } if (string.IsNullOrWhiteSpace(txtVATInPercentage.Text))
            {
                MessageBox.Show("VAT in percentage is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtVATAmount.Text))
            {
                MessageBox.Show("VAT amount is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtServiceCharge.Text))
            {
                MessageBox.Show("Service charge is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNetAmount.Text))
            {
                MessageBox.Show("Net amount is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadDataGridView()
        {
            Cursor = Cursors.WaitCursor;
            dgvProductList.DataSource = null;
            dgvProductList.DataSource = _saleDetailList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _sale.Id = Convert.ToInt64(txtSaleId.Text.Trim());
            }

            _sale.SaleDate = Convert.ToDateTime(txtSaleDate.Text);
            _sale.SaleBy = txtSaleBy.Text;
            _sale.SaleInvoiceId = Convert.ToInt64(txtSaleInvoiceId.Text);
            _sale.SaleInvoiceDate = Convert.ToDateTime(txtSaleInvoiceDate.Text);
            _sale.Description = txtDescription.Text;

            _sale.TotalSalePrice = Convert.ToDecimal(txtTotalPrice.Text);
            _sale.DiscountInPercentage = Convert.ToDecimal(txtDiscountInPercentage.Text);
            _sale.DiscountAmount = Convert.ToDecimal(txtDiscountAmount.Text);
            _sale.VATInPercentage = Convert.ToDecimal(txtVATInPercentage.Text);
            _sale.VATAmount = Convert.ToDecimal(txtVATAmount.Text);
            _sale.ServiceCharge = Convert.ToDecimal(txtServiceCharge.Text);
            _sale.NetAmount = Convert.ToDecimal(txtNetAmount.Text);

            _sale.Description = txtDescription.Text;
            _sale.IsActive = true;
            _sale.SetOn = DateTime.UtcNow;
            _sale.SetBy = 1;
        }

        private void CalculateVAT()
        {
            if (!string.IsNullOrWhiteSpace(txtVATInPercentage.Text))
            {
                _sale.VATInPercentage = Convert.ToDecimal(txtVATInPercentage.Text);
                _sale.VATAmount = _sale.TotalSalePrice * _sale.VATInPercentage / 100;
                txtVATAmount.Text = Convert.ToString(_sale.VATAmount);
            }
        }

        private void CalculateDiscount()
        {
            if (!_saleDetailList.Any(s => s.ProductDiscountAmount > 0) || _totalProductDiscountAmount == 0)
            {
                if (!string.IsNullOrWhiteSpace(txtDiscountInPercentage.Text))
                {
                    _sale.DiscountInPercentage = Convert.ToDecimal(txtDiscountInPercentage.Text);
                    _sale.DiscountAmount = _sale.TotalSalePrice * _sale.DiscountInPercentage / 100;
                }
            }
            else
            {
                _sale.DiscountAmount = _saleDetailList.Sum(s => s.ProductDiscountAmount);
            }
            txtDiscountAmount.Text = Convert.ToString(_sale.DiscountAmount);
        }

        private void CalculateSalePriceDetail()
        {

            _sale.TotalSalePrice = _saleDetailList.Sum(s => s.ProductTotalPrice);
            _totalProductDiscountAmount = _saleDetailList.Sum(s => s.ProductDiscountAmount);

            if (!string.IsNullOrWhiteSpace(txtServiceCharge.Text))
            {
                _sale.ServiceCharge = Convert.ToDecimal(txtServiceCharge.Text);
            }

            CalculateVAT();
            CalculateDiscount();

            _sale.NetAmount = !_saleDetailList.Any(s => s.ProductDiscountAmount > 0) || _totalProductDiscountAmount == 0
                ? _sale.TotalSalePrice - _sale.DiscountAmount + _sale.VATAmount + _sale.ServiceCharge
                : _sale.TotalSalePrice - _totalProductDiscountAmount + _sale.VATAmount + _sale.ServiceCharge;

            txtTotalPrice.Text = Convert.ToString(_sale.TotalSalePrice);
            txtNetAmount.Text = Convert.ToString(_sale.NetAmount);

            //decimal productUnitPrice = 0;
            //int productQuantity = 0;

            //if (!string.IsNullOrWhiteSpace(txtTotalSalePrice.Text))
            //{
            //    productUnitPrice = Convert.ToDecimal(txtTotalSalePrice.Text.Trim());
            //}
            //if (!string.IsNullOrWhiteSpace(txtDiscountInPercentage.Text))
            //{
            //    productQuantity = Convert.ToInt32(txtDiscountInPercentage.Text.Trim());
            //}
        }

        #endregion

        #region Private Events

        private void SaleForm_Load(object sender, EventArgs e)
        {
            try
            {
                
                Helper.InitializeDataGridView(dgvProductList);
                dgvProductList.ReadOnly = false;
                var dataGridViewColumn = dgvProductList.Columns["ProductQuantity"];
                if (dataGridViewColumn != null)
                {
                    dataGridViewColumn.ReadOnly = false;
                }
                //dgvProductList.CellValueChanged -= dgvProductList_CellValueChanged;
                //dgvProductList.CellValueChanged += dgvProductList_CellValueChanged;
                ClearForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
           ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //if (_productSearchForm != null && _productSearchForm.Visible)
            //{
            //    return;
            //}
            //_productSearchForm = new ProductSearchForm();
            //_productSearchForm.Show();

            _productSearchForm = new ProductSearchForm();

            // Show testDialog as a modal dialog and determine if DialogResult = OK. 
            _productSearchForm.ShowDialog();

            _productSearchInformation = _productSearchForm._productSearchInformation;

            var saleProduct = new SaleDetailModel
            {
                //SaleId
                ProductId = _productSearchInformation.ProductId,
                ProductName = _productSearchInformation.ProductName,
                ProductQuantity = 1,
                ProductUnitPrice = _productSearchInformation.ProductUnitPrice,
                ProductDiscountInPercentage = _productSearchInformation.DiscountInPercentage,
            };
            saleProduct.ProductDiscountAmount = saleProduct.ProductQuantity * saleProduct.ProductUnitPrice *
                                                    saleProduct.ProductDiscountInPercentage / 100;
            saleProduct.ProductTotalPrice = saleProduct.ProductQuantity * saleProduct.ProductUnitPrice -
                                                saleProduct.ProductDiscountAmount;

            _saleDetailList.Add(saleProduct);

            LoadDataGridView();
            _productSearchForm.Dispose();
            CalculateSalePriceDetail();
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
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmForPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(Resources.DeleteWarningMessage, MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

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
                    _sale.Id = _saleService.Insert(_sale);
                }
                else
                {
                    _saleService.Update(_sale);
                }

                LoadDataGridView();
                _currentIndex = _saleDetailList.FindIndex(r => r.Id == _sale.Id);
                MessageBox.Show(POSText.SaveMessage, MessageBoxCaptions.Success.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvProductList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductList.Rows.Count > 0)
            {
                if (e.ColumnIndex == dgvProductList.Rows[e.RowIndex].Cells["ProductQuantity"].ColumnIndex)
                {
                    //var productUnitPrice = Convert.ToDecimal(dgvProductList.Rows[e.RowIndex].Cells["ProductUnitPrice"].Value);
                    //var productDiscountInPercentage = Convert.ToDecimal(dgvProductList.Rows[e.RowIndex].Cells["ProductDiscountInPercentage"].Value);
                    //var productQuantity = Convert.ToInt16(dgvProductList.Rows[e.RowIndex].Cells["ProductQuantity"].Value);

                    if (dgvProductList.CurrentRow != null)
                    {
                        _currentIndex = dgvProductList.CurrentRow.Index;
                    }

                    _saleDetailList[_currentIndex].ProductQuantity = Convert.ToInt16(dgvProductList.Rows[_currentIndex].Cells["ProductQuantity"].Value);
                    _saleDetailList[_currentIndex].ProductDiscountAmount = (_saleDetailList[_currentIndex].ProductQuantity * _saleDetailList[_currentIndex].ProductUnitPrice) * _saleDetailList[_currentIndex].ProductDiscountInPercentage / 100;
                    _saleDetailList[_currentIndex].ProductTotalPrice = (_saleDetailList[_currentIndex].ProductQuantity * _saleDetailList[_currentIndex].ProductUnitPrice) - _saleDetailList[_currentIndex].ProductDiscountAmount;

                    dgvProductList.Rows[_currentIndex].Cells["ProductDiscountAmount"].Value = _saleDetailList[_currentIndex].ProductDiscountAmount;
                    dgvProductList.Rows[_currentIndex].Cells["ProductTotalPrice"].Value = _saleDetailList[_currentIndex].ProductTotalPrice;

                    CalculateSalePriceDetail();
                }
            }
        }

        private void txtVATInPercentage_TextChanged(object sender, EventArgs e)
        {
            CalculateVAT();
        }

        private void txtDiscountInPercentage_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        #endregion
    }
}
