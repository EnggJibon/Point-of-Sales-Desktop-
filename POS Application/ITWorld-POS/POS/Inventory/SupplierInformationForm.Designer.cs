namespace POS.Inventory
{
    partial class SupplierInformationForm
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
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBankAccountNumber = new System.Windows.Forms.TextBox();
            this.lblBankAccNo = new System.Windows.Forms.Label();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.lblNID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtOwnNumber = new System.Windows.Forms.TextBox();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.lblTIN = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSupplierList = new System.Windows.Forms.DataGridView();
            this.supplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsActive.Location = new System.Drawing.Point(110, 204);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(77, 20);
            this.chkIsActive.TabIndex = 28;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Moccasin;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.Location = new System.Drawing.Point(790, 56);
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
            this.btnSave.Location = new System.Drawing.Point(790, 84);
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
            this.btnDelete.Location = new System.Drawing.Point(790, 112);
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
            this.btnAddNew.Location = new System.Drawing.Point(790, 28);
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
            this.txtDescription.Location = new System.Drawing.Point(111, 147);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(264, 51);
            this.txtDescription.TabIndex = 20;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescription.Location = new System.Drawing.Point(9, 147);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 24);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierCode.Location = new System.Drawing.Point(111, 57);
            this.txtSupplierCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierCode.Multiline = true;
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(264, 25);
            this.txtSupplierCode.TabIndex = 18;
            this.txtSupplierCode.TextChanged += new System.EventHandler(this.txtSupplierCode_TextChanged);
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplierCode.Location = new System.Drawing.Point(9, 57);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(101, 24);
            this.lblSupplierCode.TabIndex = 17;
            this.lblSupplierCode.Text = "Supplier Code";
            this.lblSupplierCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierId.Location = new System.Drawing.Point(111, 27);
            this.txtSupplierId.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierId.Multiline = true;
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(264, 25);
            this.txtSupplierId.TabIndex = 16;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblId.Location = new System.Drawing.Point(9, 27);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 24);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Moccasin;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Teal;
            this.btnFirst.Location = new System.Drawing.Point(12, 197);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(89, 24);
            this.btnFirst.TabIndex = 30;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtBankAccountNumber);
            this.groupBox1.Controls.Add(this.lblBankAccNo);
            this.groupBox1.Controls.Add(this.txtNID);
            this.groupBox1.Controls.Add(this.lblNID);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtContactNumber);
            this.groupBox1.Controls.Add(this.lblContactNumber);
            this.groupBox1.Controls.Add(this.txtOwnNumber);
            this.groupBox1.Controls.Add(this.lblOwnerName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblSupplierAddress);
            this.groupBox1.Controls.Add(this.txtTIN);
            this.groupBox1.Controls.Add(this.lblTIN);
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Controls.Add(this.lblSupplierName);
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtSupplierCode);
            this.groupBox1.Controls.Add(this.lblSupplierCode);
            this.groupBox1.Controls.Add(this.txtSupplierId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(886, 231);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankAccountNumber.Location = new System.Drawing.Point(505, 145);
            this.txtBankAccountNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtBankAccountNumber.Multiline = true;
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Size = new System.Drawing.Size(264, 25);
            this.txtBankAccountNumber.TabIndex = 44;
            this.txtBankAccountNumber.TextChanged += new System.EventHandler(this.txtBankAccountNumber_TextChanged);
            // 
            // lblBankAccNo
            // 
            this.lblBankAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankAccNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBankAccNo.Location = new System.Drawing.Point(395, 145);
            this.lblBankAccNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankAccNo.Name = "lblBankAccNo";
            this.lblBankAccNo.Size = new System.Drawing.Size(104, 24);
            this.lblBankAccNo.TabIndex = 43;
            this.lblBankAccNo.Text = "Bank Acc.No.";
            this.lblBankAccNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNID
            // 
            this.txtNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNID.Location = new System.Drawing.Point(505, 116);
            this.txtNID.Margin = new System.Windows.Forms.Padding(2);
            this.txtNID.Multiline = true;
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(264, 25);
            this.txtNID.TabIndex = 42;
            this.txtNID.TextChanged += new System.EventHandler(this.txtNID_TextChanged);
            // 
            // lblNID
            // 
            this.lblNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNID.Location = new System.Drawing.Point(395, 116);
            this.lblNID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(104, 24);
            this.lblNID.TabIndex = 41;
            this.lblNID.Text = "NID";
            this.lblNID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(505, 87);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 25);
            this.txtEmail.TabIndex = 40;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(395, 87);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(104, 24);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(505, 58);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Multiline = true;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(264, 25);
            this.txtContactNumber.TabIndex = 38;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContactNumber.Location = new System.Drawing.Point(395, 58);
            this.lblContactNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(106, 24);
            this.lblContactNumber.TabIndex = 37;
            this.lblContactNumber.Text = "Contact Number";
            this.lblContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOwnNumber
            // 
            this.txtOwnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnNumber.Location = new System.Drawing.Point(505, 29);
            this.txtOwnNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtOwnNumber.Multiline = true;
            this.txtOwnNumber.Name = "txtOwnNumber";
            this.txtOwnNumber.Size = new System.Drawing.Size(264, 25);
            this.txtOwnNumber.TabIndex = 36;
            this.txtOwnNumber.TextChanged += new System.EventHandler(this.txtOwnNumber_TextChanged);
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOwnerName.Location = new System.Drawing.Point(395, 29);
            this.lblOwnerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(105, 24);
            this.lblOwnerName.TabIndex = 35;
            this.lblOwnerName.Text = "Owner Name";
            this.lblOwnerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(111, 117);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(264, 25);
            this.txtAddress.TabIndex = 34;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplierAddress.Location = new System.Drawing.Point(9, 117);
            this.lblSupplierAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(99, 24);
            this.lblSupplierAddress.TabIndex = 33;
            this.lblSupplierAddress.Text = "Address";
            this.lblSupplierAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTIN
            // 
            this.txtTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIN.Location = new System.Drawing.Point(505, 174);
            this.txtTIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTIN.Multiline = true;
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(264, 25);
            this.txtTIN.TabIndex = 32;
            this.txtTIN.TextChanged += new System.EventHandler(this.txtTIN_TextChanged);
            // 
            // lblTIN
            // 
            this.lblTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTIN.Location = new System.Drawing.Point(395, 174);
            this.lblTIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTIN.Name = "lblTIN";
            this.lblTIN.Size = new System.Drawing.Size(104, 24);
            this.lblTIN.TabIndex = 31;
            this.lblTIN.Text = "TIN";
            this.lblTIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(111, 87);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Multiline = true;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(264, 25);
            this.txtSupplierName.TabIndex = 30;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtSupplierName_TextChanged);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplierName.Location = new System.Drawing.Point(9, 87);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(107, 24);
            this.lblSupplierName.TabIndex = 29;
            this.lblSupplierName.Text = "Supplier Name";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Moccasin;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Teal;
            this.btnLast.Location = new System.Drawing.Point(291, 197);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(89, 24);
            this.btnLast.TabIndex = 33;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Moccasin;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(794, 199);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 24);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Moccasin;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.Location = new System.Drawing.Point(199, 197);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 24);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Moccasin;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Teal;
            this.btnPrevious.Location = new System.Drawing.Point(107, 197);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(89, 24);
            this.btnPrevious.TabIndex = 31;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.dgvSupplierList);
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnPrevious);
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 257);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(886, 227);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier List";
            // 
            // dgvSupplierList
            // 
            this.dgvSupplierList.AllowUserToAddRows = false;
            this.dgvSupplierList.AllowUserToDeleteRows = false;
            this.dgvSupplierList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplierList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSupplierList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierCode,
            this.ProductCategoryName,
            this.contactNumber,
            this.bankAccNumber,
            this.ownerName,
            this.Address});
            this.dgvSupplierList.Location = new System.Drawing.Point(12, 19);
            this.dgvSupplierList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSupplierList.Name = "dgvSupplierList";
            this.dgvSupplierList.ReadOnly = true;
            this.dgvSupplierList.Size = new System.Drawing.Size(867, 176);
            this.dgvSupplierList.TabIndex = 0;
            this.dgvSupplierList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellClick);
            // 
            // supplierCode
            // 
            this.supplierCode.DataPropertyName = "SupplierCode";
            this.supplierCode.FillWeight = 94.76556F;
            this.supplierCode.HeaderText = "Supplier Code";
            this.supplierCode.MinimumWidth = 10;
            this.supplierCode.Name = "supplierCode";
            this.supplierCode.ReadOnly = true;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.DataPropertyName = "SupplierName";
            this.ProductCategoryName.FillWeight = 124.13F;
            this.ProductCategoryName.HeaderText = "Supplier Name";
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.ReadOnly = true;
            // 
            // contactNumber
            // 
            this.contactNumber.DataPropertyName = "ContactNumber";
            this.contactNumber.FillWeight = 90.25948F;
            this.contactNumber.HeaderText = "Contact No.";
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.ReadOnly = true;
            // 
            // bankAccNumber
            // 
            this.bankAccNumber.DataPropertyName = "BankAccountNumber";
            this.bankAccNumber.FillWeight = 121.8273F;
            this.bankAccNumber.HeaderText = "Bank Account No.";
            this.bankAccNumber.Name = "bankAccNumber";
            this.bankAccNumber.ReadOnly = true;
            // 
            // ownerName
            // 
            this.ownerName.DataPropertyName = "OwnerName";
            this.ownerName.FillWeight = 102.1336F;
            this.ownerName.HeaderText = "Owner Name";
            this.ownerName.Name = "ownerName";
            this.ownerName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 66.88354F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // SupplierInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(912, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupplierInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierInformationForm";
            this.Load += new System.EventHandler(this.SupplierInformationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBankAccountNumber;
        private System.Windows.Forms.Label lblBankAccNo;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtOwnNumber;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.TextBox txtTIN;
        private System.Windows.Forms.Label lblTIN;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSupplierList;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}