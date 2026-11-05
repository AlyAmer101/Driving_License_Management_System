namespace DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_Person_License_History
{
    partial class frmShowPersonLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonLicenseHistory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormTitle = new System.Windows.Forms.Label();
            this.labShowPersonInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcAddNewDrivingLicense = new System.Windows.Forms.TabControl();
            this.tabLocalLicense = new System.Windows.Forms.TabPage();
            this.labLocalLicesnesCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.licenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.applicantPersonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsLicenseInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalLicenses = new DVLD.dsLocalLicenses();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInternationalLicense = new System.Windows.Forms.TabPage();
            this.labInternationalLicesnesCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInternationalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.internationalLicenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.applicantPersonIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internationalLicensesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInternationalLicenses_View = new DVLD.dsInternationalLicenses_View();
            this.label5 = new System.Windows.Forms.Label();
            this.licenses_ViewTableAdapter = new DVLD.dsLocalLicensesTableAdapters.Licenses_ViewTableAdapter();
            this.internationalLicenses_ViewTableAdapter = new DVLD.dsInternationalLicenses_ViewTableAdapters.InternationalLicenses_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tcAddNewDrivingLicense.SuspendLayout();
            this.tabLocalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIocalLicensesHistory)).BeginInit();
            this.cmsLicenseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licensesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalLicenses)).BeginInit();
            this.tabInternationalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationalLicensesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInternationalLicenses_View)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(534, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1027;
            this.pictureBox1.TabStop = false;
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.FormTitle.Location = new System.Drawing.Point(539, 199);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(270, 48);
            this.FormTitle.TabIndex = 1028;
            this.FormTitle.Text = "License History";
            // 
            // labShowPersonInfo
            // 
            this.labShowPersonInfo.AutoSize = true;
            this.labShowPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labShowPersonInfo.Location = new System.Drawing.Point(16, 693);
            this.labShowPersonInfo.Name = "labShowPersonInfo";
            this.labShowPersonInfo.Size = new System.Drawing.Size(166, 25);
            this.labShowPersonInfo.TabIndex = 1029;
            this.labShowPersonInfo.TabStop = true;
            this.labShowPersonInfo.Text = "Show Person Info";
            this.labShowPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1183, 687);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1030;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.tcAddNewDrivingLicense);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1287, 388);
            this.groupBox1.TabIndex = 1032;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tcAddNewDrivingLicense
            // 
            this.tcAddNewDrivingLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcAddNewDrivingLicense.Controls.Add(this.tabLocalLicense);
            this.tcAddNewDrivingLicense.Controls.Add(this.tabInternationalLicense);
            this.tcAddNewDrivingLicense.Location = new System.Drawing.Point(17, 46);
            this.tcAddNewDrivingLicense.Multiline = true;
            this.tcAddNewDrivingLicense.Name = "tcAddNewDrivingLicense";
            this.tcAddNewDrivingLicense.SelectedIndex = 0;
            this.tcAddNewDrivingLicense.Size = new System.Drawing.Size(1264, 335);
            this.tcAddNewDrivingLicense.TabIndex = 1033;
            // 
            // tabLocalLicense
            // 
            this.tabLocalLicense.Controls.Add(this.labLocalLicesnesCount);
            this.tabLocalLicense.Controls.Add(this.label2);
            this.tabLocalLicense.Controls.Add(this.dgvIocalLicensesHistory);
            this.tabLocalLicense.Controls.Add(this.label1);
            this.tabLocalLicense.Location = new System.Drawing.Point(4, 29);
            this.tabLocalLicense.Name = "tabLocalLicense";
            this.tabLocalLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocalLicense.Size = new System.Drawing.Size(1256, 302);
            this.tabLocalLicense.TabIndex = 0;
            this.tabLocalLicense.Text = "Local";
            this.tabLocalLicense.UseVisualStyleBackColor = true;
            // 
            // labLocalLicesnesCount
            // 
            this.labLocalLicesnesCount.AutoSize = true;
            this.labLocalLicesnesCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLocalLicesnesCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labLocalLicesnesCount.Location = new System.Drawing.Point(127, 258);
            this.labLocalLicesnesCount.Name = "labLocalLicesnesCount";
            this.labLocalLicesnesCount.Size = new System.Drawing.Size(22, 23);
            this.labLocalLicesnesCount.TabIndex = 1035;
            this.labLocalLicesnesCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1034;
            this.label2.Text = "# Records :";
            // 
            // dgvIocalLicensesHistory
            // 
            this.dgvIocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvIocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvIocalLicensesHistory.AutoGenerateColumns = false;
            this.dgvIocalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvIocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIocalLicensesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licenseIDDataGridViewTextBoxColumn,
            this.applicationIDDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.applicantPersonIDDataGridViewTextBoxColumn});
            this.dgvIocalLicensesHistory.ContextMenuStrip = this.cmsLicenseInfo;
            this.dgvIocalLicensesHistory.DataSource = this.licensesViewBindingSource;
            this.dgvIocalLicensesHistory.Location = new System.Drawing.Point(16, 46);
            this.dgvIocalLicensesHistory.Name = "dgvIocalLicensesHistory";
            this.dgvIocalLicensesHistory.ReadOnly = true;
            this.dgvIocalLicensesHistory.RowHeadersWidth = 62;
            this.dgvIocalLicensesHistory.RowTemplate.Height = 28;
            this.dgvIocalLicensesHistory.Size = new System.Drawing.Size(1221, 209);
            this.dgvIocalLicensesHistory.TabIndex = 1033;
            // 
            // licenseIDDataGridViewTextBoxColumn
            // 
            this.licenseIDDataGridViewTextBoxColumn.DataPropertyName = "LicenseID";
            this.licenseIDDataGridViewTextBoxColumn.HeaderText = "LicenseID";
            this.licenseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.licenseIDDataGridViewTextBoxColumn.Name = "licenseIDDataGridViewTextBoxColumn";
            this.licenseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // applicationIDDataGridViewTextBoxColumn
            // 
            this.applicationIDDataGridViewTextBoxColumn.DataPropertyName = "ApplicationID";
            this.applicationIDDataGridViewTextBoxColumn.HeaderText = "ApplicationID";
            this.applicationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicationIDDataGridViewTextBoxColumn.Name = "applicationIDDataGridViewTextBoxColumn";
            this.applicationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.classNameDataGridViewTextBoxColumn.Width = 260;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.issueDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expirationDateDataGridViewTextBoxColumn.Width = 200;
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
            // applicantPersonIDDataGridViewTextBoxColumn
            // 
            this.applicantPersonIDDataGridViewTextBoxColumn.DataPropertyName = "ApplicantPersonID";
            this.applicantPersonIDDataGridViewTextBoxColumn.HeaderText = "ApplicantPersonID";
            this.applicantPersonIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicantPersonIDDataGridViewTextBoxColumn.Name = "applicantPersonIDDataGridViewTextBoxColumn";
            this.applicantPersonIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicantPersonIDDataGridViewTextBoxColumn.Visible = false;
            this.applicantPersonIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cmsLicenseInfo
            // 
            this.cmsLicenseInfo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsLicenseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.cmsLicenseInfo.Name = "cmsLicenseInfo";
            this.cmsLicenseInfo.Size = new System.Drawing.Size(235, 36);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // licensesViewBindingSource
            // 
            this.licensesViewBindingSource.DataMember = "Licenses_View";
            this.licensesViewBindingSource.DataSource = this.dsLocalLicenses;
            // 
            // dsLocalLicenses
            // 
            this.dsLocalLicenses.DataSetName = "dsLocalLicenses";
            this.dsLocalLicenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 1032;
            this.label1.Text = "Local Licenses History:";
            // 
            // tabInternationalLicense
            // 
            this.tabInternationalLicense.Controls.Add(this.labInternationalLicesnesCount);
            this.tabInternationalLicense.Controls.Add(this.label4);
            this.tabInternationalLicense.Controls.Add(this.dgvInternationalLicensesHistory);
            this.tabInternationalLicense.Controls.Add(this.label5);
            this.tabInternationalLicense.Location = new System.Drawing.Point(4, 29);
            this.tabInternationalLicense.Name = "tabInternationalLicense";
            this.tabInternationalLicense.Size = new System.Drawing.Size(1256, 302);
            this.tabInternationalLicense.TabIndex = 1;
            this.tabInternationalLicense.Text = "International License";
            this.tabInternationalLicense.UseVisualStyleBackColor = true;
            // 
            // labInternationalLicesnesCount
            // 
            this.labInternationalLicesnesCount.AutoSize = true;
            this.labInternationalLicesnesCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInternationalLicesnesCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labInternationalLicesnesCount.Location = new System.Drawing.Point(131, 257);
            this.labInternationalLicesnesCount.Name = "labInternationalLicesnesCount";
            this.labInternationalLicesnesCount.Size = new System.Drawing.Size(22, 23);
            this.labInternationalLicesnesCount.TabIndex = 1039;
            this.labInternationalLicesnesCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 1038;
            this.label4.Text = "# Records :";
            // 
            // dgvInternationalLicensesHistory
            // 
            this.dgvInternationalLicensesHistory.AllowUserToAddRows = false;
            this.dgvInternationalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvInternationalLicensesHistory.AutoGenerateColumns = false;
            this.dgvInternationalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicensesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.internationalLicenseIDDataGridViewTextBoxColumn,
            this.applicationIDDataGridViewTextBoxColumn1,
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn1,
            this.expirationDateDataGridViewTextBoxColumn1,
            this.isActiveDataGridViewCheckBoxColumn1,
            this.applicantPersonIDDataGridViewTextBoxColumn1});
            this.dgvInternationalLicensesHistory.ContextMenuStrip = this.cmsLicenseInfo;
            this.dgvInternationalLicensesHistory.DataSource = this.internationalLicensesViewBindingSource;
            this.dgvInternationalLicensesHistory.Location = new System.Drawing.Point(20, 45);
            this.dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            this.dgvInternationalLicensesHistory.ReadOnly = true;
            this.dgvInternationalLicensesHistory.RowHeadersWidth = 62;
            this.dgvInternationalLicensesHistory.RowTemplate.Height = 28;
            this.dgvInternationalLicensesHistory.Size = new System.Drawing.Size(1221, 209);
            this.dgvInternationalLicensesHistory.TabIndex = 1037;
            // 
            // internationalLicenseIDDataGridViewTextBoxColumn
            // 
            this.internationalLicenseIDDataGridViewTextBoxColumn.DataPropertyName = "InternationalLicenseID";
            this.internationalLicenseIDDataGridViewTextBoxColumn.HeaderText = "Inter. License ID";
            this.internationalLicenseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.internationalLicenseIDDataGridViewTextBoxColumn.Name = "internationalLicenseIDDataGridViewTextBoxColumn";
            this.internationalLicenseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.internationalLicenseIDDataGridViewTextBoxColumn.Width = 170;
            // 
            // applicationIDDataGridViewTextBoxColumn1
            // 
            this.applicationIDDataGridViewTextBoxColumn1.DataPropertyName = "ApplicationID";
            this.applicationIDDataGridViewTextBoxColumn1.HeaderText = "Application ID";
            this.applicationIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.applicationIDDataGridViewTextBoxColumn1.Name = "applicationIDDataGridViewTextBoxColumn1";
            this.applicationIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.applicationIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // issuedUsingLocalLicenseIDDataGridViewTextBoxColumn
            // 
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.DataPropertyName = "IssuedUsingLocalLicenseID";
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.HeaderText = "L. License ID";
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.Name = "issuedUsingLocalLicenseIDDataGridViewTextBoxColumn";
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // issueDateDataGridViewTextBoxColumn1
            // 
            this.issueDateDataGridViewTextBoxColumn1.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn1.HeaderText = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.issueDateDataGridViewTextBoxColumn1.Name = "issueDateDataGridViewTextBoxColumn1";
            this.issueDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.issueDateDataGridViewTextBoxColumn1.Width = 230;
            // 
            // expirationDateDataGridViewTextBoxColumn1
            // 
            this.expirationDateDataGridViewTextBoxColumn1.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn1.HeaderText = "Expiration Date";
            this.expirationDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.expirationDateDataGridViewTextBoxColumn1.Name = "expirationDateDataGridViewTextBoxColumn1";
            this.expirationDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.expirationDateDataGridViewTextBoxColumn1.Width = 230;
            // 
            // isActiveDataGridViewCheckBoxColumn1
            // 
            this.isActiveDataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn1.HeaderText = "Is Active";
            this.isActiveDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.isActiveDataGridViewCheckBoxColumn1.Name = "isActiveDataGridViewCheckBoxColumn1";
            this.isActiveDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // applicantPersonIDDataGridViewTextBoxColumn1
            // 
            this.applicantPersonIDDataGridViewTextBoxColumn1.DataPropertyName = "ApplicantPersonID";
            this.applicantPersonIDDataGridViewTextBoxColumn1.HeaderText = "ApplicantPersonID";
            this.applicantPersonIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.applicantPersonIDDataGridViewTextBoxColumn1.Name = "applicantPersonIDDataGridViewTextBoxColumn1";
            this.applicantPersonIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.applicantPersonIDDataGridViewTextBoxColumn1.Visible = false;
            this.applicantPersonIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // internationalLicensesViewBindingSource
            // 
            this.internationalLicensesViewBindingSource.DataMember = "InternationalLicenses_View";
            this.internationalLicensesViewBindingSource.DataSource = this.dsInternationalLicenses_View;
            // 
            // dsInternationalLicenses_View
            // 
            this.dsInternationalLicenses_View.DataSetName = "dsInternationalLicenses_View";
            this.dsInternationalLicenses_View.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 22);
            this.label5.TabIndex = 1036;
            this.label5.Text = "International Licenses History:";
            // 
            // licenses_ViewTableAdapter
            // 
            this.licenses_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // internationalLicenses_ViewTableAdapter
            // 
            this.internationalLicenses_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 736);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labShowPersonInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FormTitle);
            this.Name = "frmShowPersonLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowPersonLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tcAddNewDrivingLicense.ResumeLayout(false);
            this.tabLocalLicense.ResumeLayout(false);
            this.tabLocalLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIocalLicensesHistory)).EndInit();
            this.cmsLicenseInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.licensesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalLicenses)).EndInit();
            this.tabInternationalLicense.ResumeLayout(false);
            this.tabInternationalLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationalLicensesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInternationalLicenses_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.LinkLabel labShowPersonInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private dsLocalLicenses dsLocalLicenses;
        private System.Windows.Forms.BindingSource licensesViewBindingSource;
        private dsLocalLicensesTableAdapters.Licenses_ViewTableAdapter licenses_ViewTableAdapter;
        private dsInternationalLicenses_View dsInternationalLicenses_View;
        private System.Windows.Forms.BindingSource internationalLicensesViewBindingSource;
        private dsInternationalLicenses_ViewTableAdapters.InternationalLicenses_ViewTableAdapter internationalLicenses_ViewTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.TabControl tcAddNewDrivingLicense;
        private System.Windows.Forms.TabPage tabLocalLicense;
        private System.Windows.Forms.Label labLocalLicesnesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIocalLicensesHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantPersonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabInternationalLicense;
        private System.Windows.Forms.Label labInternationalLicesnesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInternationalLicensesHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn internationalLicenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedUsingLocalLicenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantPersonIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label5;
    }
}