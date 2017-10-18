namespace POS.Inventory
{
    partial class PurchaseReceiveDetailsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxPurchaseChallanDetail = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProductCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalProductPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.txtPurchaseReceiveDetailId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProductDetailList = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPurchaseReceiveNumber = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.txtPurchaseReceiveId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.PurchaseChallanDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetailList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.cbxPurchaseChallanDetail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxProduct);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxProductCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotalProductPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtProductUnitPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.txtProductQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblDepartName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(915, 192);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Receive Product Information";
            // 
            // cbxPurchaseChallanDetail
            // 
            this.cbxPurchaseChallanDetail.FormattingEnabled = true;
            this.cbxPurchaseChallanDetail.Location = new System.Drawing.Point(160, 23);
            this.cbxPurchaseChallanDetail.Name = "cbxPurchaseChallanDetail";
            this.cbxPurchaseChallanDetail.Size = new System.Drawing.Size(264, 24);
            this.cbxPurchaseChallanDetail.TabIndex = 92;
            this.cbxPurchaseChallanDetail.SelectedIndexChanged += new System.EventHandler(this.cbxPurchaseChallanDetail_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 24);
            this.label5.TabIndex = 91;
            this.label5.Text = "Purchase Challan Detail";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxProduct
            // 
            this.cbxProduct.Enabled = false;
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(160, 82);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(264, 24);
            this.cbxProduct.TabIndex = 90;
            this.cbxProduct.SelectedIndexChanged += new System.EventHandler(this.cbxProduct_SelectedIndexChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(160, 111);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(264, 25);
            this.txtProductName.TabIndex = 89;
            // 
            // lblDesignation
            // 
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesignation.Location = new System.Drawing.Point(9, 111);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(122, 24);
            this.lblDesignation.TabIndex = 88;
            this.lblDesignation.Text = "Product Name";
            this.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 86;
            this.label4.Text = "Product Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxProductCategory
            // 
            this.cbxProductCategory.Enabled = false;
            this.cbxProductCategory.FormattingEnabled = true;
            this.cbxProductCategory.Location = new System.Drawing.Point(160, 53);
            this.cbxProductCategory.Name = "cbxProductCategory";
            this.cbxProductCategory.Size = new System.Drawing.Size(264, 24);
            this.cbxProductCategory.TabIndex = 85;
            this.cbxProductCategory.SelectedIndexChanged += new System.EventHandler(this.cbxProductCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 84;
            this.label3.Text = "Product Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalProductPrice
            // 
            this.txtTotalProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProductPrice.Location = new System.Drawing.Point(554, 82);
            this.txtTotalProductPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalProductPrice.Multiline = true;
            this.txtTotalProductPrice.Name = "txtTotalProductPrice";
            this.txtTotalProductPrice.Size = new System.Drawing.Size(251, 25);
            this.txtTotalProductPrice.TabIndex = 79;
            this.txtTotalProductPrice.TextChanged += new System.EventHandler(this.txtTotalProductPrice_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(430, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 24);
            this.label8.TabIndex = 78;
            this.label8.Text = "Product Total Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProductUnitPrice
            // 
            this.txtProductUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductUnitPrice.Location = new System.Drawing.Point(554, 24);
            this.txtProductUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductUnitPrice.Multiline = true;
            this.txtProductUnitPrice.Name = "txtProductUnitPrice";
            this.txtProductUnitPrice.Size = new System.Drawing.Size(251, 25);
            this.txtProductUnitPrice.TabIndex = 77;
            this.txtProductUnitPrice.TextChanged += new System.EventHandler(this.txtProductUnitPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(430, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Product Unit Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsActive.Location = new System.Drawing.Point(554, 170);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(77, 20);
            this.chkIsActive.TabIndex = 65;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQuantity.Location = new System.Drawing.Point(554, 53);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductQuantity.Multiline = true;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(251, 25);
            this.txtProductQuantity.TabIndex = 52;
            this.txtProductQuantity.TextChanged += new System.EventHandler(this.txtProductQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(430, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Product Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Moccasin;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.Location = new System.Drawing.Point(816, 50);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 24);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Moccasin;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.Location = new System.Drawing.Point(816, 77);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 24);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Moccasin;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Location = new System.Drawing.Point(816, 104);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 24);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Moccasin;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Teal;
            this.btnAddNew.Location = new System.Drawing.Point(816, 23);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(89, 24);
            this.btnAddNew.TabIndex = 22;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(554, 111);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 54);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblDepartName
            // 
            this.lblDepartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartName.Location = new System.Drawing.Point(430, 113);
            this.lblDepartName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(112, 24);
            this.lblDepartName.TabIndex = 19;
            this.lblDepartName.Text = "Description";
            this.lblDepartName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPurchaseReceiveDetailId
            // 
            this.txtPurchaseReceiveDetailId.Enabled = false;
            this.txtPurchaseReceiveDetailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseReceiveDetailId.Location = new System.Drawing.Point(816, 23);
            this.txtPurchaseReceiveDetailId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchaseReceiveDetailId.Multiline = true;
            this.txtPurchaseReceiveDetailId.Name = "txtPurchaseReceiveDetailId";
            this.txtPurchaseReceiveDetailId.Size = new System.Drawing.Size(76, 25);
            this.txtPurchaseReceiveDetailId.TabIndex = 91;
            this.txtPurchaseReceiveDetailId.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Moccasin;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(833, 448);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 24);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Moccasin;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Teal;
            this.btnLast.Location = new System.Drawing.Point(283, 448);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(89, 24);
            this.btnLast.TabIndex = 32;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Moccasin;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.Location = new System.Drawing.Point(191, 448);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 24);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvProductDetailList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 271);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(915, 173);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Purchase Receive Product List";
            // 
            // dgvProductDetailList
            // 
            this.dgvProductDetailList.AllowUserToAddRows = false;
            this.dgvProductDetailList.AllowUserToDeleteRows = false;
            this.dgvProductDetailList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductDetailList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProductDetailList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseChallanDetailId,
            this.ProductName,
            this.ProductCategoryName,
            this.ProductUnitPrice,
            this.ProductQuantity,
            this.TotalPrice});
            this.dgvProductDetailList.Location = new System.Drawing.Point(7, 20);
            this.dgvProductDetailList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductDetailList.Name = "dgvProductDetailList";
            this.dgvProductDetailList.ReadOnly = true;
            this.dgvProductDetailList.Size = new System.Drawing.Size(900, 147);
            this.dgvProductDetailList.TabIndex = 0;
            this.dgvProductDetailList.Click += new System.EventHandler(this.dgvProductDetailList_CellClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Moccasin;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Teal;
            this.btnPrevious.Location = new System.Drawing.Point(99, 448);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(89, 24);
            this.btnPrevious.TabIndex = 30;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Moccasin;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Teal;
            this.btnFirst.Location = new System.Drawing.Point(7, 448);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(89, 24);
            this.btnFirst.TabIndex = 29;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.txtPurchaseReceiveDetailId);
            this.groupBox2.Controls.Add(this.txtPurchaseReceiveNumber);
            this.groupBox2.Controls.Add(this.Label);
            this.groupBox2.Controls.Add(this.txtPurchaseReceiveId);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(915, 62);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Receive Information";
            // 
            // txtPurchaseReceiveNumber
            // 
            this.txtPurchaseReceiveNumber.Enabled = false;
            this.txtPurchaseReceiveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseReceiveNumber.Location = new System.Drawing.Point(554, 22);
            this.txtPurchaseReceiveNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchaseReceiveNumber.Multiline = true;
            this.txtPurchaseReceiveNumber.Name = "txtPurchaseReceiveNumber";
            this.txtPurchaseReceiveNumber.Size = new System.Drawing.Size(251, 25);
            this.txtPurchaseReceiveNumber.TabIndex = 66;
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label.Location = new System.Drawing.Point(430, 22);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(120, 24);
            this.Label.TabIndex = 65;
            this.Label.Text = "Receive Number";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPurchaseReceiveId
            // 
            this.txtPurchaseReceiveId.Enabled = false;
            this.txtPurchaseReceiveId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseReceiveId.Location = new System.Drawing.Point(160, 22);
            this.txtPurchaseReceiveId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchaseReceiveId.Multiline = true;
            this.txtPurchaseReceiveId.Name = "txtPurchaseReceiveId";
            this.txtPurchaseReceiveId.Size = new System.Drawing.Size(264, 25);
            this.txtPurchaseReceiveId.TabIndex = 64;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(9, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 24);
            this.lblName.TabIndex = 63;
            this.lblName.Text = "Purchase Receive Id";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PurchaseChallanDetailId
            // 
            this.PurchaseChallanDetailId.DataPropertyName = "PurchaseChallanDetailId";
            this.PurchaseChallanDetailId.HeaderText = "Challan Detail Id";
            this.PurchaseChallanDetailId.Name = "PurchaseChallanDetailId";
            this.PurchaseChallanDetailId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.DataPropertyName = "ProductCategoryName";
            this.ProductCategoryName.HeaderText = "Product Category Name";
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.ReadOnly = true;
            // 
            // ProductUnitPrice
            // 
            this.ProductUnitPrice.DataPropertyName = "ProductUnitPrice";
            this.ProductUnitPrice.HeaderText = "Unit Price";
            this.ProductUnitPrice.Name = "ProductUnitPrice";
            this.ProductUnitPrice.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DataPropertyName = "ProductQuantity";
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // PurchaseReceiveDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(936, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PurchaseReceiveDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Receive Detail Information";
            this.Load += new System.EventHandler(this.PurchaseReceiveDetailsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetailList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProductDetailList;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPurchaseReceiveNumber;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox txtPurchaseReceiveId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTotalProductPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProductCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPurchaseReceiveDetailId;
        private System.Windows.Forms.ComboBox cbxPurchaseChallanDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseChallanDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;

    }
}