namespace POS.Inventory
{
    partial class PurchaseChallanForm
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
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtOrderBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChallanDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.txtChallanNumber = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtPurchaseChallanId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseChallanList = new System.Windows.Forms.DataGridView();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChallanNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChallanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseChallanList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnDetails);
            this.groupBox1.Controls.Add(this.txtOrderBy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtChallanDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxSupplier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblDepartName);
            this.groupBox1.Controls.Add(this.txtChallanNumber);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.Controls.Add(this.txtPurchaseChallanId);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(865, 175);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Challan Information";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Moccasin;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.Teal;
            this.btnDetails.Location = new System.Drawing.Point(767, 128);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(89, 36);
            this.btnDetails.TabIndex = 51;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtOrderBy
            // 
            this.txtOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderBy.Location = new System.Drawing.Point(494, 20);
            this.txtOrderBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderBy.Multiline = true;
            this.txtOrderBy.Name = "txtOrderBy";
            this.txtOrderBy.Size = new System.Drawing.Size(264, 25);
            this.txtOrderBy.TabIndex = 46;
            this.txtOrderBy.TextChanged += new System.EventHandler(this.txtOrderBy_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(392, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Order By";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChallanDate
            // 
            this.txtChallanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanDate.Location = new System.Drawing.Point(119, 78);
            this.txtChallanDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtChallanDate.Multiline = true;
            this.txtChallanDate.Name = "txtChallanDate";
            this.txtChallanDate.Size = new System.Drawing.Size(264, 25);
            this.txtChallanDate.TabIndex = 44;
            this.txtChallanDate.TextChanged += new System.EventHandler(this.txtSupplierUnitPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Challan Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(119, 107);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(264, 24);
            this.cbxSupplier.TabIndex = 42;
            this.cbxSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxSupplier_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Supplier";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsActive.Location = new System.Drawing.Point(494, 107);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(77, 20);
            this.chkIsActive.TabIndex = 28;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Moccasin;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.Location = new System.Drawing.Point(767, 47);
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
            this.btnSave.Location = new System.Drawing.Point(767, 74);
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
            this.btnDelete.Location = new System.Drawing.Point(767, 101);
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
            this.btnAddNew.Location = new System.Drawing.Point(767, 20);
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
            this.txtDescription.Location = new System.Drawing.Point(494, 49);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(264, 54);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblDepartName
            // 
            this.lblDepartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartName.Location = new System.Drawing.Point(392, 49);
            this.lblDepartName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(81, 24);
            this.lblDepartName.TabIndex = 19;
            this.lblDepartName.Text = "Description";
            this.lblDepartName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChallanNumber
            // 
            this.txtChallanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanNumber.Location = new System.Drawing.Point(119, 49);
            this.txtChallanNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtChallanNumber.Multiline = true;
            this.txtChallanNumber.Name = "txtChallanNumber";
            this.txtChallanNumber.Size = new System.Drawing.Size(264, 25);
            this.txtChallanNumber.TabIndex = 18;
            this.txtChallanNumber.TextChanged += new System.EventHandler(this.txtProductCategoryName_TextChanged);
            // 
            // lblDesignation
            // 
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesignation.Location = new System.Drawing.Point(9, 49);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(117, 24);
            this.lblDesignation.TabIndex = 17;
            this.lblDesignation.Text = "Challan Number";
            this.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPurchaseChallanId
            // 
            this.txtPurchaseChallanId.Enabled = false;
            this.txtPurchaseChallanId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseChallanId.Location = new System.Drawing.Point(119, 20);
            this.txtPurchaseChallanId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchaseChallanId.Multiline = true;
            this.txtPurchaseChallanId.Name = "txtPurchaseChallanId";
            this.txtPurchaseChallanId.Size = new System.Drawing.Size(264, 25);
            this.txtPurchaseChallanId.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(9, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 24);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Id";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvPurchaseChallanList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 184);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(865, 174);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Purchase Challan List";
            // 
            // dgvPurchaseChallanList
            // 
            this.dgvPurchaseChallanList.AllowUserToAddRows = false;
            this.dgvPurchaseChallanList.AllowUserToDeleteRows = false;
            this.dgvPurchaseChallanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseChallanList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPurchaseChallanList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseChallanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseChallanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ChallanNumber,
            this.ChallanDate,
            this.SupplierName,
            this.OrderBy});
            this.dgvPurchaseChallanList.Location = new System.Drawing.Point(6, 21);
            this.dgvPurchaseChallanList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPurchaseChallanList.Name = "dgvPurchaseChallanList";
            this.dgvPurchaseChallanList.ReadOnly = true;
            this.dgvPurchaseChallanList.Size = new System.Drawing.Size(852, 145);
            this.dgvPurchaseChallanList.TabIndex = 0;
            this.dgvPurchaseChallanList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseChallanList_CellClick);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Moccasin;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Teal;
            this.btnLast.Location = new System.Drawing.Point(283, 362);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(89, 24);
            this.btnLast.TabIndex = 26;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Moccasin;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.Location = new System.Drawing.Point(191, 362);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 24);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Moccasin;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Teal;
            this.btnPrevious.Location = new System.Drawing.Point(99, 362);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(89, 24);
            this.btnPrevious.TabIndex = 24;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Moccasin;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Teal;
            this.btnFirst.Location = new System.Drawing.Point(7, 362);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(89, 24);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Moccasin;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(783, 362);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 24);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Purchase Challan Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ChallanNumber
            // 
            this.ChallanNumber.DataPropertyName = "ChallanNumber";
            this.ChallanNumber.HeaderText = "Challan Number";
            this.ChallanNumber.Name = "ChallanNumber";
            this.ChallanNumber.ReadOnly = true;
            // 
            // ChallanDate
            // 
            this.ChallanDate.DataPropertyName = "ChallanDate";
            this.ChallanDate.HeaderText = "Challan Date";
            this.ChallanDate.Name = "ChallanDate";
            this.ChallanDate.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // OrderBy
            // 
            this.OrderBy.DataPropertyName = "OrderBy";
            this.OrderBy.HeaderText = "Order By";
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.ReadOnly = true;
            // 
            // PurchaseChallanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(880, 392);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PurchaseChallanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Challan Information";
            this.Load += new System.EventHandler(this.PurchaseChallanForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseChallanList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.TextBox txtChallanNumber;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtPurchaseChallanId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvPurchaseChallanList;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtOrderBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChallanDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderBy;

    }
}