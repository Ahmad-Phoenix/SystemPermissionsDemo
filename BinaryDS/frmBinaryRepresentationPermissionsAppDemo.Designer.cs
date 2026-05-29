namespace BinaryDS
{
    partial class frmBinaryRepresentationPermissionsAppDemo
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
            this.components = new System.ComponentModel.Container();
            this.gbBinaryRepresentation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVerifyUserBinary = new System.Windows.Forms.TextBox();
            this.tbTotalUsersViewBinary = new System.Windows.Forms.TextBox();
            this.tbSetUserWarningBinary = new System.Windows.Forms.TextBox();
            this.tbShowUserListBinary = new System.Windows.Forms.TextBox();
            this.tbBlockBinary = new System.Windows.Forms.TextBox();
            this.tbUpdateBinary = new System.Windows.Forms.TextBox();
            this.tbAddUserBinary = new System.Windows.Forms.TextBox();
            this.tbDeleteBinary = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApplyPermissions = new System.Windows.Forms.Button();
            this.btnCheckPermission = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTotalUsersView = new System.Windows.Forms.Button();
            this.btnVerifyUser = new System.Windows.Forms.Button();
            this.btnSetUserWarning = new System.Windows.Forms.Button();
            this.btnShowUsersList = new System.Windows.Forms.Button();
            this.btnBlockUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lbPermissionAccess = new System.Windows.Forms.Label();
            this.cbSetUserWarning = new System.Windows.Forms.CheckBox();
            this.cbTotalUsersView = new System.Windows.Forms.CheckBox();
            this.cbDeleteUser = new System.Windows.Forms.CheckBox();
            this.cbVerifyUser = new System.Windows.Forms.CheckBox();
            this.cbAddUser = new System.Windows.Forms.CheckBox();
            this.cbUpdateUser = new System.Windows.Forms.CheckBox();
            this.cbShowUsersList = new System.Windows.Forms.CheckBox();
            this.cbBlockUser = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.epMainMenu = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbBinaryRepresentation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBinaryRepresentation
            // 
            this.gbBinaryRepresentation.Controls.Add(this.label1);
            this.gbBinaryRepresentation.Controls.Add(this.tbVerifyUserBinary);
            this.gbBinaryRepresentation.Controls.Add(this.tbTotalUsersViewBinary);
            this.gbBinaryRepresentation.Controls.Add(this.tbSetUserWarningBinary);
            this.gbBinaryRepresentation.Controls.Add(this.tbShowUserListBinary);
            this.gbBinaryRepresentation.Controls.Add(this.tbBlockBinary);
            this.gbBinaryRepresentation.Controls.Add(this.tbUpdateBinary);
            this.gbBinaryRepresentation.Controls.Add(this.tbAddUserBinary);
            this.gbBinaryRepresentation.Controls.Add(this.tbDeleteBinary);
            this.gbBinaryRepresentation.Location = new System.Drawing.Point(320, 92);
            this.gbBinaryRepresentation.Name = "gbBinaryRepresentation";
            this.gbBinaryRepresentation.Size = new System.Drawing.Size(253, 407);
            this.gbBinaryRepresentation.TabIndex = 12;
            this.gbBinaryRepresentation.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Binary Representation";
            // 
            // tbVerifyUserBinary
            // 
            this.tbVerifyUserBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbVerifyUserBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVerifyUserBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVerifyUserBinary.ForeColor = System.Drawing.SystemColors.Control;
            this.tbVerifyUserBinary.Location = new System.Drawing.Point(18, 307);
            this.tbVerifyUserBinary.Name = "tbVerifyUserBinary";
            this.tbVerifyUserBinary.ReadOnly = true;
            this.tbVerifyUserBinary.Size = new System.Drawing.Size(216, 33);
            this.tbVerifyUserBinary.TabIndex = 7;
            this.tbVerifyUserBinary.Text = "00000000";
            this.tbVerifyUserBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbVerifyUserBinary.MouseEnter += new System.EventHandler(this.MouseEnterBlue_MouseHover);
            this.tbVerifyUserBinary.MouseLeave += new System.EventHandler(this.LeaveWhite_MouseLeave);
            // 
            // tbTotalUsersViewBinary
            // 
            this.tbTotalUsersViewBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTotalUsersViewBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalUsersViewBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalUsersViewBinary.ForeColor = System.Drawing.SystemColors.Control;
            this.tbTotalUsersViewBinary.Location = new System.Drawing.Point(18, 352);
            this.tbTotalUsersViewBinary.Name = "tbTotalUsersViewBinary";
            this.tbTotalUsersViewBinary.ReadOnly = true;
            this.tbTotalUsersViewBinary.Size = new System.Drawing.Size(216, 33);
            this.tbTotalUsersViewBinary.TabIndex = 6;
            this.tbTotalUsersViewBinary.Text = "00000000";
            this.tbTotalUsersViewBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTotalUsersViewBinary.MouseEnter += new System.EventHandler(this.MouseEnterBlue_MouseHover);
            this.tbTotalUsersViewBinary.MouseLeave += new System.EventHandler(this.LeaveWhite_MouseLeave);
            // 
            // tbSetUserWarningBinary
            // 
            this.tbSetUserWarningBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbSetUserWarningBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSetUserWarningBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSetUserWarningBinary.ForeColor = System.Drawing.SystemColors.Control;
            this.tbSetUserWarningBinary.Location = new System.Drawing.Point(18, 262);
            this.tbSetUserWarningBinary.Name = "tbSetUserWarningBinary";
            this.tbSetUserWarningBinary.ReadOnly = true;
            this.tbSetUserWarningBinary.Size = new System.Drawing.Size(216, 33);
            this.tbSetUserWarningBinary.TabIndex = 5;
            this.tbSetUserWarningBinary.Text = "00000000";
            this.tbSetUserWarningBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSetUserWarningBinary.MouseEnter += new System.EventHandler(this.MouseEnterBlue_MouseHover);
            this.tbSetUserWarningBinary.MouseLeave += new System.EventHandler(this.LeaveWhite_MouseLeave);
            // 
            // tbShowUserListBinary
            // 
            this.tbShowUserListBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbShowUserListBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbShowUserListBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShowUserListBinary.ForeColor = System.Drawing.SystemColors.Control;
            this.tbShowUserListBinary.Location = new System.Drawing.Point(18, 217);
            this.tbShowUserListBinary.Name = "tbShowUserListBinary";
            this.tbShowUserListBinary.ReadOnly = true;
            this.tbShowUserListBinary.Size = new System.Drawing.Size(216, 33);
            this.tbShowUserListBinary.TabIndex = 4;
            this.tbShowUserListBinary.Text = "00000000";
            this.tbShowUserListBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbShowUserListBinary.MouseEnter += new System.EventHandler(this.MouseEnterBlue_MouseHover);
            this.tbShowUserListBinary.MouseLeave += new System.EventHandler(this.LeaveWhite_MouseLeave);
            // 
            // tbBlockBinary
            // 
            this.tbBlockBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbBlockBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBlockBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBlockBinary.ForeColor = System.Drawing.SystemColors.Control;
            this.tbBlockBinary.Location = new System.Drawing.Point(18, 172);
            this.tbBlockBinary.Name = "tbBlockBinary";
            this.tbBlockBinary.ReadOnly = true;
            this.tbBlockBinary.Size = new System.Drawing.Size(216, 33);
            this.tbBlockBinary.TabIndex = 3;
            this.tbBlockBinary.Text = "00000000";
            this.tbBlockBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBlockBinary.MouseEnter += new System.EventHandler(this.MouseEnterBlue_MouseHover);
            this.tbBlockBinary.MouseLeave += new System.EventHandler(this.LeaveWhite_MouseLeave);
            // 
            // tbUpdateBinary
            // 
            this.tbUpdateBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbUpdateBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUpdateBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateBinary.ForeColor = System.Drawing.SystemColors.Control;
            this.tbUpdateBinary.Location = new System.Drawing.Point(18, 127);
            this.tbUpdateBinary.Name = "tbUpdateBinary";
            this.tbUpdateBinary.ReadOnly = true;
            this.tbUpdateBinary.Size = new System.Drawing.Size(216, 33);
            this.tbUpdateBinary.TabIndex = 2;
            this.tbUpdateBinary.Text = "00000000";
            this.tbUpdateBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUpdateBinary.MouseEnter += new System.EventHandler(this.MouseEnterBlue_MouseHover);
            this.tbUpdateBinary.MouseLeave += new System.EventHandler(this.LeaveWhite_MouseLeave);
            // 
            // tbAddUserBinary
            // 
            this.tbAddUserBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAddUserBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddUserBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddUserBinary.ForeColor = System.Drawing.SystemColors.Control;
            this.tbAddUserBinary.Location = new System.Drawing.Point(18, 82);
            this.tbAddUserBinary.Name = "tbAddUserBinary";
            this.tbAddUserBinary.ReadOnly = true;
            this.tbAddUserBinary.Size = new System.Drawing.Size(216, 33);
            this.tbAddUserBinary.TabIndex = 1;
            this.tbAddUserBinary.Text = "00000000";
            this.tbAddUserBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAddUserBinary.MouseEnter += new System.EventHandler(this.MouseEnterBlue_MouseHover);
            this.tbAddUserBinary.MouseLeave += new System.EventHandler(this.LeaveWhite_MouseLeave);
            // 
            // tbDeleteBinary
            // 
            this.tbDeleteBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDeleteBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDeleteBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeleteBinary.ForeColor = System.Drawing.SystemColors.Control;
            this.tbDeleteBinary.Location = new System.Drawing.Point(18, 39);
            this.tbDeleteBinary.Name = "tbDeleteBinary";
            this.tbDeleteBinary.ReadOnly = true;
            this.tbDeleteBinary.Size = new System.Drawing.Size(216, 33);
            this.tbDeleteBinary.TabIndex = 0;
            this.tbDeleteBinary.Text = "00000000";
            this.tbDeleteBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDeleteBinary.MouseEnter += new System.EventHandler(this.MouseEnterBlue_MouseHover);
            this.tbDeleteBinary.MouseLeave += new System.EventHandler(this.LeaveWhite_MouseLeave);
            // 
            // tbUser
            // 
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(12, 45);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(134, 33);
            this.tbUser.TabIndex = 14;
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(172, 45);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(134, 33);
            this.tbPassword.TabIndex = 15;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(201, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // btnApplyPermissions
            // 
            this.btnApplyPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPermissions.Location = new System.Drawing.Point(12, 548);
            this.btnApplyPermissions.Name = "btnApplyPermissions";
            this.btnApplyPermissions.Size = new System.Drawing.Size(274, 48);
            this.btnApplyPermissions.TabIndex = 17;
            this.btnApplyPermissions.Text = "Apply Permissions";
            this.btnApplyPermissions.UseVisualStyleBackColor = true;
            this.btnApplyPermissions.Click += new System.EventHandler(this.btnApplyPermissions_Click);
            // 
            // btnCheckPermission
            // 
            this.btnCheckPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPermission.Location = new System.Drawing.Point(320, 548);
            this.btnCheckPermission.Name = "btnCheckPermission";
            this.btnCheckPermission.Size = new System.Drawing.Size(253, 48);
            this.btnCheckPermission.TabIndex = 18;
            this.btnCheckPermission.Text = "Check Permission";
            this.btnCheckPermission.UseVisualStyleBackColor = true;
            this.btnCheckPermission.Click += new System.EventHandler(this.btnCheckPermission_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 602);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 48);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTotalUsersView);
            this.groupBox2.Controls.Add(this.btnVerifyUser);
            this.groupBox2.Controls.Add(this.btnSetUserWarning);
            this.groupBox2.Controls.Add(this.btnShowUsersList);
            this.groupBox2.Controls.Add(this.btnBlockUser);
            this.groupBox2.Controls.Add(this.btnUpdateUser);
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Controls.Add(this.btnDeleteUser);
            this.groupBox2.Location = new System.Drawing.Point(610, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 407);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(23, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "User Permissions Access";
            // 
            // btnTotalUsersView
            // 
            this.btnTotalUsersView.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTotalUsersView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalUsersView.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTotalUsersView.Location = new System.Drawing.Point(27, 343);
            this.btnTotalUsersView.Name = "btnTotalUsersView";
            this.btnTotalUsersView.Size = new System.Drawing.Size(217, 39);
            this.btnTotalUsersView.TabIndex = 27;
            this.btnTotalUsersView.Tag = "";
            this.btnTotalUsersView.Text = "Total Users View";
            this.btnTotalUsersView.UseVisualStyleBackColor = false;
            this.btnTotalUsersView.Click += new System.EventHandler(this.ClickButton);
            // 
            // btnVerifyUser
            // 
            this.btnVerifyUser.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnVerifyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerifyUser.Location = new System.Drawing.Point(27, 298);
            this.btnVerifyUser.Name = "btnVerifyUser";
            this.btnVerifyUser.Size = new System.Drawing.Size(217, 39);
            this.btnVerifyUser.TabIndex = 26;
            this.btnVerifyUser.Tag = "";
            this.btnVerifyUser.Text = "Verify User";
            this.btnVerifyUser.UseVisualStyleBackColor = false;
            this.btnVerifyUser.Click += new System.EventHandler(this.ClickButton);
            // 
            // btnSetUserWarning
            // 
            this.btnSetUserWarning.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSetUserWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUserWarning.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSetUserWarning.Location = new System.Drawing.Point(27, 253);
            this.btnSetUserWarning.Name = "btnSetUserWarning";
            this.btnSetUserWarning.Size = new System.Drawing.Size(217, 39);
            this.btnSetUserWarning.TabIndex = 25;
            this.btnSetUserWarning.Tag = "";
            this.btnSetUserWarning.Text = "Set User Warning";
            this.btnSetUserWarning.UseVisualStyleBackColor = false;
            this.btnSetUserWarning.Click += new System.EventHandler(this.ClickButton);
            // 
            // btnShowUsersList
            // 
            this.btnShowUsersList.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnShowUsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUsersList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowUsersList.Location = new System.Drawing.Point(27, 208);
            this.btnShowUsersList.Name = "btnShowUsersList";
            this.btnShowUsersList.Size = new System.Drawing.Size(217, 39);
            this.btnShowUsersList.TabIndex = 24;
            this.btnShowUsersList.Tag = "";
            this.btnShowUsersList.Text = "Show Users List";
            this.btnShowUsersList.UseVisualStyleBackColor = false;
            this.btnShowUsersList.Click += new System.EventHandler(this.ClickButton);
            // 
            // btnBlockUser
            // 
            this.btnBlockUser.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBlockUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBlockUser.Location = new System.Drawing.Point(27, 163);
            this.btnBlockUser.Name = "btnBlockUser";
            this.btnBlockUser.Size = new System.Drawing.Size(217, 39);
            this.btnBlockUser.TabIndex = 23;
            this.btnBlockUser.Tag = "";
            this.btnBlockUser.Text = "Block User";
            this.btnBlockUser.UseVisualStyleBackColor = false;
            this.btnBlockUser.Click += new System.EventHandler(this.ClickButton);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateUser.Location = new System.Drawing.Point(27, 118);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(217, 39);
            this.btnUpdateUser.TabIndex = 22;
            this.btnUpdateUser.Tag = "";
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.ClickButton);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddUser.Location = new System.Drawing.Point(27, 73);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(217, 39);
            this.btnAddUser.TabIndex = 21;
            this.btnAddUser.Tag = "";
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.ClickButton);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteUser.Location = new System.Drawing.Point(27, 28);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(217, 39);
            this.btnDeleteUser.TabIndex = 20;
            this.btnDeleteUser.Tag = "";
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.ClickButton);
            // 
            // lbPermissionAccess
            // 
            this.lbPermissionAccess.AutoSize = true;
            this.lbPermissionAccess.Font = new System.Drawing.Font("Microsoft Tai Le", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermissionAccess.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPermissionAccess.Location = new System.Drawing.Point(315, 677);
            this.lbPermissionAccess.Name = "lbPermissionAccess";
            this.lbPermissionAccess.Size = new System.Drawing.Size(264, 27);
            this.lbPermissionAccess.TabIndex = 14;
            this.lbPermissionAccess.Text = "Permission Access Denied";
            // 
            // cbSetUserWarning
            // 
            this.cbSetUserWarning.AutoSize = true;
            this.cbSetUserWarning.BackColor = System.Drawing.Color.Black;
            this.cbSetUserWarning.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetUserWarning.ForeColor = System.Drawing.SystemColors.Control;
            this.cbSetUserWarning.Location = new System.Drawing.Point(34, 350);
            this.cbSetUserWarning.Name = "cbSetUserWarning";
            this.cbSetUserWarning.Size = new System.Drawing.Size(210, 39);
            this.cbSetUserWarning.TabIndex = 26;
            this.cbSetUserWarning.Text = "SetUserWarning";
            this.cbSetUserWarning.UseVisualStyleBackColor = false;
            // 
            // cbTotalUsersView
            // 
            this.cbTotalUsersView.AutoSize = true;
            this.cbTotalUsersView.BackColor = System.Drawing.Color.Black;
            this.cbTotalUsersView.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTotalUsersView.ForeColor = System.Drawing.SystemColors.Control;
            this.cbTotalUsersView.Location = new System.Drawing.Point(34, 440);
            this.cbTotalUsersView.Name = "cbTotalUsersView";
            this.cbTotalUsersView.Size = new System.Drawing.Size(205, 39);
            this.cbTotalUsersView.TabIndex = 28;
            this.cbTotalUsersView.Text = "TotalUsersView";
            this.cbTotalUsersView.UseVisualStyleBackColor = false;
            // 
            // cbDeleteUser
            // 
            this.cbDeleteUser.AutoSize = true;
            this.cbDeleteUser.BackColor = System.Drawing.Color.Black;
            this.cbDeleteUser.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.cbDeleteUser.Location = new System.Drawing.Point(34, 125);
            this.cbDeleteUser.Name = "cbDeleteUser";
            this.cbDeleteUser.Size = new System.Drawing.Size(156, 39);
            this.cbDeleteUser.TabIndex = 21;
            this.cbDeleteUser.Text = "DeleteUser";
            this.cbDeleteUser.UseVisualStyleBackColor = false;
            // 
            // cbVerifyUser
            // 
            this.cbVerifyUser.AutoSize = true;
            this.cbVerifyUser.BackColor = System.Drawing.Color.Black;
            this.cbVerifyUser.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVerifyUser.ForeColor = System.Drawing.SystemColors.Control;
            this.cbVerifyUser.Location = new System.Drawing.Point(34, 395);
            this.cbVerifyUser.Name = "cbVerifyUser";
            this.cbVerifyUser.Size = new System.Drawing.Size(145, 39);
            this.cbVerifyUser.TabIndex = 27;
            this.cbVerifyUser.Text = "VerifyUser";
            this.cbVerifyUser.UseVisualStyleBackColor = false;
            // 
            // cbAddUser
            // 
            this.cbAddUser.AutoSize = true;
            this.cbAddUser.BackColor = System.Drawing.Color.Black;
            this.cbAddUser.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddUser.ForeColor = System.Drawing.SystemColors.Control;
            this.cbAddUser.Location = new System.Drawing.Point(34, 170);
            this.cbAddUser.Name = "cbAddUser";
            this.cbAddUser.Size = new System.Drawing.Size(128, 39);
            this.cbAddUser.TabIndex = 22;
            this.cbAddUser.Text = "AddUser";
            this.cbAddUser.UseVisualStyleBackColor = false;
            // 
            // cbUpdateUser
            // 
            this.cbUpdateUser.AutoSize = true;
            this.cbUpdateUser.BackColor = System.Drawing.Color.Black;
            this.cbUpdateUser.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.cbUpdateUser.Location = new System.Drawing.Point(34, 215);
            this.cbUpdateUser.Name = "cbUpdateUser";
            this.cbUpdateUser.Size = new System.Drawing.Size(163, 39);
            this.cbUpdateUser.TabIndex = 23;
            this.cbUpdateUser.Text = "UpdateUser";
            this.cbUpdateUser.UseVisualStyleBackColor = false;
            // 
            // cbShowUsersList
            // 
            this.cbShowUsersList.AutoSize = true;
            this.cbShowUsersList.BackColor = System.Drawing.Color.Black;
            this.cbShowUsersList.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowUsersList.ForeColor = System.Drawing.SystemColors.Control;
            this.cbShowUsersList.Location = new System.Drawing.Point(34, 305);
            this.cbShowUsersList.Name = "cbShowUsersList";
            this.cbShowUsersList.Size = new System.Drawing.Size(195, 39);
            this.cbShowUsersList.TabIndex = 25;
            this.cbShowUsersList.Text = "ShowUsersList";
            this.cbShowUsersList.UseVisualStyleBackColor = false;
            // 
            // cbBlockUser
            // 
            this.cbBlockUser.AutoSize = true;
            this.cbBlockUser.BackColor = System.Drawing.Color.Black;
            this.cbBlockUser.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlockUser.ForeColor = System.Drawing.SystemColors.Control;
            this.cbBlockUser.Location = new System.Drawing.Point(34, 260);
            this.cbBlockUser.Name = "cbBlockUser";
            this.cbBlockUser.Size = new System.Drawing.Size(145, 39);
            this.cbBlockUser.TabIndex = 24;
            this.cbBlockUser.Text = "BlockUser";
            this.cbBlockUser.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(340, 44);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 33);
            this.btnLogin.TabIndex = 29;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 520);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 8);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(11, 659);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 8);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // clb
            // 
            this.clb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.ForeColor = System.Drawing.SystemColors.Info;
            this.clb.FormattingEnabled = true;
            this.clb.Items.AddRange(new object[] {
            "Permissions"});
            this.clb.Location = new System.Drawing.Point(12, 98);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(274, 401);
            this.clb.TabIndex = 20;
            this.clb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_ItemCheck);
            // 
            // epMainMenu
            // 
            this.epMainMenu.ContainerControl = this;
            // 
            // frmBinaryRepresentationPermissionsAppDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(910, 723);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbSetUserWarning);
            this.Controls.Add(this.cbTotalUsersView);
            this.Controls.Add(this.cbDeleteUser);
            this.Controls.Add(this.cbVerifyUser);
            this.Controls.Add(this.cbAddUser);
            this.Controls.Add(this.cbUpdateUser);
            this.Controls.Add(this.cbShowUsersList);
            this.Controls.Add(this.cbBlockUser);
            this.Controls.Add(this.clb);
            this.Controls.Add(this.lbPermissionAccess);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheckPermission);
            this.Controls.Add(this.btnApplyPermissions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.gbBinaryRepresentation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBinaryRepresentationPermissionsAppDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Binary Representation Permissions App Demo";
            this.Load += new System.EventHandler(this.frmBinaryRepresentationPermissionsAppDemo_Load);
            this.gbBinaryRepresentation.ResumeLayout(false);
            this.gbBinaryRepresentation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBinaryRepresentation;
        private System.Windows.Forms.TextBox tbDeleteBinary;
        private System.Windows.Forms.TextBox tbVerifyUserBinary;
        private System.Windows.Forms.TextBox tbTotalUsersViewBinary;
        private System.Windows.Forms.TextBox tbSetUserWarningBinary;
        private System.Windows.Forms.TextBox tbShowUserListBinary;
        private System.Windows.Forms.TextBox tbBlockBinary;
        private System.Windows.Forms.TextBox tbUpdateBinary;
        private System.Windows.Forms.TextBox tbAddUserBinary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApplyPermissions;
        private System.Windows.Forms.Button btnCheckPermission;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTotalUsersView;
        private System.Windows.Forms.Button btnVerifyUser;
        private System.Windows.Forms.Button btnSetUserWarning;
        private System.Windows.Forms.Button btnShowUsersList;
        private System.Windows.Forms.Button btnBlockUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPermissionAccess;
        private System.Windows.Forms.CheckBox cbSetUserWarning;
        private System.Windows.Forms.CheckBox cbTotalUsersView;
        private System.Windows.Forms.CheckBox cbDeleteUser;
        private System.Windows.Forms.CheckBox cbVerifyUser;
        private System.Windows.Forms.CheckBox cbAddUser;
        private System.Windows.Forms.CheckBox cbUpdateUser;
        private System.Windows.Forms.CheckBox cbShowUsersList;
        private System.Windows.Forms.CheckBox cbBlockUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.ErrorProvider epMainMenu;
    }
}

