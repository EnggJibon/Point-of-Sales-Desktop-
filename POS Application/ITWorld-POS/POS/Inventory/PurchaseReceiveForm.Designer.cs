namespace POS.Inventory
{
    partial class PurchaseReceiveForm
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
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChallanDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxChallan = new System.Windows.Forms.ComboBox();
            this.txtChallanNumber = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtReceiveDate = new System.Windows.Forms.TextBox();
            this.lblChallanDate = new System.Windows.Forms.Label();
            this.txtReceiveNumber = new System.Windows.Forms.TextBox();
            this.lblChallanNumber = new System.Windows.Forms.Label();
            this.txtPurchaseReceiveId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseChallanList = new System.Windows.Forms.DataGridView();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChallanNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseChallanList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtChallanDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxChallan);
            this.groupBox1.Controls.Add(this.txtChallanNumber);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtReceiveDate);
            this.groupBox1.Controls.Add(this.lblChallanDate);
            this.groupBox1.Controls.Add(this.txtReceiveNumber);
            this.groupBox1.Controls.Add(this.lblChallanNumber);
            this.groupBox1.Controls.Add(this.txtPurchaseReceiveId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnDetails);
            this.groupBox1.Controls.Add(this.txtReceivedBy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblDepartName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(865, 197);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Receive Information";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(498, 106);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Multiline = true;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(264, 25);
            this.txtSupplierName.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(391, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 94;
            this.label2.Text = "Supplier";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChallanDate
            // 
            this.txtChallanDate.Enabled = false;
            this.txtChallanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanDate.Location = new System.Drawing.Point(498, 78);
            this.txtChallanDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtChallanDate.Multiline = true;
            this.txtChallanDate.Name = "txtChallanDate";
            this.txtChallanDate.Size = new System.Drawing.Size(264, 25);
            this.txtChallanDate.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(391, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 92;
            this.label1.Text = "Challan Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxChallan
            // 
            this.cbxChallan.FormattingEnabled = true;
            this.cbxChallan.Location = new System.Drawing.Point(498, 20);
            this.cbxChallan.Name = "cbxChallan";
            this.cbxChallan.Size = new System.Drawing.Size(264, 24);
            this.cbxChallan.TabIndex = 91;
            this.cbxChallan.SelectedIndexChanged += new System.EventHandler(this.cbxChallan_SelectedIndexChanged);
            // 
            // txtChallanNumber
            // 
            this.txtChallanNumber.Enabled = false;
            this.txtChallanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanNumber.Location = new System.Drawing.Point(498, 48);
            this.txtChallanNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtChallanNumber.Multiline = true;
            this.txtChallanNumber.Name = "txtChallanNumber";
            this.txtChallanNumber.Size = new System.Drawing.Size(264, 25);
            this.txtChallanNumber.TabIndex = 90;
            // 
            // lblDesignation
            // 
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesignation.Location = new System.Drawing.Point(391, 48);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(115, 24);
            this.lblDesignation.TabIndex = 89;
            this.lblDesignation.Text = "Challan Number";
            this.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(391, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 24);
            this.lblName.TabIndex = 88;
            this.lblName.Text = "Challan Id";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReceiveDate
            // 
            this.txtReceiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiveDate.Location = new System.Drawing.Point(120, 77);
            this.txtReceiveDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiveDate.Multiline = true;
            this.txtReceiveDate.Name = "txtReceiveDate";
            this.txtReceiveDate.Size = new System.Drawing.Size(264, 25);
            this.txtReceiveDate.TabIndex = 87;
            // 
            // lblChallanDate
            // 
            this.lblChallanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallanDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChallanDate.Location = new System.Drawing.Point(8, 77);
            this.lblChallanDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChallanDate.Name = "lblChallanDate";
            this.lblChallanDate.Size = new System.Drawing.Size(107, 24);
            this.lblChallanDate.TabIndex = 86;
            this.lblChallanDate.Text = "Receive Date";
            this.lblChallanDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReceiveNumber
            // 
            this.txtReceiveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiveNumber.Location = new System.Drawing.Point(120, 48);
            this.txtReceiveNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiveNumber.Multiline = true;
            this.txtReceiveNumber.Name = "txtReceiveNumber";
            this.txtReceiveNumber.Size = new System.Drawing.Size(264, 25);
            this.txtReceiveNumber.TabIndex = 85;
            // 
            // lblChallanNumber
            // 
            this.lblChallanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallanNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChallanNumber.Location = new System.Drawing.Point(8, 48);
            this.lblChallanNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChallanNumber.Name = "lblChallanNumber";
            this.lblChallanNumber.Size = new System.Drawing.Size(118, 24);
            this.lblChallanNumber.TabIndex = 84;
            this.lblChallanNumber.Text = "Receive Number";
            this.lblChallanNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPurchaseReceiveId
            // 
            this.txtPurchaseReceiveId.Enabled = false;
            this.txtPurchaseReceiveId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseReceiveId.Location = new System.Drawing.Point(120, 20);
            this.txtPurchaseReceiveId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchaseReceiveId.Multiline = true;
            this.txtPurchaseReceiveId.Name = "txtPurchaseReceiveId";
            this.txtPurchaseReceiveId.Size = new System.Drawing.Size(264, 25);
            this.txtPurchaseReceiveId.TabIndex = 83;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblId.Location = new System.Drawing.Point(8, 20);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 24);
            this.lblId.TabIndex = 82;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Moccasin;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.Teal;
            this.btnDetails.Location = new System.Drawing.Point(767, 126);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(89, 36);
            this.btnDetails.TabIndex = 51;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedBy.Location = new System.Drawing.Point(120, 106);
            this.txtReceivedBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceivedBy.Multiline = true;
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.Size = new System.Drawing.Size(264, 25);
            this.txtReceivedBy.TabIndex = 46;
            this.txtReceivedBy.TextChanged += new System.EventHandler(this.txtDiscountInPercentage_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Received By";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsActive.Location = new System.Drawing.Point(498, 135);
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
            this.btnReset.Location = new System.Drawing.Point(767, 45);
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
            this.btnSave.Location = new System.Drawing.Point(767, 72);
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
            this.btnDelete.Location = new System.Drawing.Point(767, 99);
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
            this.btnAddNew.Location = new System.Drawing.Point(767, 18);
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
            this.txtDescription.Location = new System.Drawing.Point(120, 135);
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
            this.lblDepartName.Location = new System.Drawing.Point(8, 135);
            this.lblDepartName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(115, 24);
            this.lblDepartName.TabIndex = 19;
            this.lblDepartName.Text = "Description";
            this.lblDepartName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvPurchaseChallanList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 206);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(865, 174);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Purchase Receive List";
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
            this.ReceiveNumber,
            this.ChallanNumber,
            this.ReceiveDate,
            this.SupplierName,
            this.ReceivedBy});
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
            this.btnLast.Location = new System.Drawing.Point(283, 386);
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
            this.btnNext.Location = new System.Drawing.Point(191, 386);
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
            this.btnPrevious.Location = new System.Drawing.Point(99, 386);
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
            this.btnFirst.Location = new System.Drawing.Point(7, 386);
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
            this.btnClose.Location = new System.Drawing.Point(783, 386);
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
            this.Id.HeaderText = "Receive Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ReceiveNumber
            // 
            this.ReceiveNumber.DataPropertyName = "ReceiveNumber";
            this.ReceiveNumber.HeaderText = "Receive Number";
            this.ReceiveNumber.Name = "ReceiveNumber";
            this.ReceiveNumber.ReadOnly = true;
            // 
            // ChallanNumber
            // 
            this.ChallanNumber.DataPropertyName = "ChallanNumber";
            this.ChallanNumber.HeaderText = "Challan Number";
            this.ChallanNumber.Name = "ChallanNumber";
            this.ChallanNumber.ReadOnly = true;
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.DataPropertyName = "ReceiveDate";
            this.ReceiveDate.HeaderText = "Receive Date";
            this.ReceiveDate.Name = "ReceiveDate";
            this.ReceiveDate.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // ReceivedBy
            // 
            this.ReceivedBy.DataPropertyName = "ReceivedBy";
            this.ReceivedBy.HeaderText = "Received By";
            this.ReceivedBy.Name = "ReceivedBy";
            this.ReceivedBy.ReadOnly = true;
            // 
            // PurchaseReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(880, 416);
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
            this.Name = "PurchaseReceiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Receive Information";
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
        private System.Windows.Forms.TextBox txtReceivedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ComboBox cbxChallan;
        private System.Windows.Forms.TextBox txtChallanNumber;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtReceiveDate;
        private System.Windows.Forms.Label lblChallanDate;
        private System.Windows.Forms.TextBox txtReceiveNumber;
        private System.Windows.Forms.Label lblChallanNumber;
        private System.Windows.Forms.TextBox txtPurchaseReceiveId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtChallanDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedBy;

    }
}