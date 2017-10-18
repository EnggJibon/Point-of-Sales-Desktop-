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
    public partial class ProductForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private ProductModel _product;
        private List<ProductModel> _productList;
        private List<ProductCategoryModel> _productCategoryList;

        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;

        #endregion

        #region Constructor

        public ProductForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _productService = kernel.GetService(typeof(ProductService)) as ProductService;
            _productCategoryService = kernel.GetService(typeof(ProductCategoryService)) as ProductCategoryService;

            _product = new ProductModel();
        }

        #endregion

        #region Private Functions

        private void LoadProductCategoryComboBox()
        {
            Helper.InitializeComboBox(cbxProductCategory);

            Cursor = Cursors.WaitCursor;
            _productCategoryList = _productCategoryService.GetAll().Where(w => !w.IsDeleted).ToList();
            Cursor = Cursors.Default;
            cbxProductCategory.DataSource = _productCategoryList;
            cbxProductCategory.DisplayMember = "ProductCategoryName";
            cbxProductCategory.ValueMember = "Id";
        }

        private void ClearForm()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            cbxProductCategory.SelectedIndex = -1;
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbxProductCategory.SelectedItem == null || cbxProductCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Product category selection is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_productList == null || _productList.Count <= 0)
            {
                _isAddNewMode = true;
                return;
            }

            _product = _productList[_currentIndex];
            txtProductId.Text = Convert.ToString(_product.Id);
            txtProductName.Text = _product.ProductName;
            cbxProductCategory.SelectedValue = _product.ProductCategoryId;
            txtDescription.Text = _product.Description;
            chkIsActive.Checked = _product.IsActive;

            dgvProductList.Rows[_currentIndex].Selected = true;
            dgvProductList.CurrentCell = dgvProductList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvProductList);

            Cursor = Cursors.WaitCursor;
            _productList = _productService.GetAll().Where(w => !w.IsDeleted).ToList();
            dgvProductList.DataSource = _productList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _product.Id = Convert.ToInt32(txtProductId.Text.Trim());
            }
            _product.ProductName = txtProductName.Text;
            _product.ProductCategoryId = Convert.ToInt64(cbxProductCategory.SelectedValue);
            _product.Description = txtDescription.Text;
            _product.SetOn = DateTime.UtcNow;
            _product.SetBy = 1;
            _product.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProductCategoryComboBox();
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
                    _product.Id = _productService.Insert(_product);
                }
                else
                {
                    _productService.Update(_product);
                }

                LoadDataGridView();
                _currentIndex = _productList.FindIndex(r => r.Id == _product.Id);
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

                _productService.DeleteSoftly(_product.Id);
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

        #endregion
    }
}
