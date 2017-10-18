using System;
using System.Drawing;
using System.Windows.Forms;
using POS.Inventory;
using POS.Properties;
using POS.Sales;
using POS.Security;

namespace POS.Shared
{
    public sealed partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            BackColor = Color.Teal;
            BackgroundImage = Resources.slide1_mobile_point_of_sale;
            BackgroundImageLayout = ImageLayout.Center;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            //TopMost = true;
            //FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //WindowState = FormWindowState.Normal;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void moduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var module = new ModuleForm
            {
                MdiParent = this
            };
            module.Show();
        }

        private void screenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var screen = new ScreenForm
            {
                MdiParent = this
            };
            screen.Show();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var role = new RoleForm
            {
                MdiParent = this
            };
            role.Show();
        }

        private void roleWiseScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var roleWiseScreenPermission = new RoleWiseScreenPermissionForm
            {
                MdiParent = this
            };
            roleWiseScreenPermission.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var employee = new EmployeeInformationForm
            {
                MdiParent = this
            };
            employee.Show();
        }

        private void userTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var userType = new UserTypeForm
            {
                MdiParent = this
            };
            userType.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var user = new UserInformationForm
            {
                MdiParent = this
            };
            user.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var supplierInformation = new SupplierInformationForm
            {
                MdiParent = this
            };
            supplierInformation.Show();
        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var productCategory = new ProductCategoryForm
            {
                MdiParent = this
            };
            productCategory.Show();
        }

        private void productSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var productItem = new ProductSectionForm
            {
                MdiParent = this
            };
            productItem.Show();
        }

        private void productUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var productUnit = new ProductUnitForm
            {
                MdiParent = this
            };
            productUnit.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var product = new ProductForm
            {
                MdiParent = this
            };
            product.Show();
        }

        private void purchaseChallanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var purchaseChallan = new PurchaseChallanForm
            {
                MdiParent = this
            };
            purchaseChallan.Show();
        }

        private void purchaseReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var purchaseReceive = new PurchaseReceiveForm
            {
                MdiParent = this
            };
            purchaseReceive.Show();
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var purchaseReturn = new PurchaseReturnForm
            {
                MdiParent = this
            };
            purchaseReturn.Show();
        }

        private void productStoreInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var productStore = new ProductStoreForm()
            {
                MdiParent = this
            };
            productStore.Show();
        } 

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var sale = new SaleForm
            {
                MdiParent = this
            };
            sale.Show();
        }

        private void saleReturnReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var saleReturnReceive = new SaleReturnReceiveForm
            {
                MdiParent = this
            };
            saleReturnReceive.Show();
        }

        private void salePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                return;
            }

            var salePayment = new SalePaymentForm
            {
                MdiParent = this
            };
            salePayment.Show();
        }              
    }
}
