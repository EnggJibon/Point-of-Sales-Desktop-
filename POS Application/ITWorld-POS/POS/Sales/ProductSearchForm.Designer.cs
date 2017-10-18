namespace POS.Sales
{
    partial class ProductSearchForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.cbxProductCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProductSearchList = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseReceiveDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountInPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProductDetail = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSearchProductCategoryWise = new System.Windows.Forms.CheckBox();
            this.chkSearchProductWise = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearchList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.cbxProduct);
            this.groupBox2.Controls.Add(this.cbxProductCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(192, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(545, 115);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Search Information";
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(147, 49);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(264, 24);
            this.cbxProduct.TabIndex = 28;
            this.cbxProduct.SelectedIndexChanged += new System.EventHandler(this.cbxProduct_SelectedIndexChanged);
            // 
            // cbxProductCategory
            // 
            this.cbxProductCategory.FormattingEnabled = true;
            this.cbxProductCategory.Location = new System.Drawing.Point(147, 21);
            this.cbxProductCategory.Name = "cbxProductCategory";
            this.cbxProductCategory.Size = new System.Drawing.Size(264, 24);
            this.cbxProductCategory.TabIndex = 27;
            this.cbxProductCategory.SelectedIndexChanged += new System.EventHandler(this.cbxProductCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Moccasin;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Teal;
            this.btnSearch.Location = new System.Drawing.Point(423, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 83);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search Product";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(147, 77);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(264, 25);
            this.txtProductName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dgvProductSearchList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(901, 200);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Search Detail";
            // 
            // dgvProductSearchList
            // 
            this.dgvProductSearchList.AllowUserToAddRows = false;
            this.dgvProductSearchList.AllowUserToDeleteRows = false;
            this.dgvProductSearchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductSearchList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProductSearchList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductSearchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ReceiveNumber,
            this.ReceiveDate,
            this.PurchaseReceiveDetailId,
            this.ProductQuantity,
            this.ProductUnitPrice,
            this.DiscountInPercentage});
            this.dgvProductSearchList.Location = new System.Drawing.Point(4, 19);
            this.dgvProductSearchList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductSearchList.Name = "dgvProductSearchList";
            this.dgvProductSearchList.ReadOnly = true;
            this.dgvProductSearchList.Size = new System.Drawing.Size(893, 176);
            this.dgvProductSearchList.TabIndex = 16;
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
            // ReceiveNumber
            // 
            this.ReceiveNumber.DataPropertyName = "ReceiveNumber";
            this.ReceiveNumber.HeaderText = "Receive Number";
            this.ReceiveNumber.Name = "ReceiveNumber";
            this.ReceiveNumber.ReadOnly = true;
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.DataPropertyName = "ReceiveDate";
            this.ReceiveDate.HeaderText = "Receive Date";
            this.ReceiveDate.Name = "ReceiveDate";
            this.ReceiveDate.ReadOnly = true;
            // 
            // PurchaseReceiveDetailId
            // 
            this.PurchaseReceiveDetailId.DataPropertyName = "PurchaseReceiveDetailId";
            this.PurchaseReceiveDetailId.HeaderText = "Receive Detail Id";
            this.PurchaseReceiveDetailId.Name = "PurchaseReceiveDetailId";
            this.PurchaseReceiveDetailId.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DataPropertyName = "ProductQuantity";
            this.ProductQuantity.HeaderText = "Product Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // ProductUnitPrice
            // 
            this.ProductUnitPrice.DataPropertyName = "ProductUnitPrice";
            this.ProductUnitPrice.HeaderText = "Product Unit Price";
            this.ProductUnitPrice.Name = "ProductUnitPrice";
            this.ProductUnitPrice.ReadOnly = true;
            // 
            // DiscountInPercentage
            // 
            this.DiscountInPercentage.DataPropertyName = "DiscountInPercentage";
            this.DiscountInPercentage.HeaderText = "Discount In Percentage";
            this.DiscountInPercentage.Name = "DiscountInPercentage";
            this.DiscountInPercentage.ReadOnly = true;
            // 
            // btnProductDetail
            // 
            this.btnProductDetail.BackColor = System.Drawing.Color.Moccasin;
            this.btnProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDetail.ForeColor = System.Drawing.Color.Teal;
            this.btnProductDetail.Location = new System.Drawing.Point(490, 403);
            this.btnProductDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductDetail.Name = "btnProductDetail";
            this.btnProductDetail.Size = new System.Drawing.Size(132, 29);
            this.btnProductDetail.TabIndex = 26;
            this.btnProductDetail.Text = "Product Detail";
            this.btnProductDetail.UseVisualStyleBackColor = false;
            this.btnProductDetail.Click += new System.EventHandler(this.btnProductDetail_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Moccasin;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Teal;
            this.btnSelect.Location = new System.Drawing.Point(348, 403);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(132, 29);
            this.btnSelect.TabIndex = 25;
            this.btnSelect.Text = "Select Product";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSearchProductCategoryWise);
            this.groupBox3.Controls.Add(this.chkSearchProductWise);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(287, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 62);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Type";
            // 
            // chkSearchProductCategoryWise
            // 
            this.chkSearchProductCategoryWise.AutoSize = true;
            this.chkSearchProductCategoryWise.Location = new System.Drawing.Point(97, 16);
            this.chkSearchProductCategoryWise.Name = "chkSearchProductCategoryWise";
            this.chkSearchProductCategoryWise.Size = new System.Drawing.Size(200, 17);
            this.chkSearchProductCategoryWise.TabIndex = 32;
            this.chkSearchProductCategoryWise.Text = "Search Product Category Wise";
            this.chkSearchProductCategoryWise.UseVisualStyleBackColor = false;
            this.chkSearchProductCategoryWise.CheckedChanged += new System.EventHandler(this.chkSearchProductCategoryWise_CheckedChanged);
            // 
            // chkSearchProductWise
            // 
            this.chkSearchProductWise.AutoSize = true;
            this.chkSearchProductWise.Location = new System.Drawing.Point(98, 35);
            this.chkSearchProductWise.Name = "chkSearchProductWise";
            this.chkSearchProductWise.Size = new System.Drawing.Size(146, 17);
            this.chkSearchProductWise.TabIndex = 31;
            this.chkSearchProductWise.Text = "Search Product Wise";
            this.chkSearchProductWise.UseVisualStyleBackColor = true;
            this.chkSearchProductWise.CheckedChanged += new System.EventHandler(this.chkSearchProductWise_CheckedChanged);
            // 
            // ProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(923, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnProductDetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductSearchForm";
            this.Text = "ProductSearchForm";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearchList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProductDetail;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvProductSearchList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseReceiveDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountInPercentage;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.ComboBox cbxProductCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSearchProductCategoryWise;
        private System.Windows.Forms.CheckBox chkSearchProductWise;



    }
}