namespace DVLD.Users
{
    partial class frmAddNewUserr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewUserr));
            this.labFormTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcAddNewUser = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.gbSearcher = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.cbPeopleSearcher = new System.Windows.Forms.ComboBox();
            this.labfindBy = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.ucPersonInfo1 = new DVLD.ucPersonInfo();
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.labUserIDValue = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.epEmptyTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcAddNewUser.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.gbSearcher.SuspendLayout();
            this.tabLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // labFormTitle
            // 
            this.labFormTitle.AutoSize = true;
            this.labFormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.labFormTitle.ForeColor = System.Drawing.Color.Red;
            this.labFormTitle.Location = new System.Drawing.Point(400, 22);
            this.labFormTitle.Name = "labFormTitle";
            this.labFormTitle.Size = new System.Drawing.Size(240, 48);
            this.labFormTitle.TabIndex = 3;
            this.labFormTitle.Text = "Add New User";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(749, 691);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 44);
            this.btnClose.TabIndex = 1006;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(897, 691);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 44);
            this.btnSave.TabIndex = 1005;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcAddNewUser
            // 
            this.tcAddNewUser.Controls.Add(this.tabPersonalInfo);
            this.tcAddNewUser.Controls.Add(this.tabLoginInfo);
            this.tcAddNewUser.Location = new System.Drawing.Point(12, 94);
            this.tcAddNewUser.Multiline = true;
            this.tcAddNewUser.Name = "tcAddNewUser";
            this.tcAddNewUser.SelectedIndex = 0;
            this.tcAddNewUser.Size = new System.Drawing.Size(1016, 585);
            this.tcAddNewUser.TabIndex = 1007;
            this.tcAddNewUser.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcAddNewUser_Selecting);
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.gbSearcher);
            this.tabPersonalInfo.Controls.Add(this.btnNext);
            this.tabPersonalInfo.Controls.Add(this.ucPersonInfo1);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(1008, 552);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Info";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // gbSearcher
            // 
            this.gbSearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearcher.Controls.Add(this.btnSearch);
            this.gbSearcher.Controls.Add(this.btnAddPerson);
            this.gbSearcher.Controls.Add(this.tbSearchValue);
            this.gbSearcher.Controls.Add(this.cbPeopleSearcher);
            this.gbSearcher.Controls.Add(this.labfindBy);
            this.gbSearcher.Location = new System.Drawing.Point(16, 17);
            this.gbSearcher.Name = "gbSearcher";
            this.gbSearcher.Size = new System.Drawing.Size(979, 84);
            this.gbSearcher.TabIndex = 1009;
            this.gbSearcher.TabStop = false;
            this.gbSearcher.Text = "Searcher";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.btnSearch.Location = new System.Drawing.Point(544, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 35);
            this.btnSearch.TabIndex = 1015;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.btnAddPerson.Location = new System.Drawing.Point(602, 31);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(45, 35);
            this.btnAddPerson.TabIndex = 1014;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.Location = new System.Drawing.Point(323, 35);
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(195, 26);
            this.tbSearchValue.TabIndex = 1012;
            // 
            // cbPeopleSearcher
            // 
            this.cbPeopleSearcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeopleSearcher.FormattingEnabled = true;
            this.cbPeopleSearcher.Items.AddRange(new object[] {
            "National No",
            "PersonID"});
            this.cbPeopleSearcher.Location = new System.Drawing.Point(113, 34);
            this.cbPeopleSearcher.Name = "cbPeopleSearcher";
            this.cbPeopleSearcher.Size = new System.Drawing.Size(195, 28);
            this.cbPeopleSearcher.TabIndex = 1011;
            this.cbPeopleSearcher.SelectedIndexChanged += new System.EventHandler(this.cbPeopleSearcher_SelectedIndexChanged);
            // 
            // labfindBy
            // 
            this.labfindBy.AutoSize = true;
            this.labfindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labfindBy.Location = new System.Drawing.Point(15, 34);
            this.labfindBy.Name = "labfindBy";
            this.labfindBy.Size = new System.Drawing.Size(92, 25);
            this.labfindBy.TabIndex = 2;
            this.labfindBy.Text = "Find By:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNext.Image = global::DVLD.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(891, 495);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 40);
            this.btnNext.TabIndex = 1008;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(16, 107);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.NationalNo = null;
            this.ucPersonInfo1.PersonID = 0;
            this.ucPersonInfo1.Size = new System.Drawing.Size(987, 370);
            this.ucPersonInfo1.TabIndex = 3;
            // 
            // tabLoginInfo
            // 
            this.tabLoginInfo.Controls.Add(this.cbIsActive);
            this.tabLoginInfo.Controls.Add(this.labUserIDValue);
            this.tabLoginInfo.Controls.Add(this.pictureBox4);
            this.tabLoginInfo.Controls.Add(this.tbConfirmPassword);
            this.tabLoginInfo.Controls.Add(this.label3);
            this.tabLoginInfo.Controls.Add(this.pictureBox3);
            this.tabLoginInfo.Controls.Add(this.tbPassword);
            this.tabLoginInfo.Controls.Add(this.label2);
            this.tabLoginInfo.Controls.Add(this.pictureBox2);
            this.tabLoginInfo.Controls.Add(this.tbUserName);
            this.tabLoginInfo.Controls.Add(this.label1);
            this.tabLoginInfo.Controls.Add(this.pictureBox1);
            this.tabLoginInfo.Controls.Add(this.label24);
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(1008, 552);
            this.tabLoginInfo.TabIndex = 1;
            this.tabLoginInfo.Text = "Login Info";
            this.tabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(239, 292);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(109, 24);
            this.cbIsActive.TabIndex = 1026;
            this.cbIsActive.Text = "Is Active ";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // labUserIDValue
            // 
            this.labUserIDValue.AutoSize = true;
            this.labUserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labUserIDValue.Location = new System.Drawing.Point(257, 107);
            this.labUserIDValue.Name = "labUserIDValue";
            this.labUserIDValue.Size = new System.Drawing.Size(48, 25);
            this.labUserIDValue.TabIndex = 1025;
            this.labUserIDValue.Text = "???";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.Password_32;
            this.pictureBox4.Location = new System.Drawing.Point(202, 234);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1024;
            this.pictureBox4.TabStop = false;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(239, 234);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(163, 26);
            this.tbConfirmPassword.TabIndex = 1022;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 1023;
            this.label3.Text = "Confirm Password:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(202, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1021;
            this.pictureBox3.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(239, 191);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(163, 26);
            this.tbPassword.TabIndex = 1019;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1020;
            this.label2.Text = "Password:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1018;
            this.pictureBox2.TabStop = false;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(239, 150);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(163, 26);
            this.tbUserName.TabIndex = 1016;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1017;
            this.label1.Text = "UserName:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(202, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1015;
            this.pictureBox1.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(112, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 20);
            this.label24.TabIndex = 1012;
            this.label24.Text = "UserID:";
            // 
            // epEmptyTextBox
            // 
            this.epEmptyTextBox.ContainerControl = this;
            // 
            // epConfirmPassword
            // 
            this.epConfirmPassword.ContainerControl = this;
            // 
            // frmAddNewUserr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1038, 747);
            this.Controls.Add(this.tcAddNewUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labFormTitle);
            this.Name = "frmAddNewUserr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tcAddNewUser.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.gbSearcher.ResumeLayout(false);
            this.gbSearcher.PerformLayout();
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFormTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcAddNewUser;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private DVLD.ucPersonInfo ucPersonInfo1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label labUserIDValue;
        private System.Windows.Forms.GroupBox gbSearcher;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.ComboBox cbPeopleSearcher;
        private System.Windows.Forms.Label labfindBy;
        private System.Windows.Forms.ErrorProvider epEmptyTextBox;
        private System.Windows.Forms.ErrorProvider epConfirmPassword;
    }
}