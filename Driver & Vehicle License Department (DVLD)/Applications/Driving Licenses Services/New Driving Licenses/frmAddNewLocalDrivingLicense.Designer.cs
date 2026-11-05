namespace DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses
{
    partial class frmAddNewLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewLocalDrivingLicense));
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.licenseClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLicenseClasses = new DVLD.dsLicenseClasses();
            this.labCreatedBy = new System.Windows.Forms.Label();
            this.labAppFees = new System.Windows.Forms.Label();
            this.labAppDate = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labLDL_AppID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.ucPersonInfo1 = new DVLD.ucPersonInfo();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.cbPeopleSearcher = new System.Windows.Forms.ComboBox();
            this.labfindBy = new System.Windows.Forms.Label();
            this.labFormTitle = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.tcAddNewDrivingLicense = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.gbSearcher = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.licenseClassesTableAdapter = new DVLD.dsLicenseClassesTableAdapters.LicenseClassesTableAdapter();
            this.notifyInvalidDataType = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLicenseClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcAddNewDrivingLicense.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.gbSearcher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLoginInfo
            // 
            this.tabLoginInfo.Controls.Add(this.cbLicenseClasses);
            this.tabLoginInfo.Controls.Add(this.labCreatedBy);
            this.tabLoginInfo.Controls.Add(this.labAppFees);
            this.tabLoginInfo.Controls.Add(this.labAppDate);
            this.tabLoginInfo.Controls.Add(this.pictureBox5);
            this.tabLoginInfo.Controls.Add(this.label4);
            this.tabLoginInfo.Controls.Add(this.labLDL_AppID);
            this.tabLoginInfo.Controls.Add(this.pictureBox4);
            this.tabLoginInfo.Controls.Add(this.label3);
            this.tabLoginInfo.Controls.Add(this.pictureBox3);
            this.tabLoginInfo.Controls.Add(this.label2);
            this.tabLoginInfo.Controls.Add(this.pictureBox2);
            this.tabLoginInfo.Controls.Add(this.label1);
            this.tabLoginInfo.Controls.Add(this.pictureBox1);
            this.tabLoginInfo.Controls.Add(this.label24);
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(1008, 552);
            this.tabLoginInfo.TabIndex = 1;
            this.tabLoginInfo.Text = "Application Info";
            this.tabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.DataSource = this.licenseClassesBindingSource;
            this.cbLicenseClasses.DisplayMember = "ClassName";
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(347, 198);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(273, 28);
            this.cbLicenseClasses.TabIndex = 1031;
            this.cbLicenseClasses.ValueMember = "LicenseClassID";
            // 
            // licenseClassesBindingSource
            // 
            this.licenseClassesBindingSource.DataMember = "LicenseClasses";
            this.licenseClassesBindingSource.DataSource = this.dsLicenseClasses;
            // 
            // dsLicenseClasses
            // 
            this.dsLicenseClasses.DataSetName = "dsLicenseClasses";
            this.dsLicenseClasses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labCreatedBy
            // 
            this.labCreatedBy.AutoSize = true;
            this.labCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labCreatedBy.Location = new System.Drawing.Point(343, 296);
            this.labCreatedBy.Name = "labCreatedBy";
            this.labCreatedBy.Size = new System.Drawing.Size(29, 20);
            this.labCreatedBy.TabIndex = 1030;
            this.labCreatedBy.Text = "??";
            // 
            // labAppFees
            // 
            this.labAppFees.AutoSize = true;
            this.labAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labAppFees.Location = new System.Drawing.Point(343, 251);
            this.labAppFees.Name = "labAppFees";
            this.labAppFees.Size = new System.Drawing.Size(29, 20);
            this.labAppFees.TabIndex = 1029;
            this.labAppFees.Text = "??";
            // 
            // labAppDate
            // 
            this.labAppDate.AutoSize = true;
            this.labAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labAppDate.Location = new System.Drawing.Point(343, 153);
            this.labAppDate.Name = "labAppDate";
            this.labAppDate.Size = new System.Drawing.Size(96, 20);
            this.labAppDate.TabIndex = 1028;
            this.labAppDate.Text = "TodayDate";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pictureBox5.Location = new System.Drawing.Point(295, 293);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1027;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(97, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 1026;
            this.label4.Text = "Created By:";
            // 
            // labLDL_AppID
            // 
            this.labLDL_AppID.AutoSize = true;
            this.labLDL_AppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labLDL_AppID.Location = new System.Drawing.Point(343, 110);
            this.labLDL_AppID.Name = "labLDL_AppID";
            this.labLDL_AppID.Size = new System.Drawing.Size(39, 20);
            this.labLDL_AppID.TabIndex = 1025;
            this.labLDL_AppID.Text = "???";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(295, 248);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1024;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(97, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 1023;
            this.label3.Text = "Application Fees:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.pictureBox3.Location = new System.Drawing.Point(295, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1021;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(97, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 1020;
            this.label2.Text = "License Class:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(295, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1018;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(97, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 1017;
            this.label1.Text = "Application Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(295, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1015;
            this.pictureBox1.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(97, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(192, 25);
            this.label24.TabIndex = 1012;
            this.label24.Text = "D.L.Application ID:";
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
            // tbSearchValue
            // 
            this.tbSearchValue.Location = new System.Drawing.Point(323, 35);
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(195, 26);
            this.tbSearchValue.TabIndex = 1012;
            this.tbSearchValue.TextChanged += new System.EventHandler(this.tbSearchValue_TextChanged);
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
            // labFormTitle
            // 
            this.labFormTitle.AutoSize = true;
            this.labFormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.labFormTitle.ForeColor = System.Drawing.Color.Red;
            this.labFormTitle.Location = new System.Drawing.Point(202, 17);
            this.labFormTitle.Name = "labFormTitle";
            this.labFormTitle.Size = new System.Drawing.Size(634, 48);
            this.labFormTitle.TabIndex = 1008;
            this.labFormTitle.Text = "New Local Driving License Application";
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
            // tcAddNewDrivingLicense
            // 
            this.tcAddNewDrivingLicense.Controls.Add(this.tabPersonalInfo);
            this.tcAddNewDrivingLicense.Controls.Add(this.tabLoginInfo);
            this.tcAddNewDrivingLicense.Location = new System.Drawing.Point(11, 89);
            this.tcAddNewDrivingLicense.Multiline = true;
            this.tcAddNewDrivingLicense.Name = "tcAddNewDrivingLicense";
            this.tcAddNewDrivingLicense.SelectedIndex = 0;
            this.tcAddNewDrivingLicense.Size = new System.Drawing.Size(1016, 585);
            this.tcAddNewDrivingLicense.TabIndex = 1011;
            this.tcAddNewDrivingLicense.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcAddNewDrivingLicense_Selecting);
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
            this.btnSave.Location = new System.Drawing.Point(896, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 44);
            this.btnSave.TabIndex = 1009;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(748, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 44);
            this.btnClose.TabIndex = 1010;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // licenseClassesTableAdapter
            // 
            this.licenseClassesTableAdapter.ClearBeforeFill = true;
            // 
            // notifyInvalidDataType
            // 
            this.notifyInvalidDataType.Text = "notifyIcon1";
            this.notifyInvalidDataType.Visible = true;
            // 
            // frmAddNewLocalDrivingLicense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1038, 747);
            this.Controls.Add(this.labFormTitle);
            this.Controls.Add(this.tcAddNewDrivingLicense);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAddNewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLocalLicense";
            this.Load += new System.EventHandler(this.frmLocalLicense_Load);
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLicenseClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcAddNewDrivingLicense.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.gbSearcher.ResumeLayout(false);
            this.gbSearcher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labFormTitle;
        private System.Windows.Forms.TabControl tcAddNewDrivingLicense;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.GroupBox gbSearcher;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.ComboBox cbPeopleSearcher;
        private System.Windows.Forms.Label labfindBy;
        private System.Windows.Forms.Button btnNext;
        private ucPersonInfo ucPersonInfo1;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private System.Windows.Forms.Label labLDL_AppID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labAppFees;
        private System.Windows.Forms.Label labAppDate;
        private System.Windows.Forms.Label labCreatedBy;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private dsLicenseClasses dsLicenseClasses;
        private System.Windows.Forms.BindingSource licenseClassesBindingSource;
        private dsLicenseClassesTableAdapters.LicenseClassesTableAdapter licenseClassesTableAdapter;
        private System.Windows.Forms.NotifyIcon notifyInvalidDataType;
    }
}