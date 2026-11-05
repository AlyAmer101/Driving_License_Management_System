namespace DVLD.Users
{
    partial class frmUsersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManagement));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsMangeUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenueItemShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenueItemAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenueItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenueItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenueItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenueItemSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.MenueItemCallPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsers2 = new DVLD.dsUsers2();
            this.pcManagePeople = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsersFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.usersTableAdapter = new DVLD.dsUsers2TableAdapters.UsersTableAdapter();
            this.FormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsMangeUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsers2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcManagePeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn,
            this.FullName,
            this.userNameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dgvUsers.ContextMenuStrip = this.cmsMangeUsers;
            this.dgvUsers.DataSource = this.usersBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(22, 367);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.ShowEditingIcon = false;
            this.dgvUsers.Size = new System.Drawing.Size(1020, 348);
            this.dgvUsers.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 320F;
            this.FullName.HeaderText = "FullName";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 320;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 150;
            // 
            // cmsMangeUsers
            // 
            this.cmsMangeUsers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsMangeUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenueItemShowDetails,
            this.toolStripSeparator1,
            this.MenueItemAddNewUser,
            this.MenueItemEdit,
            this.MenueItemDelete,
            this.MenueItemChangePassword,
            this.MenueItemSendEmail,
            this.MenueItemCallPhone});
            this.cmsMangeUsers.Name = "cmsMangeUsers";
            this.cmsMangeUsers.Size = new System.Drawing.Size(225, 234);
            this.cmsMangeUsers.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMangeUsers_Opening);
            // 
            // MenueItemShowDetails
            // 
            this.MenueItemShowDetails.Name = "MenueItemShowDetails";
            this.MenueItemShowDetails.Size = new System.Drawing.Size(224, 32);
            this.MenueItemShowDetails.Text = "Show Details";
            this.MenueItemShowDetails.Click += new System.EventHandler(this.MenueItemShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // MenueItemAddNewUser
            // 
            this.MenueItemAddNewUser.Name = "MenueItemAddNewUser";
            this.MenueItemAddNewUser.Size = new System.Drawing.Size(224, 32);
            this.MenueItemAddNewUser.Text = "Add New User";
            this.MenueItemAddNewUser.Click += new System.EventHandler(this.MenueItemAddNewUser_Click);
            // 
            // MenueItemEdit
            // 
            this.MenueItemEdit.Name = "MenueItemEdit";
            this.MenueItemEdit.Size = new System.Drawing.Size(224, 32);
            this.MenueItemEdit.Text = "Edit ";
            this.MenueItemEdit.Click += new System.EventHandler(this.MenueItemEdit_Click);
            // 
            // MenueItemDelete
            // 
            this.MenueItemDelete.Name = "MenueItemDelete";
            this.MenueItemDelete.Size = new System.Drawing.Size(224, 32);
            this.MenueItemDelete.Text = "Delete";
            this.MenueItemDelete.Click += new System.EventHandler(this.MenueItemDelete_Click);
            // 
            // MenueItemChangePassword
            // 
            this.MenueItemChangePassword.Name = "MenueItemChangePassword";
            this.MenueItemChangePassword.Size = new System.Drawing.Size(224, 32);
            this.MenueItemChangePassword.Text = "Change Password";
            this.MenueItemChangePassword.Click += new System.EventHandler(this.MenueItemChangePassword_Click);
            // 
            // MenueItemSendEmail
            // 
            this.MenueItemSendEmail.Name = "MenueItemSendEmail";
            this.MenueItemSendEmail.Size = new System.Drawing.Size(224, 32);
            this.MenueItemSendEmail.Text = "Send Email";
            this.MenueItemSendEmail.Click += new System.EventHandler(this.MenueItemSendEmail_Click);
            // 
            // MenueItemCallPhone
            // 
            this.MenueItemCallPhone.Name = "MenueItemCallPhone";
            this.MenueItemCallPhone.Size = new System.Drawing.Size(224, 32);
            this.MenueItemCallPhone.Text = "Call Phone";
            this.MenueItemCallPhone.Click += new System.EventHandler(this.MenueItemCallPhone_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsUsers2;
            // 
            // dsUsers2
            // 
            this.dsUsers2.DataSetName = "dsUsers2";
            this.dsUsers2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcManagePeople
            // 
            this.pcManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("pcManagePeople.Image")));
            this.pcManagePeople.Location = new System.Drawing.Point(395, 34);
            this.pcManagePeople.Name = "pcManagePeople";
            this.pcManagePeople.Size = new System.Drawing.Size(281, 184);
            this.pcManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcManagePeople.TabIndex = 4;
            this.pcManagePeople.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(926, 738);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1012;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labRecordCount.Location = new System.Drawing.Point(128, 752);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(22, 23);
            this.labRecordCount.TabIndex = 1014;
            this.labRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 752);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1013;
            this.label1.Text = "# Records :";
            // 
            // cbUsersFilter
            // 
            this.cbUsersFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsersFilter.FormattingEnabled = true;
            this.cbUsersFilter.Items.AddRange(new object[] {
            "None",
            "UserID",
            "UserName",
            "PersonID",
            "Full Name",
            "Is Active"});
            this.cbUsersFilter.Location = new System.Drawing.Point(117, 322);
            this.cbUsersFilter.Name = "cbUsersFilter";
            this.cbUsersFilter.Size = new System.Drawing.Size(171, 28);
            this.cbUsersFilter.TabIndex = 1017;
            this.cbUsersFilter.SelectedIndexChanged += new System.EventHandler(this.cbUsersFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1016;
            this.label2.Text = "Filter By:";
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(303, 323);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(171, 26);
            this.tbFilterValue.TabIndex = 1015;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged_1);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.White;
            this.btnAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddNewUser.FlatAppearance.BorderSize = 2;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.Image")));
            this.btnAddNewUser.Location = new System.Drawing.Point(967, 279);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(75, 70);
            this.btnAddNewUser.TabIndex = 1018;
            this.btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(303, 321);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(171, 28);
            this.cbIsActive.TabIndex = 1019;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.FormTitle.Location = new System.Drawing.Point(409, 233);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(252, 48);
            this.FormTitle.TabIndex = 5;
            this.FormTitle.Text = "Manage Users";
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 793);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.cbUsersFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.pcManagePeople);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmUsersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsersManagement";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsMangeUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsers2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcManagePeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.PictureBox pcManagePeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsersFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Button btnAddNewUser;
        private DVLD.dsUsers2 dsUsers2;
        private DVLD.dsUsers2TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsMangeUsers;
        private System.Windows.Forms.ToolStripMenuItem MenueItemShowDetails;
        private System.Windows.Forms.ToolStripMenuItem MenueItemAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem MenueItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenueItemDelete;
        private System.Windows.Forms.ToolStripMenuItem MenueItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem MenueItemSendEmail;
        private System.Windows.Forms.ToolStripMenuItem MenueItemCallPhone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label FormTitle;
    }
}