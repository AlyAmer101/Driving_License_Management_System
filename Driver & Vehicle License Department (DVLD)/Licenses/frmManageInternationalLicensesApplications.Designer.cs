namespace DVLD.Applications.Manage_Applications.International_Licenses_Applications
{
    partial class frmManageInternationalLicensesApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInternationalLicensesApplications));
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.btnAddNewInterLicense = new System.Windows.Forms.Button();
            this.cbInterAppsFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.FormTitle = new System.Windows.Forms.Label();
            this.dgvInterLicenses = new System.Windows.Forms.DataGridView();
            this.internationalLicenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsInternationalLicenseApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInternational_Licenses = new DVLD.DsInternational_Licenses();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.internationalLicensesTableAdapter = new DVLD.DsInternational_LicensesTableAdapters.InternationalLicensesTableAdapter();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterLicenses)).BeginInit();
            this.cmsInternationalLicenseApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internationalLicensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInternational_Licenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(300, 333);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(159, 26);
            this.tbFilterValue.TabIndex = 1043;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            // 
            // btnAddNewInterLicense
            // 
            this.btnAddNewInterLicense.BackColor = System.Drawing.Color.White;
            this.btnAddNewInterLicense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddNewInterLicense.FlatAppearance.BorderSize = 2;
            this.btnAddNewInterLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewInterLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddNewInterLicense.Image = global::DVLD.Properties.Resources.New_Application_64;
            this.btnAddNewInterLicense.Location = new System.Drawing.Point(1175, 290);
            this.btnAddNewInterLicense.Name = "btnAddNewInterLicense";
            this.btnAddNewInterLicense.Size = new System.Drawing.Size(75, 70);
            this.btnAddNewInterLicense.TabIndex = 1042;
            this.btnAddNewInterLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewInterLicense.UseVisualStyleBackColor = false;
            this.btnAddNewInterLicense.Click += new System.EventHandler(this.btnAddNewInterLicense_Click);
            // 
            // cbInterAppsFilter
            // 
            this.cbInterAppsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterAppsFilter.FormattingEnabled = true;
            this.cbInterAppsFilter.Items.AddRange(new object[] {
            "None",
            "Int. License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cbInterAppsFilter.Location = new System.Drawing.Point(109, 332);
            this.cbInterAppsFilter.Name = "cbInterAppsFilter";
            this.cbInterAppsFilter.Size = new System.Drawing.Size(171, 28);
            this.cbInterAppsFilter.TabIndex = 1041;
            this.cbInterAppsFilter.SelectedIndexChanged += new System.EventHandler(this.cbInterAppsFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1040;
            this.label2.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(492, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1035;
            this.pictureBox1.TabStop = false;
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labRecordCount.Location = new System.Drawing.Point(133, 760);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(22, 23);
            this.labRecordCount.TabIndex = 1039;
            this.labRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 760);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1038;
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
            this.btnClose.Location = new System.Drawing.Point(1135, 746);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1037;
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
            this.FormTitle.Location = new System.Drawing.Point(341, 231);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(582, 48);
            this.FormTitle.TabIndex = 1036;
            this.FormTitle.Text = "International License Applications";
            // 
            // dgvInterLicenses
            // 
            this.dgvInterLicenses.AllowUserToAddRows = false;
            this.dgvInterLicenses.AllowUserToDeleteRows = false;
            this.dgvInterLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInterLicenses.AutoGenerateColumns = false;
            this.dgvInterLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInterLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.internationalLicenseIDDataGridViewTextBoxColumn,
            this.applicationIDDataGridViewTextBoxColumn,
            this.driverIDDataGridViewTextBoxColumn,
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dgvInterLicenses.ContextMenuStrip = this.cmsInternationalLicenseApplications;
            this.dgvInterLicenses.DataSource = this.internationalLicensesBindingSource;
            this.dgvInterLicenses.Location = new System.Drawing.Point(14, 383);
            this.dgvInterLicenses.Name = "dgvInterLicenses";
            this.dgvInterLicenses.ReadOnly = true;
            this.dgvInterLicenses.RowHeadersWidth = 62;
            this.dgvInterLicenses.RowTemplate.Height = 28;
            this.dgvInterLicenses.Size = new System.Drawing.Size(1236, 336);
            this.dgvInterLicenses.TabIndex = 1044;
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
            // applicationIDDataGridViewTextBoxColumn
            // 
            this.applicationIDDataGridViewTextBoxColumn.DataPropertyName = "ApplicationID";
            this.applicationIDDataGridViewTextBoxColumn.HeaderText = "Application ID";
            this.applicationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicationIDDataGridViewTextBoxColumn.Name = "applicationIDDataGridViewTextBoxColumn";
            this.applicationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            this.driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            this.driverIDDataGridViewTextBoxColumn.HeaderText = "Driver ID";
            this.driverIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            this.driverIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // issuedUsingLocalLicenseIDDataGridViewTextBoxColumn
            // 
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.DataPropertyName = "IssuedUsingLocalLicenseID";
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.HeaderText = "Local. License ID";
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.Name = "issuedUsingLocalLicenseIDDataGridViewTextBoxColumn";
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.issuedUsingLocalLicenseIDDataGridViewTextBoxColumn.Width = 170;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.issueDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "Expiration Date";
            this.expirationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expirationDateDataGridViewTextBoxColumn.Width = 170;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Is Active";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 150;
            // 
            // cmsInternationalLicenseApplications
            // 
            this.cmsInternationalLicenseApplications.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsInternationalLicenseApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsInternationalLicenseApplications.Name = "cmsInternationalLicenseApplications";
            this.cmsInternationalLicenseApplications.Size = new System.Drawing.Size(318, 100);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // internationalLicensesBindingSource
            // 
            this.internationalLicensesBindingSource.DataMember = "InternationalLicenses";
            this.internationalLicensesBindingSource.DataSource = this.dsInternational_Licenses;
            // 
            // dsInternational_Licenses
            // 
            this.dsInternational_Licenses.DataSetName = "DsInternational_Licenses";
            this.dsInternational_Licenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.International_32;
            this.pictureBox2.Location = new System.Drawing.Point(721, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1045;
            this.pictureBox2.TabStop = false;
            // 
            // internationalLicensesTableAdapter
            // 
            this.internationalLicensesTableAdapter.ClearBeforeFill = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cbIsActive.Location = new System.Drawing.Point(300, 332);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(159, 28);
            this.cbIsActive.TabIndex = 1046;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // frmManageInternationalLicensesApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 803);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvInterLicenses);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.btnAddNewInterLicense);
            this.Controls.Add(this.cbInterAppsFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.cbIsActive);
            this.Name = "frmManageInternationalLicensesApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageInternationalLicensesApplications";
            this.Load += new System.EventHandler(this.frmManageInternationalLicensesApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterLicenses)).EndInit();
            this.cmsInternationalLicenseApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.internationalLicensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInternational_Licenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Button btnAddNewInterLicense;
        private System.Windows.Forms.ComboBox cbInterAppsFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.DataGridView dgvInterLicenses;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DsInternational_Licenses dsInternational_Licenses;
        private System.Windows.Forms.BindingSource internationalLicensesBindingSource;
        private DsInternational_LicensesTableAdapters.InternationalLicensesTableAdapter internationalLicensesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn internationalLicenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedUsingLocalLicenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}