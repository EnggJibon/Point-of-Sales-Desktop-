namespace POS.Shared
{
    sealed partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPOS = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleWiseScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseChallanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReceiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReturnReceiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productStoreInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPOS
            // 
            this.menuPOS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.securityAdministrationToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.menuPOS.Location = new System.Drawing.Point(0, 0);
            this.menuPOS.Name = "menuPOS";
            this.menuPOS.Size = new System.Drawing.Size(891, 24);
            this.menuPOS.TabIndex = 0;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // securityAdministrationToolStripMenuItem
            // 
            this.securityAdministrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleToolStripMenuItem,
            this.screenToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.roleWiseScreenToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.userTypeToolStripMenuItem,
            this.userToolStripMenuItem});
            this.securityAdministrationToolStripMenuItem.Name = "securityAdministrationToolStripMenuItem";
            this.securityAdministrationToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.securityAdministrationToolStripMenuItem.Text = "Security Administration";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.moduleToolStripMenuItem.Text = "Module Information";
            this.moduleToolStripMenuItem.Click += new System.EventHandler(this.moduleToolStripMenuItem_Click);
            // 
            // screenToolStripMenuItem
            // 
            this.screenToolStripMenuItem.Name = "screenToolStripMenuItem";
            this.screenToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.screenToolStripMenuItem.Text = "Screen Information";
            this.screenToolStripMenuItem.Click += new System.EventHandler(this.screenToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.roleToolStripMenuItem.Text = "Role Information";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // roleWiseScreenToolStripMenuItem
            // 
            this.roleWiseScreenToolStripMenuItem.Name = "roleWiseScreenToolStripMenuItem";
            this.roleWiseScreenToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.roleWiseScreenToolStripMenuItem.Text = "Role Wise Screen Information";
            this.roleWiseScreenToolStripMenuItem.Click += new System.EventHandler(this.roleWiseScreenToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.employeeToolStripMenuItem.Text = "Employee Information";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // userTypeToolStripMenuItem
            // 
            this.userTypeToolStripMenuItem.Name = "userTypeToolStripMenuItem";
            this.userTypeToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.userTypeToolStripMenuItem.Text = "User Type Information";
            this.userTypeToolStripMenuItem.Click += new System.EventHandler(this.userTypeToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.userToolStripMenuItem.Text = "User Information";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierToolStripMenuItem,
            this.productCategoryToolStripMenuItem,
            this.productUnitToolStripMenuItem,
            this.productSectionToolStripMenuItem,
            this.productToolStripMenuItem,
            this.purchaseChallanToolStripMenuItem,
            this.purchaseReceiveToolStripMenuItem,
            this.purchaseReturnToolStripMenuItem,
            this.productStoreInformationToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.supplierToolStripMenuItem.Text = "Supplier Information";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // productCategoryToolStripMenuItem
            // 
            this.productCategoryToolStripMenuItem.Name = "productCategoryToolStripMenuItem";
            this.productCategoryToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.productCategoryToolStripMenuItem.Text = "Product Category Information";
            this.productCategoryToolStripMenuItem.Click += new System.EventHandler(this.productCategoryToolStripMenuItem_Click);
            // 
            // productUnitToolStripMenuItem
            // 
            this.productUnitToolStripMenuItem.Name = "productUnitToolStripMenuItem";
            this.productUnitToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.productUnitToolStripMenuItem.Text = "Product Unit Information";
            this.productUnitToolStripMenuItem.Click += new System.EventHandler(this.productUnitToolStripMenuItem_Click);
            // 
            // productSectionToolStripMenuItem
            // 
            this.productSectionToolStripMenuItem.Name = "productSectionToolStripMenuItem";
            this.productSectionToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.productSectionToolStripMenuItem.Text = "Product Section Information";
            this.productSectionToolStripMenuItem.Click += new System.EventHandler(this.productSectionToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.productToolStripMenuItem.Text = "Product Information";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // purchaseChallanToolStripMenuItem
            // 
            this.purchaseChallanToolStripMenuItem.Name = "purchaseChallanToolStripMenuItem";
            this.purchaseChallanToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.purchaseChallanToolStripMenuItem.Text = "Purchase Challan Information";
            this.purchaseChallanToolStripMenuItem.Click += new System.EventHandler(this.purchaseChallanToolStripMenuItem_Click);
            // 
            // purchaseReceiveToolStripMenuItem
            // 
            this.purchaseReceiveToolStripMenuItem.Name = "purchaseReceiveToolStripMenuItem";
            this.purchaseReceiveToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.purchaseReceiveToolStripMenuItem.Text = "Purchase Receive Information";
            this.purchaseReceiveToolStripMenuItem.Click += new System.EventHandler(this.purchaseReceiveToolStripMenuItem_Click);
            // 
            // purchaseReturnToolStripMenuItem
            // 
            this.purchaseReturnToolStripMenuItem.Name = "purchaseReturnToolStripMenuItem";
            this.purchaseReturnToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.purchaseReturnToolStripMenuItem.Text = "Purchase Return Information";
            this.purchaseReturnToolStripMenuItem.Click += new System.EventHandler(this.purchaseReturnToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem,
            this.saleReturnReceiveToolStripMenuItem,
            this.salePaymentToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.saleToolStripMenuItem.Text = "Sale Information";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // saleReturnReceiveToolStripMenuItem
            // 
            this.saleReturnReceiveToolStripMenuItem.Name = "saleReturnReceiveToolStripMenuItem";
            this.saleReturnReceiveToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.saleReturnReceiveToolStripMenuItem.Text = "Sale Return Receive Information";
            this.saleReturnReceiveToolStripMenuItem.Click += new System.EventHandler(this.saleReturnReceiveToolStripMenuItem_Click);
            // 
            // salePaymentToolStripMenuItem
            // 
            this.salePaymentToolStripMenuItem.Name = "salePaymentToolStripMenuItem";
            this.salePaymentToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.salePaymentToolStripMenuItem.Text = "Sale Payment Information";
            this.salePaymentToolStripMenuItem.Click += new System.EventHandler(this.salePaymentToolStripMenuItem_Click);
            // 
            // productStoreInformationToolStripMenuItem
            // 
            this.productStoreInformationToolStripMenuItem.Name = "productStoreInformationToolStripMenuItem";
            this.productStoreInformationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.productStoreInformationToolStripMenuItem.Text = "Product Store Information";
            this.productStoreInformationToolStripMenuItem.Click += new System.EventHandler(this.productStoreInformationToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 504);
            this.Controls.Add(this.menuPOS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPOS;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menuPOS.ResumeLayout(false);
            this.menuPOS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPOS;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityAdministrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleWiseScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseChallanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReceiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReturnReceiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productStoreInformationToolStripMenuItem;
    }
}