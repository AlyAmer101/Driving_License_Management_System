namespace DVLD.Drivers
{
    partial class frmDriverManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDriverManagement));
            this.btnClose = new System.Windows.Forms.Button();
            this.cbDriversFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FormTitle = new System.Windows.Forms.Label();
            this.pcManagePeople = new System.Windows.Forms.PictureBox();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.driverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfActiveLicensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driversViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDrivers = new DVLD.DsDrivers();
            this.drivers_ViewTableAdapter = new DVLD.DsDriversTableAdapters.Drivers_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pcManagePeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1106, 680);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 38);
            this.btnClose.TabIndex = 1020;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbDriversFilter
            // 
            this.cbDriversFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriversFilter.FormattingEnabled = true;
            this.cbDriversFilter.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "National No",
            "Full Name"});
            this.cbDriversFilter.Location = new System.Drawing.Point(105, 264);
            this.cbDriversFilter.Name = "cbDriversFilter";
            this.cbDriversFilter.Size = new System.Drawing.Size(171, 28);
            this.cbDriversFilter.TabIndex = 1019;
            this.cbDriversFilter.SelectedIndexChanged += new System.EventHandler(this.cbDriversFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1018;
            this.label2.Text = "Filter By:";
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(291, 265);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(171, 26);
            this.tbFilterValue.TabIndex = 1017;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labRecordCount.Location = new System.Drawing.Point(114, 688);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(22, 23);
            this.labRecordCount.TabIndex = 1016;
            this.labRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1015;
            this.label1.Text = "# Records :";
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.FormTitle.Location = new System.Drawing.Point(491, 186);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(275, 48);
            this.FormTitle.TabIndex = 1013;
            this.FormTitle.Text = "Manage Drivers";
            // 
            // pcManagePeople
            // 
            this.pcManagePeople.Image = global::DVLD.Properties.Resources.Driver_Main;
            this.pcManagePeople.Location = new System.Drawing.Point(479, -1);
            this.pcManagePeople.Name = "pcManagePeople";
            this.pcManagePeople.Size = new System.Drawing.Size(281, 184);
            this.pcManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcManagePeople.TabIndex = 1012;
            this.pcManagePeople.TabStop = false;
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AutoGenerateColumns = false;
            this.dgvDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverIDDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn,
            this.nationalNoDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.numberOfActiveLicensesDataGridViewTextBoxColumn});
            this.dgvDrivers.DataSource = this.driversViewBindingSource;
            this.dgvDrivers.Location = new System.Drawing.Point(12, 312);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.RowHeadersWidth = 62;
            this.dgvDrivers.RowTemplate.Height = 28;
            this.dgvDrivers.Size = new System.Drawing.Size(1215, 353);
            this.dgvDrivers.TabIndex = 1021;
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
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "Person ID";
            this.personIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nationalNoDataGridViewTextBoxColumn
            // 
            this.nationalNoDataGridViewTextBoxColumn.DataPropertyName = "NationalNo";
            this.nationalNoDataGridViewTextBoxColumn.HeaderText = "National No";
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
            this.fullNameDataGridViewTextBoxColumn.Width = 230;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.createdDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDateDataGridViewTextBoxColumn.Width = 240;
            // 
            // numberOfActiveLicensesDataGridViewTextBoxColumn
            // 
            this.numberOfActiveLicensesDataGridViewTextBoxColumn.DataPropertyName = "NumberOfActiveLicenses";
            this.numberOfActiveLicensesDataGridViewTextBoxColumn.HeaderText = "Active Licenses";
            this.numberOfActiveLicensesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfActiveLicensesDataGridViewTextBoxColumn.Name = "numberOfActiveLicensesDataGridViewTextBoxColumn";
            this.numberOfActiveLicensesDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfActiveLicensesDataGridViewTextBoxColumn.Width = 180;
            // 
            // driversViewBindingSource
            // 
            this.driversViewBindingSource.DataMember = "Drivers_View";
            this.driversViewBindingSource.DataSource = this.dsDrivers;
            // 
            // dsDrivers
            // 
            this.dsDrivers.DataSetName = "DsDrivers";
            this.dsDrivers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drivers_ViewTableAdapter
            // 
            this.drivers_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmDriverManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 730);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbDriversFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.pcManagePeople);
            this.Name = "frmDriverManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDriverManagement";
            this.Load += new System.EventHandler(this.frmDriverManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcManagePeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbDriversFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.PictureBox pcManagePeople;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private DsDrivers dsDrivers;
        private System.Windows.Forms.BindingSource driversViewBindingSource;
        private DsDriversTableAdapters.Drivers_ViewTableAdapter drivers_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfActiveLicensesDataGridViewTextBoxColumn;
    }
}