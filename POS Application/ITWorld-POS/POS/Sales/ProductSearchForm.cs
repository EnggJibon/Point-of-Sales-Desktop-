using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using POS.BLL;
using POS.BLL.Inventory.Domain;
using POS.BLL.Inventory.Service;
using POS.UTILS;

namespace POS.Sales
{
    public partial class ProductSearchForm : Form
    {
        #region Private Variables

        private int _currentIndex;

        private ProductCategoryModel _productCategory;
        private List<ProductCategoryModel> _productCategoryList;
        private List<ProductSearchInformation> _productSearchInformationList;
        private readonly IProductCategoryService _productCategoryService;

        private List<ProductModel> _productList;
        private readonly IProductService _productService;

        internal ProductSearchInformation _productSearchInformation;

        #endregion

        #region Constructor

        public ProductSearchForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _productCategoryService = kernel.GetService(typeof(ProductCategoryService)) as ProductCategoryService;
            _productService = kernel.GetService(typeof(ProductService)) as ProductService;
            _productCategory = new ProductCategoryModel();
        }

        #endregion

        #region Private Function

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

        #endregion

        #region Private Event

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvProductSearchList);

            Cursor = Cursors.WaitCursor;
            _productSearchInformationList = _productService.GetAllProductInformation(null, txtProductName.Text.Trim(), null);
            dgvProductSearchList.DataSource = _productSearchInformationList;
            Cursor = Cursors.Default;
        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            LoadProductCategoryComboBox();
            LoadProductComboBox();
            _currentIndex = 0;

            cbxProduct.Enabled = false;
            cbxProductCategory.Enabled = false;
            txtProductName.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvProductSearchList.Rows.Count > 0)
            {
                if (dgvProductSearchList.CurrentRow != null)
                {
                    _currentIndex = dgvProductSearchList.CurrentRow.Index;
                }
            }

            if (_productSearchInformationList[_currentIndex].ProductQuantity<=0)
            {
                MessageBox.Show("Product is not available in store.", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _productSearchInformation = _productSearchInformationList[_currentIndex];
            Close();
        }

        private void btnProductDetail_Click(object sender, EventArgs e)
        {

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

        private void chkSearchProductWise_CheckedChanged(object sender, EventArgs e)
        {
            cbxProduct.Enabled = false;
            cbxProductCategory.Enabled = false;
            txtProductName.Enabled = true;
        }

        private void chkSearchProductCategoryWise_CheckedChanged(object sender, EventArgs e)
        {
            cbxProduct.Enabled = true;
            cbxProductCategory.Enabled = true;
            txtProductName.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        #endregion
    }
}
