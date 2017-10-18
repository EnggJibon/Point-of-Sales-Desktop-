namespace POS.Sales
{
    partial class SaleForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDiscountInPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.txtSaleInvoiceDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaleInvoiceId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaleBy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSaleDate = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.txtSaleId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmForPayment = new System.Windows.Forms.Button();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVATAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVATInPercentage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscountInPercentage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Moccasin;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(824, 549);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 24);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvProductList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 151);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(906, 173);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sale Product Details";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductQuantity,
            this.ProductUnitPrice,
            this.ProductDiscountInPercentage,
            this.ProductDiscountAmount,
            this.ProductTotalPrice});
            this.dgvProductList.Location = new System.Drawing.Point(7, 20);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.Size = new System.Drawing.Size(888, 147);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            this.dgvProductList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellValueChanged);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DataPropertyName = "ProductQuantity";
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // ProductUnitPrice
            // 
            this.ProductUnitPrice.DataPropertyName = "ProductUnitPrice";
            this.ProductUnitPrice.HeaderText = "Unit Price";
            this.ProductUnitPrice.Name = "ProductUnitPrice";
            this.ProductUnitPrice.ReadOnly = true;
            // 
            // ProductDiscountInPercentage
            // 
            this.ProductDiscountInPercentage.DataPropertyName = "ProductDiscountInPercentage";
            this.ProductDiscountInPercentage.HeaderText = "Discount(%)";
            this.ProductDiscountInPercentage.Name = "ProductDiscountInPercentage";
            this.ProductDiscountInPercentage.ReadOnly = true;
            // 
            // ProductDiscountAmount
            // 
            this.ProductDiscountAmount.DataPropertyName = "ProductDiscountAmount";
            this.ProductDiscountAmount.HeaderText = "Discount Amount";
            this.ProductDiscountAmount.Name = "ProductDiscountAmount";
            this.ProductDiscountAmount.ReadOnly = true;
            // 
            // ProductTotalPrice
            // 
            this.ProductTotalPrice.DataPropertyName = "ProductTotalPrice";
            this.ProductTotalPrice.HeaderText = "Total Price";
            this.ProductTotalPrice.Name = "ProductTotalPrice";
            this.ProductTotalPrice.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Controls.Add(this.btnNewSale);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.lblDepartName);
            this.groupBox2.Controls.Add(this.txtSaleInvoiceDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSaleInvoiceId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSaleBy);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSaleDate);
            this.groupBox2.Controls.Add(this.Label);
            this.groupBox2.Controls.Add(this.txtSaleId);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(906, 141);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Information";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Moccasin;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.Location = new System.Drawing.Point(806, 52);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 24);
            this.btnReset.TabIndex = 107;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Moccasin;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Teal;
            this.btnAddProduct.Location = new System.Drawing.Point(751, 80);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(144, 54);
            this.btnAddProduct.TabIndex = 105;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.Moccasin;
            this.btnNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.ForeColor = System.Drawing.Color.Teal;
            this.btnNewSale.Location = new System.Drawing.Point(806, 23);
            this.btnNewSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(89, 24);
            this.btnNewSale.TabIndex = 104;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(480, 80);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 54);
            this.txtDescription.TabIndex = 103;
            // 
            // lblDepartName
            // 
            this.lblDepartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartName.Location = new System.Drawing.Point(359, 82);
            this.lblDepartName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(112, 24);
            this.lblDepartName.TabIndex = 102;
            this.lblDepartName.Text = "Description";
            this.lblDepartName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSaleInvoiceDate
            // 
            this.txtSaleInvoiceDate.Enabled = false;
            this.txtSaleInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleInvoiceDate.Location = new System.Drawing.Point(480, 51);
            this.txtSaleInvoiceDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleInvoiceDate.Multiline = true;
            this.txtSaleInvoiceDate.Name = "txtSaleInvoiceDate";
            this.txtSaleInvoiceDate.Size = new System.Drawing.Size(251, 25);
            this.txtSaleInvoiceDate.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(359, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 100;
            this.label7.Text = "Sale Invoice Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSaleInvoiceId
            // 
            this.txtSaleInvoiceId.Enabled = false;
            this.txtSaleInvoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleInvoiceId.Location = new System.Drawing.Point(480, 22);
            this.txtSaleInvoiceId.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleInvoiceId.Multiline = true;
            this.txtSaleInvoiceId.Name = "txtSaleInvoiceId";
            this.txtSaleInvoiceId.Size = new System.Drawing.Size(251, 25);
            this.txtSaleInvoiceId.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(359, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 98;
            this.label6.Text = "Sale Invoice Id";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSaleBy
            // 
            this.txtSaleBy.Enabled = false;
            this.txtSaleBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleBy.Location = new System.Drawing.Point(92, 77);
            this.txtSaleBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleBy.Multiline = true;
            this.txtSaleBy.Name = "txtSaleBy";
            this.txtSaleBy.Size = new System.Drawing.Size(251, 25);
            this.txtSaleBy.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(9, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 96;
            this.label9.Text = "Sale By";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSaleDate
            // 
            this.txtSaleDate.Enabled = false;
            this.txtSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleDate.Location = new System.Drawing.Point(92, 48);
            this.txtSaleDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleDate.Multiline = true;
            this.txtSaleDate.Name = "txtSaleDate";
            this.txtSaleDate.Size = new System.Drawing.Size(251, 25);
            this.txtSaleDate.TabIndex = 66;
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label.Location = new System.Drawing.Point(9, 47);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(100, 24);
            this.Label.TabIndex = 65;
            this.Label.Text = "Sale Date";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSaleId
            // 
            this.txtSaleId.Enabled = false;
            this.txtSaleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleId.Location = new System.Drawing.Point(92, 19);
            this.txtSaleId.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleId.Multiline = true;
            this.txtSaleId.Name = "txtSaleId";
            this.txtSaleId.Size = new System.Drawing.Size(251, 25);
            this.txtSaleId.TabIndex = 64;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(9, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 24);
            this.lblName.TabIndex = 63;
            this.lblName.Text = "Sale Id";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnConfirmForPayment);
            this.groupBox1.Controls.Add(this.txtNetAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtServiceCharge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVATAmount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtVATInPercentage);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDiscountAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiscountInPercentage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 330);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(906, 215);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Price Details";
            // 
            // btnConfirmForPayment
            // 
            this.btnConfirmForPayment.BackColor = System.Drawing.Color.Moccasin;
            this.btnConfirmForPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmForPayment.ForeColor = System.Drawing.Color.Teal;
            this.btnConfirmForPayment.Location = new System.Drawing.Point(751, 15);
            this.btnConfirmForPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmForPayment.Name = "btnConfirmForPayment";
            this.btnConfirmForPayment.Size = new System.Drawing.Size(144, 52);
            this.btnConfirmForPayment.TabIndex = 106;
            this.btnConfirmForPayment.Text = "Confirm for Payment";
            this.btnConfirmForPayment.UseVisualStyleBackColor = false;
            this.btnConfirmForPayment.Click += new System.EventHandler(this.btnConfirmForPayment_Click);
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.Location = new System.Drawing.Point(427, 183);
            this.txtNetAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetAmount.Multiline = true;
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(304, 25);
            this.txtNetAmount.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(254, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 99;
            this.label3.Text = "Net Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Enabled = false;
            this.txtServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCharge.Location = new System.Drawing.Point(427, 155);
            this.txtServiceCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceCharge.Multiline = true;
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(304, 25);
            this.txtServiceCharge.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(254, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 97;
            this.label4.Text = "Service Charge";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVATAmount
            // 
            this.txtVATAmount.Enabled = false;
            this.txtVATAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVATAmount.Location = new System.Drawing.Point(427, 127);
            this.txtVATAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtVATAmount.Multiline = true;
            this.txtVATAmount.Name = "txtVATAmount";
            this.txtVATAmount.Size = new System.Drawing.Size(304, 25);
            this.txtVATAmount.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(254, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 24);
            this.label10.TabIndex = 95;
            this.label10.Text = "VAT Amount";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVATInPercentage
            // 
            this.txtVATInPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVATInPercentage.Location = new System.Drawing.Point(427, 99);
            this.txtVATInPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.txtVATInPercentage.Multiline = true;
            this.txtVATInPercentage.Name = "txtVATInPercentage";
            this.txtVATInPercentage.Size = new System.Drawing.Size(304, 25);
            this.txtVATInPercentage.TabIndex = 94;
            this.txtVATInPercentage.TextChanged += new System.EventHandler(this.txtVATInPercentage_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(254, 99);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 24);
            this.label11.TabIndex = 93;
            this.label11.Text = "VAT In Percentage";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Enabled = false;
            this.txtDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountAmount.Location = new System.Drawing.Point(427, 71);
            this.txtDiscountAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountAmount.Multiline = true;
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(304, 25);
            this.txtDiscountAmount.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(254, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 24);
            this.label8.TabIndex = 78;
            this.label8.Text = "Discount Amount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(427, 15);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(304, 25);
            this.txtTotalPrice.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(254, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Total Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountInPercentage
            // 
            this.txtDiscountInPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountInPercentage.Location = new System.Drawing.Point(427, 43);
            this.txtDiscountInPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountInPercentage.Multiline = true;
            this.txtDiscountInPercentage.Name = "txtDiscountInPercentage";
            this.txtDiscountInPercentage.Size = new System.Drawing.Size(304, 25);
            this.txtDiscountInPercentage.TabIndex = 52;
            this.txtDiscountInPercentage.TextChanged += new System.EventHandler(this.txtDiscountInPercentage_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(254, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Discount In Percentage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(922, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Information";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSaleDate;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox txtSaleId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.TextBox txtSaleInvoiceDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaleInvoiceId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaleBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscountInPercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVATAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVATInPercentage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConfirmForPayment;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDiscountInPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalPrice;

    }
}