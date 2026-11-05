namespace DVLD.Applications.Manage_Driving_Licenses_Applications
{
    partial class frmManageLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDrivingLicenseApplications));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLDLApps = new System.Windows.Forms.DataGridView();
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passedTestCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsLDL_Apps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmcItem_VisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmcItem_WrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmcItem_StreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.issuDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalDrivingLicenseApplications = new DVLD.dsLocalDrivingLicenseApplications();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.FormTitle = new System.Windows.Forms.Label();
            this.btnAddNewLDLApp = new System.Windows.Forms.Button();
            this.cbLDLAppFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.localDrivingLicenseApplications_ViewTableAdapter = new DVLD.dsLocalDrivingLicenseApplicationsTableAdapters.LocalDrivingLicenseApplications_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApps)).BeginInit();
            this.cmsLDL_Apps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localDrivingLicenseApplicationsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalDrivingLicenseApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(496, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1025;
            this.pictureBox1.TabStop = false;
            // 
            // dgvLDLApps
            // 
            this.dgvLDLApps.AllowUserToAddRows = false;
            this.dgvLDLApps.AllowUserToDeleteRows = false;
            this.dgvLDLApps.AutoGenerateColumns = false;
            this.dgvLDLApps.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.nationalNoDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.applicationDateDataGridViewTextBoxColumn,
            this.passedTestCountDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvLDLApps.ContextMenuStrip = this.cmsLDL_Apps;
            this.dgvLDLApps.DataSource = this.localDrivingLicenseApplicationsViewBindingSource;
            this.dgvLDLApps.GridColor = System.Drawing.Color.Black;
            this.dgvLDLApps.Location = new System.Drawing.Point(13, 433);
            this.dgvLDLApps.Name = "dgvLDLApps";
            this.dgvLDLApps.ReadOnly = true;
            this.dgvLDLApps.RowHeadersWidth = 62;
            this.dgvLDLApps.Size = new System.Drawing.Size(1345, 336);
            this.dgvLDLApps.TabIndex = 1024;
            this.dgvLDLApps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLDLApps_CellContentClick);
            // 
            // localDrivingLicenseApplicationIDDataGridViewTextBoxColumn
            // 
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.DataPropertyName = "LocalDrivingLicenseApplicationID";
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.HeaderText = "LocalDrivingLicenseApplicationID";
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.Name = "localDrivingLicenseApplicationIDDataGridViewTextBoxColumn";
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.classNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nationalNoDataGridViewTextBoxColumn
            // 
            this.nationalNoDataGridViewTextBoxColumn.DataPropertyName = "NationalNo";
            this.nationalNoDataGridViewTextBoxColumn.HeaderText = "NationalNo";
            this.nationalNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nationalNoDataGridViewTextBoxColumn.Name = "nationalNoDataGridViewTextBoxColumn";
            this.nationalNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // applicationDateDataGridViewTextBoxColumn
            // 
            this.applicationDateDataGridViewTextBoxColumn.DataPropertyName = "ApplicationDate";
            this.applicationDateDataGridViewTextBoxColumn.HeaderText = "ApplicationDate";
            this.applicationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicationDateDataGridViewTextBoxColumn.Name = "applicationDateDataGridViewTextBoxColumn";
            this.applicationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // passedTestCountDataGridViewTextBoxColumn
            // 
            this.passedTestCountDataGridViewTextBoxColumn.DataPropertyName = "PassedTestCount";
            this.passedTestCountDataGridViewTextBoxColumn.HeaderText = "PassedTestCount";
            this.passedTestCountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passedTestCountDataGridViewTextBoxColumn.Name = "passedTestCountDataGridViewTextBoxColumn";
            this.passedTestCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.passedTestCountDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // cmsLDL_Apps
            // 
            this.cmsLDL_Apps.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsLDL_Apps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.scheduleTestsToolStripMenuItem,
            this.toolStripSeparator4,
            this.issuDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator5,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsLDL_Apps.Name = "cmsLDL_Apps";
            this.cmsLDL_Apps.Size = new System.Drawing.Size(338, 296);
            this.cmsLDL_Apps.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLDL_Apps_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(334, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(334, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(334, 6);
            // 
            // scheduleTestsToolStripMenuItem
            // 
            this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmcItem_VisionTest,
            this.cmcItem_WrittenTest,
            this.cmcItem_StreetTest});
            this.scheduleTestsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Schedule_Test_32;
            this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
            this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.scheduleTestsToolStripMenuItem.Text = "Schedule Tests ";
            this.scheduleTestsToolStripMenuItem.Click += new System.EventHandler(this.scheduleTestsToolStripMenuItem_Click);
            // 
            // cmcItem_VisionTest
            // 
            this.cmcItem_VisionTest.Enabled = false;
            this.cmcItem_VisionTest.Image = global::DVLD.Properties.Resources.Vision_Test_Schdule;
            this.cmcItem_VisionTest.Name = "cmcItem_VisionTest";
            this.cmcItem_VisionTest.Size = new System.Drawing.Size(283, 34);
            this.cmcItem_VisionTest.Text = "Schedule Vision Test";
            this.cmcItem_VisionTest.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // cmcItem_WrittenTest
            // 
            this.cmcItem_WrittenTest.Enabled = false;
            this.cmcItem_WrittenTest.Image = global::DVLD.Properties.Resources.Written_Test_32_Sechdule;
            this.cmcItem_WrittenTest.Name = "cmcItem_WrittenTest";
            this.cmcItem_WrittenTest.Size = new System.Drawing.Size(283, 34);
            this.cmcItem_WrittenTest.Text = "Schedule Written Test";
            this.cmcItem_WrittenTest.Click += new System.EventHandler(this.cmcItem_WrittenTest_Click);
            // 
            // cmcItem_StreetTest
            // 
            this.cmcItem_StreetTest.Enabled = false;
            this.cmcItem_StreetTest.Image = global::DVLD.Properties.Resources.Street_Test_32;
            this.cmcItem_StreetTest.Name = "cmcItem_StreetTest";
            this.cmcItem_StreetTest.Size = new System.Drawing.Size(283, 34);
            this.cmcItem_StreetTest.Text = "Schedule Street Test";
            this.cmcItem_StreetTest.Click += new System.EventHandler(this.cmcItem_StreetTest_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(334, 6);
            // 
            // issuDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issuDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            this.issuDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.issuDrivingLicenseFirstTimeToolStripMenuItem.Name = "issuDrivingLicenseFirstTimeToolStripMenuItem";
            this.issuDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.issuDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issu Driving License (First Time)";
            this.issuDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issuDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(334, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(334, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // localDrivingLicenseApplicationsViewBindingSource
            // 
            this.localDrivingLicenseApplicationsViewBindingSource.DataMember = "LocalDrivingLicenseApplications_View";
            this.localDrivingLicenseApplicationsViewBindingSource.DataSource = this.dsLocalDrivingLicenseApplications;
            // 
            // dsLocalDrivingLicenseApplications
            // 
            this.dsLocalDrivingLicenseApplications.DataSetName = "dsLocalDrivingLicenseApplications";
            this.dsLocalDrivingLicenseApplications.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labRecordCount.Location = new System.Drawing.Point(132, 810);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(22, 23);
            this.labRecordCount.TabIndex = 1029;
            this.labRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 810);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1028;
            this.label1.Text = "# Records :";
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
            this.btnClose.Location = new System.Drawing.Point(1242, 801);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1027;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.FormTitle.Location = new System.Drawing.Point(348, 238);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(577, 48);
            this.FormTitle.TabIndex = 1026;
            this.FormTitle.Text = "Local Driving License Applications";
            // 
            // btnAddNewLDLApp
            // 
            this.btnAddNewLDLApp.BackColor = System.Drawing.Color.White;
            this.btnAddNewLDLApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddNewLDLApp.FlatAppearance.BorderSize = 2;
            this.btnAddNewLDLApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLDLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddNewLDLApp.Image = global::DVLD.Properties.Resources.New_Application_64;
            this.btnAddNewLDLApp.Location = new System.Drawing.Point(1283, 339);
            this.btnAddNewLDLApp.Name = "btnAddNewLDLApp";
            this.btnAddNewLDLApp.Size = new System.Drawing.Size(75, 70);
            this.btnAddNewLDLApp.TabIndex = 1032;
            this.btnAddNewLDLApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewLDLApp.UseVisualStyleBackColor = false;
            this.btnAddNewLDLApp.Click += new System.EventHandler(this.btnAddNewLDLApp_Click);
            // 
            // cbLDLAppFilter
            // 
            this.cbLDLAppFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLDLAppFilter.FormattingEnabled = true;
            this.cbLDLAppFilter.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "National No",
            "Full Name",
            "Status"});
            this.cbLDLAppFilter.Location = new System.Drawing.Point(108, 382);
            this.cbLDLAppFilter.Name = "cbLDLAppFilter";
            this.cbLDLAppFilter.Size = new System.Drawing.Size(171, 28);
            this.cbLDLAppFilter.TabIndex = 1031;
            this.cbLDLAppFilter.SelectedIndexChanged += new System.EventHandler(this.cbLDLAppFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1030;
            this.label2.Text = "Filter By:";
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(299, 384);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(159, 26);
            this.tbFilterValue.TabIndex = 1033;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbSearcherValue_TextChanged);
            // 
            // localDrivingLicenseApplications_ViewTableAdapter
            // 
            this.localDrivingLicenseApplications_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 848);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.btnAddNewLDLApp);
            this.Controls.Add(this.cbLDLAppFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLDLApps);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FormTitle);
            this.Name = "frmManageLocalDrivingLicenseApplications";
            this.Text = "Manage Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmManageLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApps)).EndInit();
            this.cmsLDL_Apps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.localDrivingLicenseApplicationsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalDrivingLicenseApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLDLApps;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Button btnAddNewLDLApp;
        private System.Windows.Forms.ComboBox cbLDLAppFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterValue;
        private dsLocalDrivingLicenseApplications dsLocalDrivingLicenseApplications;
        private System.Windows.Forms.BindingSource localDrivingLicenseApplicationsViewBindingSource;
        private dsLocalDrivingLicenseApplicationsTableAdapters.LocalDrivingLicenseApplications_ViewTableAdapter localDrivingLicenseApplications_ViewTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmsLDL_Apps;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmcItem_VisionTest;
        private System.Windows.Forms.ToolStripMenuItem cmcItem_WrittenTest;
        private System.Windows.Forms.ToolStripMenuItem cmcItem_StreetTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem issuDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDrivingLicenseApplicationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passedTestCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
    }
}