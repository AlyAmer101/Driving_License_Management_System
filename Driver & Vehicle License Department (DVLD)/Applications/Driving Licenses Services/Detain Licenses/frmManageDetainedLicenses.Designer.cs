namespace DVLD.Applications.Driving_Licenses_Services.Detain_Licenses
{
    partial class frmManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicenses));
            this.btnDetain = new System.Windows.Forms.Button();
            this.cbLicensesFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.FormTitle = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.detainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detainDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReleasedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fineFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseApplicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_DetainedLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicensesHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainedLicensesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetainedLicenses = new DVLD.dsDetainedLicenses();
            this.btnRelease = new System.Windows.Forms.Button();
            this.detainedLicenses_ViewTableAdapter = new DVLD.dsDetainedLicensesTableAdapters.DetainedLicenses_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.cms_DetainedLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detainedLicensesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetainedLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.White;
            this.btnDetain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDetain.FlatAppearance.BorderSize = 2;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDetain.Image = global::DVLD.Properties.Resources.Detain_64;
            this.btnDetain.Location = new System.Drawing.Point(1363, 246);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(75, 70);
            this.btnDetain.TabIndex = 1042;
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // cbLicensesFilter
            // 
            this.cbLicensesFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicensesFilter.FormattingEnabled = true;
            this.cbLicensesFilter.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "License ID",
            "National No",
            "Full Name"});
            this.cbLicensesFilter.Location = new System.Drawing.Point(109, 272);
            this.cbLicensesFilter.Name = "cbLicensesFilter";
            this.cbLicensesFilter.Size = new System.Drawing.Size(171, 28);
            this.cbLicensesFilter.TabIndex = 1041;
            this.cbLicensesFilter.SelectedIndexChanged += new System.EventHandler(this.cbLicensesFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1040;
            this.label2.Text = "Filter By:";
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labRecordCount.Location = new System.Drawing.Point(133, 687);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(22, 23);
            this.labRecordCount.TabIndex = 1039;
            this.labRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1038;
            this.label1.Text = "# Records :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Detain_64;
            this.pictureBox1.Location = new System.Drawing.Point(570, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1035;
            this.pictureBox1.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(1322, 677);
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
            this.FormTitle.Location = new System.Drawing.Point(526, 175);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(319, 48);
            this.FormTitle.TabIndex = 1036;
            this.FormTitle.Text = "Detained Licenses";
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(300, 274);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(159, 26);
            this.tbFilterValue.TabIndex = 1043;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AutoGenerateColumns = false;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detainIDDataGridViewTextBoxColumn,
            this.licenseIDDataGridViewTextBoxColumn,
            this.detainDateDataGridViewTextBoxColumn,
            this.isReleasedDataGridViewCheckBoxColumn,
            this.fineFeesDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.nationalNoDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.releaseApplicationIDDataGridViewTextBoxColumn});
            this.dgvDetainedLicenses.ContextMenuStrip = this.cms_DetainedLicenses;
            this.dgvDetainedLicenses.DataSource = this.detainedLicensesViewBindingSource;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(14, 323);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.RowHeadersWidth = 62;
            this.dgvDetainedLicenses.RowTemplate.Height = 28;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1424, 336);
            this.dgvDetainedLicenses.TabIndex = 1044;
            // 
            // detainIDDataGridViewTextBoxColumn
            // 
            this.detainIDDataGridViewTextBoxColumn.DataPropertyName = "DetainID";
            this.detainIDDataGridViewTextBoxColumn.HeaderText = "D. ID";
            this.detainIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.detainIDDataGridViewTextBoxColumn.Name = "detainIDDataGridViewTextBoxColumn";
            this.detainIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.detainIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // licenseIDDataGridViewTextBoxColumn
            // 
            this.licenseIDDataGridViewTextBoxColumn.DataPropertyName = "LicenseID";
            this.licenseIDDataGridViewTextBoxColumn.HeaderText = "L. ID";
            this.licenseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.licenseIDDataGridViewTextBoxColumn.Name = "licenseIDDataGridViewTextBoxColumn";
            this.licenseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // detainDateDataGridViewTextBoxColumn
            // 
            this.detainDateDataGridViewTextBoxColumn.DataPropertyName = "DetainDate";
            this.detainDateDataGridViewTextBoxColumn.HeaderText = "D. Date";
            this.detainDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.detainDateDataGridViewTextBoxColumn.Name = "detainDateDataGridViewTextBoxColumn";
            this.detainDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.detainDateDataGridViewTextBoxColumn.Width = 180;
            // 
            // isReleasedDataGridViewCheckBoxColumn
            // 
            this.isReleasedDataGridViewCheckBoxColumn.DataPropertyName = "IsReleased";
            this.isReleasedDataGridViewCheckBoxColumn.HeaderText = "Is Released";
            this.isReleasedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isReleasedDataGridViewCheckBoxColumn.Name = "isReleasedDataGridViewCheckBoxColumn";
            this.isReleasedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isReleasedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // fineFeesDataGridViewTextBoxColumn
            // 
            this.fineFeesDataGridViewTextBoxColumn.DataPropertyName = "FineFees";
            this.fineFeesDataGridViewTextBoxColumn.HeaderText = "Fine Fees";
            this.fineFeesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fineFeesDataGridViewTextBoxColumn.Name = "fineFeesDataGridViewTextBoxColumn";
            this.fineFeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.fineFeesDataGridViewTextBoxColumn.Width = 120;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "Release Date";
            this.releaseDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.releaseDateDataGridViewTextBoxColumn.Width = 180;
            // 
            // nationalNoDataGridViewTextBoxColumn
            // 
            this.nationalNoDataGridViewTextBoxColumn.DataPropertyName = "NationalNo";
            this.nationalNoDataGridViewTextBoxColumn.HeaderText = "N. No";
            this.nationalNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nationalNoDataGridViewTextBoxColumn.Name = "nationalNoDataGridViewTextBoxColumn";
            this.nationalNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // releaseApplicationIDDataGridViewTextBoxColumn
            // 
            this.releaseApplicationIDDataGridViewTextBoxColumn.DataPropertyName = "ReleaseApplicationID";
            this.releaseApplicationIDDataGridViewTextBoxColumn.HeaderText = "Release App ID";
            this.releaseApplicationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.releaseApplicationIDDataGridViewTextBoxColumn.Name = "releaseApplicationIDDataGridViewTextBoxColumn";
            this.releaseApplicationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.releaseApplicationIDDataGridViewTextBoxColumn.Width = 160;
            // 
            // cms_DetainedLicenses
            // 
            this.cms_DetainedLicenses.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cms_DetainedLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailesToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicensesHistoryToolStripMenuItem1,
            this.toolStripSeparator1,
            this.releaseDetainedLicToolStripMenuItem});
            this.cms_DetainedLicenses.Name = "cms_DetainedLicenses";
            this.cms_DetainedLicenses.Size = new System.Drawing.Size(326, 138);
            this.cms_DetainedLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.cms_DetainedLicenses_Opening);
            // 
            // showPersonDetailesToolStripMenuItem
            // 
            this.showPersonDetailesToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showPersonDetailesToolStripMenuItem.Name = "showPersonDetailesToolStripMenuItem";
            this.showPersonDetailesToolStripMenuItem.Size = new System.Drawing.Size(325, 32);
            this.showPersonDetailesToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailesToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailesToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(325, 32);
            this.showLicenseToolStripMenuItem.Text = "Show License Details";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicensesHistoryToolStripMenuItem1
            // 
            this.showPersonLicensesHistoryToolStripMenuItem1.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicensesHistoryToolStripMenuItem1.Name = "showPersonLicensesHistoryToolStripMenuItem1";
            this.showPersonLicensesHistoryToolStripMenuItem1.Size = new System.Drawing.Size(325, 32);
            this.showPersonLicensesHistoryToolStripMenuItem1.Text = "Show Person Licenses History";
            this.showPersonLicensesHistoryToolStripMenuItem1.Click += new System.EventHandler(this.showPersonLicensesHistoryToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(322, 6);
            // 
            // releaseDetainedLicToolStripMenuItem
            // 
            this.releaseDetainedLicToolStripMenuItem.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicToolStripMenuItem.Name = "releaseDetainedLicToolStripMenuItem";
            this.releaseDetainedLicToolStripMenuItem.Size = new System.Drawing.Size(325, 32);
            this.releaseDetainedLicToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicToolStripMenuItem_Click);
            // 
            // detainedLicensesViewBindingSource
            // 
            this.detainedLicensesViewBindingSource.DataMember = "DetainedLicenses_View";
            this.detainedLicensesViewBindingSource.DataSource = this.dsDetainedLicenses;
            // 
            // dsDetainedLicenses
            // 
            this.dsDetainedLicenses.DataSetName = "dsDetainedLicenses";
            this.dsDetainedLicenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.White;
            this.btnRelease.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRelease.FlatAppearance.BorderSize = 2;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRelease.Image = global::DVLD.Properties.Resources.Release_Detained_License_64;
            this.btnRelease.Location = new System.Drawing.Point(1264, 246);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(75, 70);
            this.btnRelease.TabIndex = 1045;
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // detainedLicenses_ViewTableAdapter
            // 
            this.detainedLicenses_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 726);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.cbLicensesFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.tbFilterValue);
            this.Name = "frmManageDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageDetainedLicenses";
            this.Load += new System.EventHandler(this.frmManageDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.cms_DetainedLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detainedLicensesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetainedLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.ComboBox cbLicensesFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Button btnRelease;
        private dsDetainedLicenses dsDetainedLicenses;
        private System.Windows.Forms.BindingSource detainedLicensesViewBindingSource;
        private dsDetainedLicensesTableAdapters.DetainedLicenses_ViewTableAdapter detainedLicenses_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn detainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detainDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReleasedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineFeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseApplicationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cms_DetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}