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
    public partial class ProductSectionForm : Form
    {
        #region Private Variables

        private bool _isAddNewMode;
        private int _currentIndex;
        private bool _isChanged;

        private ProductSectionModel _productSection;
        private List<ProductSectionModel> _productSectionList;

        private readonly IProductSectionService _productSectionService;

        #endregion

        #region Constructor

        public ProductSectionForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _productSectionService = kernel.GetService(typeof(ProductSectionService)) as ProductSectionService;

            _productSection = new ProductSectionModel();
        }

        #endregion

        #region Private Functions

        private void ClearForm()
        {
            txtProductUnitId.Text = "";
            txtProductSectionName.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrWhiteSpace(txtProductSectionName.Text))
            {
                MessageBox.Show("Product Section name is required", MessageBoxCaptions.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_productSectionList == null || _productSectionList.Count <= 0)
            {
                _isAddNewMode = true;
                return;
            }

            _productSection = _productSectionList[_currentIndex];
            txtProductUnitId.Text = Convert.ToString(_productSection.Id);
            txtProductSectionName.Text = _productSection.ProductSectionName;
            txtDescription.Text = _productSection.Description;
            chkIsActive.Checked = _productSection.IsActive;

            dgvProductSectionList.Rows[_currentIndex].Selected = true;
            dgvProductSectionList.CurrentCell = dgvProductSectionList.Rows[_currentIndex].Cells[0];
            _isChanged = false;
            _isAddNewMode = false;
        }

        private void LoadDataGridView()
        {
            Helper.InitializeDataGridView(dgvProductSectionList);

            Cursor = Cursors.WaitCursor;
            _productSectionList = _productSectionService.GetAll().Where(w => !w.IsDeleted).ToList();
            dgvProductSectionList.DataSource = _productSectionList;
            Cursor = Cursors.Default;
        }

        private void SetModel()
        {
            if (!_isAddNewMode)
            {
                _productSection.Id = Convert.ToInt32(txtProductUnitId.Text.Trim());
            }
            _productSection.ProductSectionName = txtProductSectionName.Text;
            _productSection.Description = txtDescription.Text;
            _productSection.SetOn = DateTime.UtcNow;
            _productSection.SetBy = 1;
            _productSection.IsActive = chkIsActive.Checked;
        }

        #endregion

        #region Private Events

        private void ProductSectionForm_Load(object sender, EventArgs e)
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
                    _productSection.Id = _productSectionService.Insert(_productSection);
                }
                else
                {
                    _productSectionService.Update(_productSection);
                }

                LoadDataGridView();
                _currentIndex = _productSectionList.FindIndex(r => r.Id == _productSection.Id);
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

                _productSectionService.DeleteSoftly(_productSection.Id);
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
                if (dgvProductSectionList.Rows.Count > 0)
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
                if (dgvProductSectionList.Rows.Count > 0 && _currentIndex != 0)
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
                if (dgvProductSectionList.Rows.Count > 0 && _currentIndex != (dgvProductSectionList.Rows.Count - 1))
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
                if (dgvProductSectionList.Rows.Count > 0)
                {
                    _currentIndex = dgvProductSectionList.Rows.Count - 1;
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

        private void dgvProductSectionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductSectionList.Rows.Count > 0)
                {
                    if (dgvProductSectionList.CurrentRow != null)
                    {
                        _currentIndex = dgvProductSectionList.CurrentRow.Index;
                    }
                }

                LoadFormWithData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(POSText.ErrorMessage, MessageBoxCaptions.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProductSectionName_TextChanged(object sender, EventArgs e)
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
