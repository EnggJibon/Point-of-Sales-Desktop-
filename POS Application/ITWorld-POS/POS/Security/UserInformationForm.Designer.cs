namespace POS.Security
{
    partial class UserInformationForm
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
            this.chkIsLocked = new System.Windows.Forms.CheckBox();
            this.txtWrongPasswordTryLimit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIsSuperAdmin = new System.Windows.Forms.CheckBox();
            this.chkIsPasswordChanged = new System.Windows.Forms.CheckBox();
            this.txtLastLockedDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastPasswordChangedDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.chkIsLocked);
            this.groupBox1.Controls.Add(this.txtWrongPasswordTryLimit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkIsSuperAdmin);
            this.groupBox1.Controls.Add(this.chkIsPasswordChanged);
            this.groupBox1.Controls.Add(this.txtLastLockedDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLastPasswordChangedDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPasswordAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxRole);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxEmployee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxUserType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(892, 194);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // chkIsLocked
            // 
            this.chkIsLocked.AutoSize = true;
            this.chkIsLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsLocked.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsLocked.Location = new System.Drawing.Point(706, 135);
            this.chkIsLocked.Name = "chkIsLocked";
            this.chkIsLocked.Size = new System.Drawing.Size(85, 20);
            this.chkIsLocked.TabIndex = 49;
            this.chkIsLocked.Text = "Is Locked";
            this.chkIsLocked.UseVisualStyleBackColor = true;
            this.chkIsLocked.CheckedChanged += new System.EventHandler(this.chkIsLocked_CheckedChanged);
            // 
            // txtWrongPasswordTryLimit
            // 
            this.txtWrongPasswordTryLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrongPasswordTryLimit.Location = new System.Drawing.Point(549, 105);
            this.txtWrongPasswordTryLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtWrongPasswordTryLimit.Multiline = true;
            this.txtWrongPasswordTryLimit.Name = "txtWrongPasswordTryLimit";
            this.txtWrongPasswordTryLimit.Size = new System.Drawing.Size(238, 25);
            this.txtWrongPasswordTryLimit.TabIndex = 46;
            this.txtWrongPasswordTryLimit.TextChanged += new System.EventHandler(this.txtWrongPasswordTryLimit_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(362, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Wrong Password Try Limit";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkIsSuperAdmin
            // 
            this.chkIsSuperAdmin.AutoSize = true;
            this.chkIsSuperAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsSuperAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsSuperAdmin.Location = new System.Drawing.Point(549, 163);
            this.chkIsSuperAdmin.Name = "chkIsSuperAdmin";
            this.chkIsSuperAdmin.Size = new System.Drawing.Size(117, 20);
            this.chkIsSuperAdmin.TabIndex = 44;
            this.chkIsSuperAdmin.Text = "Is Super Admin";
            this.chkIsSuperAdmin.UseVisualStyleBackColor = true;
            this.chkIsSuperAdmin.CheckedChanged += new System.EventHandler(this.chkIsSuperAdmin_CheckedChanged);
            // 
            // chkIsPasswordChanged
            // 
            this.chkIsPasswordChanged.AutoSize = true;
            this.chkIsPasswordChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsPasswordChanged.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsPasswordChanged.Location = new System.Drawing.Point(549, 135);
            this.chkIsPasswordChanged.Name = "chkIsPasswordChanged";
            this.chkIsPasswordChanged.Size = new System.Drawing.Size(158, 20);
            this.chkIsPasswordChanged.TabIndex = 43;
            this.chkIsPasswordChanged.Text = "Is Password Changed";
            this.chkIsPasswordChanged.UseVisualStyleBackColor = true;
            this.chkIsPasswordChanged.CheckedChanged += new System.EventHandler(this.chkIsPasswordChanged_CheckedChanged);
            // 
            // txtLastLockedDate
            // 
            this.txtLastLockedDate.Enabled = false;
            this.txtLastLockedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastLockedDate.Location = new System.Drawing.Point(549, 77);
            this.txtLastLockedDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastLockedDate.Multiline = true;
            this.txtLastLockedDate.Name = "txtLastLockedDate";
            this.txtLastLockedDate.Size = new System.Drawing.Size(238, 25);
            this.txtLastLockedDate.TabIndex = 42;
            this.txtLastLockedDate.TextChanged += new System.EventHandler(this.txtLastLockedDate_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(362, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Last Locked Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastPasswordChangedDate
            // 
            this.txtLastPasswordChangedDate.Enabled = false;
            this.txtLastPasswordChangedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastPasswordChangedDate.Location = new System.Drawing.Point(549, 49);
            this.txtLastPasswordChangedDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastPasswordChangedDate.Multiline = true;
            this.txtLastPasswordChangedDate.Name = "txtLastPasswordChangedDate";
            this.txtLastPasswordChangedDate.Size = new System.Drawing.Size(238, 25);
            this.txtLastPasswordChangedDate.TabIndex = 40;
            this.txtLastPasswordChangedDate.TextChanged += new System.EventHandler(this.txtLastPasswordChangedDate_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(362, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Last Password Changed Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPasswordAge
            // 
            this.txtPasswordAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAge.Location = new System.Drawing.Point(549, 21);
            this.txtPasswordAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordAge.Multiline = true;
            this.txtPasswordAge.Name = "txtPasswordAge";
            this.txtPasswordAge.Size = new System.Drawing.Size(238, 25);
            this.txtPasswordAge.TabIndex = 38;
            this.txtPasswordAge.TextChanged += new System.EventHandler(this.txtPasswordAge_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(362, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Password Age";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(88, 161);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(264, 25);
            this.txtPassword.TabIndex = 36;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(88, 105);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(264, 24);
            this.cbxRole.TabIndex = 34;
            this.cbxRole.SelectedIndexChanged += new System.EventHandler(this.cbxRole_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Role";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(88, 77);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(264, 24);
            this.cbxEmployee.TabIndex = 32;
            this.cbxEmployee.SelectedIndexChanged += new System.EventHandler(this.cbxEmployee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Employee";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxUserType
            // 
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Location = new System.Drawing.Point(88, 49);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(264, 24);
            this.cbxUserType.TabIndex = 30;
            this.cbxUserType.SelectedIndexChanged += new System.EventHandler(this.cbxUserType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "User Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsActive.Location = new System.Drawing.Point(706, 163);
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
            this.btnReset.Location = new System.Drawing.Point(795, 49);
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
            this.btnSave.Location = new System.Drawing.Point(795, 77);
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
            this.btnDelete.Location = new System.Drawing.Point(795, 105);
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
            this.btnAddNew.Location = new System.Drawing.Point(795, 21);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(89, 24);
            this.btnAddNew.TabIndex = 22;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(88, 133);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(264, 25);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblDesignation
            // 
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesignation.Location = new System.Drawing.Point(7, 133);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(81, 24);
            this.lblDesignation.TabIndex = 17;
            this.lblDesignation.Text = "Username";
            this.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(88, 21);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(264, 25);
            this.txtUserId.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(7, 21);
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
            this.groupBox3.Controls.Add(this.dgvUserList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 204);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(892, 169);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User List";
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUserList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserTypeName,
            this.Username,
            this.EmployeeId,
            this.EmployeeName,
            this.EmployeeCode,
            this.DepartmentName,
            this.DesignationName,
            this.RoleName});
            this.dgvUserList.Location = new System.Drawing.Point(9, 20);
            this.dgvUserList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.Size = new System.Drawing.Size(875, 145);
            this.dgvUserList.TabIndex = 0;
            this.dgvUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellClick);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Moccasin;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Teal;
            this.btnLast.Location = new System.Drawing.Point(283, 378);
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
            this.btnNext.Location = new System.Drawing.Point(191, 378);
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
            this.btnPrevious.Location = new System.Drawing.Point(99, 378);
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
            this.btnFirst.Location = new System.Drawing.Point(7, 378);
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
            this.btnClose.Location = new System.Drawing.Point(810, 378);
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
            this.Id.HeaderText = "User Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UserTypeName
            // 
            this.UserTypeName.DataPropertyName = "UserTypeName";
            this.UserTypeName.HeaderText = "User Type";
            this.UserTypeName.Name = "UserTypeName";
            this.UserTypeName.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "Employee Code";
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "Department";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            // 
            // DesignationName
            // 
            this.DesignationName.DataPropertyName = "DesignationName";
            this.DesignationName.HeaderText = "Designation";
            this.DesignationName.Name = "DesignationName";
            this.DesignationName.ReadOnly = true;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Role";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // UserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(906, 409);
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
            this.Name = "UserInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.UserInformationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.CheckBox chkIsLocked;
        private System.Windows.Forms.TextBox txtWrongPasswordTryLimit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkIsSuperAdmin;
        private System.Windows.Forms.CheckBox chkIsPasswordChanged;
        private System.Windows.Forms.TextBox txtLastLockedDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastPasswordChangedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;

    }
}