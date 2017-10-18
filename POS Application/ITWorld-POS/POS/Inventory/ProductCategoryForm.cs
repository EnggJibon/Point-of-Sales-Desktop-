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
    public partial class ProductCategoryForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private ProductCategoryModel _productCategory;
        private List<ProductCategoryModel> _productCategoryList;

        private readonly IProductCategoryService _productCategoryService;

        #endregion

        #region Constructor

        public ProductCategoryForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _productCategoryService = kernel.GetService(typeof(ProductCategoryService)) as ProductCategoryService;

            _productCategory = new ProductCategoryModel();
        }

        #endregion

        #region Private Functions

        private void ClearForm()
        {
            txtProductCategoryId.Text = "";
            txtProductCategoryName.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtProductCategoryName.Text))
            {
                MessageBox.Show("Product category name is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_productCategoryList == null || _productCategoryList.Count <= 0)
            {
                _isAddNewMode = true;
                return;
            }

            _productCategory = _productCategoryList[_currentIndex];
            txtProductCategoryId.Text = Convert.ToString(_productCategory.Id);
            txtProductCategoryName.Text = _productCategory.ProductCategoryName;
            txtDescription.Text = _productCategory.Description;
            chkIsActive.Checked = _productCategory.IsActive;

            dgvProductCategoryList.Rows[_currentIndex].Selected = true;
            dgvProductCategoryList.CurrentCell = dgvProductCategoryList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvProductCategoryList);

            Cursor = Cursors.WaitCursor;
            _productCategoryList = _productCategoryService.GetAll().Where(w => !w.IsDeleted).ToList();
            dgvProductCategoryList.DataSource = _productCategoryList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _productCategory.Id = Convert.ToInt32(txtProductCategoryId.Text.Trim());
            }
            _productCategory.ProductCategoryName = txtProductCategoryName.Text;
            _productCategory.Description = txtDescription.Text;
            _productCategory.SetOn = DateTime.UtcNow;
            _productCategory.SetBy = 1;
            _productCategory.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void ProductCategoryForm_Load(object sender, EventArgs e)
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
                    _productCategory.Id = _productCategoryService.Insert(_productCategory);
                }
                else
                {
                    _productCategoryService.Update(_productCategory);
                }

                LoadDataGridView();
                _currentIndex = _productCategoryList.FindIndex(r => r.Id == _productCategory.Id);
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

                _productCategoryService.DeleteSoftly(_productCategory.Id);
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
                if (dgvProductCategoryList.Rows.Count > 0)
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
                if (dgvProductCategoryList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvProductCategoryList.Rows.Count > 0 && _currentIndex != (dgvProductCategoryList.Rows.Count - 1))
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
                if (dgvProductCategoryList.Rows.Count > 0)
                {
                    _currentIndex = dgvProductCategoryList.Rows.Count - 1;
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

        private void dgvProductCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductCategoryList.Rows.Count > 0)
                {
                    if (dgvProductCategoryList.CurrentRow != null)
                    {
                        _currentIndex = dgvProductCategoryList.CurrentRow.Index;
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
