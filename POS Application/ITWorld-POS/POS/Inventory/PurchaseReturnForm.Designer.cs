namespace POS.Inventory
{
    partial class PurchaseReturnForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvPurchaseChallanList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPurchaseReturnId = new System.Windows.Forms.TextBox();
            this.lblReturnNumber = new System.Windows.Forms.Label();
            this.txtReturnNumber = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChallanId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReceiveNumber = new System.Windows.Forms.TextBox();
            this.lblReceiveNumber = new System.Windows.Forms.Label();
            this.txtReturnBy = new System.Windows.Forms.TextBox();
            this.lblReceiveBy = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseChallanList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Moccasin;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.Location = new System.Drawing.Point(199, 214);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 24);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Moccasin;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Teal;
            this.btnLast.Location = new System.Drawing.Point(291, 214);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(89, 24);
            this.btnLast.TabIndex = 33;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Moccasin;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Teal;
            this.btnPrevious.Location = new System.Drawing.Point(107, 214);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(89, 24);
            this.btnPrevious.TabIndex = 31;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Moccasin;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Teal;
            this.btnFirst.Location = new System.Drawing.Point(12, 214);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(89, 24);
            this.btnFirst.TabIndex = 30;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
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
            this.id,
            this.ProductCategoryName,
            this.returnDate,
            this.returnBy,
            this.supplierId,
            this.challanId,
            this.description});
            this.dgvPurchaseChallanList.Location = new System.Drawing.Point(4, 19);
            this.dgvPurchaseChallanList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPurchaseChallanList.Name = "dgvPurchaseChallanList";
            this.dgvPurchaseChallanList.ReadOnly = true;
            this.dgvPurchaseChallanList.Size = new System.Drawing.Size(897, 186);
            this.dgvPurchaseChallanList.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Moccasin;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(812, 214);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 24);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.dgvPurchaseChallanList);
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnPrevious);
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 224);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(913, 250);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Purchase Return List";
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
            // txtPurchaseReturnId
            // 
            this.txtPurchaseReturnId.Enabled = false;
            this.txtPurchaseReturnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseReturnId.Location = new System.Drawing.Point(113, 27);
            this.txtPurchaseReturnId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchaseReturnId.Multiline = true;
            this.txtPurchaseReturnId.Name = "txtPurchaseReturnId";
            this.txtPurchaseReturnId.Size = new System.Drawing.Size(274, 25);
            this.txtPurchaseReturnId.TabIndex = 16;
            // 
            // lblReturnNumber
            // 
            this.lblReturnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnNumber.Location = new System.Drawing.Point(9, 56);
            this.lblReturnNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnNumber.Name = "lblReturnNumber";
            this.lblReturnNumber.Size = new System.Drawing.Size(118, 24);
            this.lblReturnNumber.TabIndex = 17;
            this.lblReturnNumber.Text = "Return Number";
            this.lblReturnNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReturnNumber
            // 
            this.txtReturnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnNumber.Location = new System.Drawing.Point(113, 56);
            this.txtReturnNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtReturnNumber.Multiline = true;
            this.txtReturnNumber.Name = "txtReturnNumber";
            this.txtReturnNumber.Size = new System.Drawing.Size(274, 25);
            this.txtReturnNumber.TabIndex = 18;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescription.Location = new System.Drawing.Point(404, 114);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 24);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(518, 115);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(274, 51);
            this.txtDescription.TabIndex = 20;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Moccasin;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Teal;
            this.btnAddNew.Location = new System.Drawing.Point(812, 28);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(89, 24);
            this.btnAddNew.TabIndex = 22;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Moccasin;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Location = new System.Drawing.Point(812, 112);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 24);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Moccasin;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.Location = new System.Drawing.Point(812, 84);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 24);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Moccasin;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.Location = new System.Drawing.Point(812, 56);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 24);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsActive.Location = new System.Drawing.Point(112, 146);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(77, 20);
            this.chkIsActive.TabIndex = 28;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnDate.Location = new System.Drawing.Point(8, 85);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(107, 24);
            this.lblReturnDate.TabIndex = 29;
            this.lblReturnDate.Text = "Return Date";
            this.lblReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Enabled = false;
            this.txtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnDate.Location = new System.Drawing.Point(112, 85);
            this.txtReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtReturnDate.Multiline = true;
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(274, 25);
            this.txtReturnDate.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(403, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Challan Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChallanId
            // 
            this.txtChallanId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanId.Location = new System.Drawing.Point(520, 86);
            this.txtChallanId.Margin = new System.Windows.Forms.Padding(2);
            this.txtChallanId.Multiline = true;
            this.txtChallanId.Name = "txtChallanId";
            this.txtChallanId.Size = new System.Drawing.Size(273, 25);
            this.txtChallanId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(403, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Supplier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierId.Location = new System.Drawing.Point(520, 57);
            this.txtSupplierId.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierId.Multiline = true;
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(272, 25);
            this.txtSupplierId.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnDetails);
            this.groupBox1.Controls.Add(this.txtReceiveNumber);
            this.groupBox1.Controls.Add(this.lblReceiveNumber);
            this.groupBox1.Controls.Add(this.txtReturnBy);
            this.groupBox1.Controls.Add(this.lblReceiveBy);
            this.groupBox1.Controls.Add(this.txtSupplierId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtChallanId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtReturnDate);
            this.groupBox1.Controls.Add(this.lblReturnDate);
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtReturnNumber);
            this.groupBox1.Controls.Add(this.lblReturnNumber);
            this.groupBox1.Controls.Add(this.txtPurchaseReturnId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(913, 207);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Return Information";
            // 
            // txtReceiveNumber
            // 
            this.txtReceiveNumber.Enabled = false;
            this.txtReceiveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiveNumber.Location = new System.Drawing.Point(520, 28);
            this.txtReceiveNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiveNumber.Multiline = true;
            this.txtReceiveNumber.Name = "txtReceiveNumber";
            this.txtReceiveNumber.Size = new System.Drawing.Size(272, 25);
            this.txtReceiveNumber.TabIndex = 48;
            // 
            // lblReceiveNumber
            // 
            this.lblReceiveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReceiveNumber.Location = new System.Drawing.Point(403, 28);
            this.lblReceiveNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiveNumber.Name = "lblReceiveNumber";
            this.lblReceiveNumber.Size = new System.Drawing.Size(119, 24);
            this.lblReceiveNumber.TabIndex = 47;
            this.lblReceiveNumber.Text = "Receive Number";
            this.lblReceiveNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReturnBy
            // 
            this.txtReturnBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnBy.Location = new System.Drawing.Point(113, 114);
            this.txtReturnBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtReturnBy.Multiline = true;
            this.txtReturnBy.Name = "txtReturnBy";
            this.txtReturnBy.Size = new System.Drawing.Size(274, 25);
            this.txtReturnBy.TabIndex = 46;
            // 
            // lblReceiveBy
            // 
            this.lblReceiveBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReceiveBy.Location = new System.Drawing.Point(9, 114);
            this.lblReceiveBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiveBy.Name = "lblReceiveBy";
            this.lblReceiveBy.Size = new System.Drawing.Size(107, 24);
            this.lblReceiveBy.TabIndex = 45;
            this.lblReceiveBy.Text = "Return By";
            this.lblReceiveBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Moccasin;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.Teal;
            this.btnDetails.Location = new System.Drawing.Point(812, 140);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(89, 59);
            this.btnDetails.TabIndex = 53;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.FillWeight = 37.2192F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.DataPropertyName = "purcahaseReturnNumber";
            this.ProductCategoryName.FillWeight = 138.8327F;
            this.ProductCategoryName.HeaderText = " Return No.";
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.ReadOnly = true;
            // 
            // returnDate
            // 
            this.returnDate.FillWeight = 141.2752F;
            this.returnDate.HeaderText = "Return Date";
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            // 
            // returnBy
            // 
            this.returnBy.FillWeight = 98.82851F;
            this.returnBy.HeaderText = "Return By";
            this.returnBy.Name = "returnBy";
            this.returnBy.ReadOnly = true;
            // 
            // supplierId
            // 
            this.supplierId.FillWeight = 83.58822F;
            this.supplierId.HeaderText = "Supplier";
            this.supplierId.Name = "supplierId";
            this.supplierId.ReadOnly = true;
            // 
            // challanId
            // 
            this.challanId.FillWeight = 121.8273F;
            this.challanId.HeaderText = "Challan";
            this.challanId.Name = "challanId";
            this.challanId.ReadOnly = true;
            // 
            // description
            // 
            this.description.FillWeight = 87.71924F;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // PurchaseReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(940, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PurchaseReturnForm";
            this.Text = "PurchaseReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseChallanList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvPurchaseChallanList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPurchaseReturnId;
        private System.Windows.Forms.Label lblReturnNumber;
        private System.Windows.Forms.TextBox txtReturnNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChallanId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReceiveNumber;
        private System.Windows.Forms.Label lblReceiveNumber;
        private System.Windows.Forms.TextBox txtReturnBy;
        private System.Windows.Forms.Label lblReceiveBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn challanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button btnDetails;
    }
}