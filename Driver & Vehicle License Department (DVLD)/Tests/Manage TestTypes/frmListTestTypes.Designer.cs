namespace DVLD.Applications.Manage_TestTypes
{
    partial class frmListTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTestTypes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.testTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTypeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTypeFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTestTypes = new DVLD.dsTestTypes();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.FormTitle = new System.Windows.Forms.Label();
            this.testTypesTableAdapter = new DVLD.dsTestTypesTableAdapters.TestTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTestTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(360, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1019;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestTypes.AutoGenerateColumns = false;
            this.dgvTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testTypeIDDataGridViewTextBoxColumn,
            this.testTypeTitleDataGridViewTextBoxColumn,
            this.testTypeDescriptionDataGridViewTextBoxColumn,
            this.testTypeFeesDataGridViewTextBoxColumn});
            this.dgvTestTypes.ContextMenuStrip = this.cmsTestTypes;
            this.dgvTestTypes.DataSource = this.testTypesBindingSource;
            this.dgvTestTypes.GridColor = System.Drawing.Color.Black;
            this.dgvTestTypes.Location = new System.Drawing.Point(12, 323);
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersWidth = 62;
            this.dgvTestTypes.Size = new System.Drawing.Size(976, 336);
            this.dgvTestTypes.TabIndex = 1018;
            // 
            // testTypeIDDataGridViewTextBoxColumn
            // 
            this.testTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TestTypeID";
            this.testTypeIDDataGridViewTextBoxColumn.Frozen = true;
            this.testTypeIDDataGridViewTextBoxColumn.HeaderText = "TestTypeID";
            this.testTypeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.testTypeIDDataGridViewTextBoxColumn.Name = "testTypeIDDataGridViewTextBoxColumn";
            this.testTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testTypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // testTypeTitleDataGridViewTextBoxColumn
            // 
            this.testTypeTitleDataGridViewTextBoxColumn.DataPropertyName = "TestTypeTitle";
            this.testTypeTitleDataGridViewTextBoxColumn.FillWeight = 200F;
            this.testTypeTitleDataGridViewTextBoxColumn.Frozen = true;
            this.testTypeTitleDataGridViewTextBoxColumn.HeaderText = "TestTypeTitle";
            this.testTypeTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.testTypeTitleDataGridViewTextBoxColumn.Name = "testTypeTitleDataGridViewTextBoxColumn";
            this.testTypeTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.testTypeTitleDataGridViewTextBoxColumn.Width = 200;
            // 
            // testTypeDescriptionDataGridViewTextBoxColumn
            // 
            this.testTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TestTypeDescription";
            this.testTypeDescriptionDataGridViewTextBoxColumn.FillWeight = 420F;
            this.testTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "TestTypeDescription";
            this.testTypeDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.testTypeDescriptionDataGridViewTextBoxColumn.Name = "testTypeDescriptionDataGridViewTextBoxColumn";
            this.testTypeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.testTypeDescriptionDataGridViewTextBoxColumn.Width = 420;
            // 
            // testTypeFeesDataGridViewTextBoxColumn
            // 
            this.testTypeFeesDataGridViewTextBoxColumn.DataPropertyName = "TestTypeFees";
            this.testTypeFeesDataGridViewTextBoxColumn.FillWeight = 120F;
            this.testTypeFeesDataGridViewTextBoxColumn.HeaderText = "TestTypeFees";
            this.testTypeFeesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.testTypeFeesDataGridViewTextBoxColumn.Name = "testTypeFeesDataGridViewTextBoxColumn";
            this.testTypeFeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.testTypeFeesDataGridViewTextBoxColumn.Width = 120;
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestTypeToolStripMenuItem});
            this.cmsTestTypes.Name = "cmsApplicationTypes";
            this.cmsTestTypes.Size = new System.Drawing.Size(200, 36);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(199, 32);
            this.editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            this.editTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editTestTypeToolStripMenuItem_Click);
            // 
            // testTypesBindingSource
            // 
            this.testTypesBindingSource.DataMember = "TestTypes";
            this.testTypesBindingSource.DataSource = this.dsTestTypes;
            // 
            // dsTestTypes
            // 
            this.dsTestTypes.DataSetName = "dsTestTypes";
            this.dsTestTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labRecordCount.Location = new System.Drawing.Point(131, 700);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(22, 23);
            this.labRecordCount.TabIndex = 1023;
            this.labRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 700);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1022;
            this.label1.Text = "# Records :";
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
            this.btnClose.Location = new System.Drawing.Point(872, 691);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1021;
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
            this.FormTitle.Location = new System.Drawing.Point(336, 238);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(329, 48);
            this.FormTitle.TabIndex = 1020;
            this.FormTitle.Text = "Manage Test Types";
            // 
            // testTypesTableAdapter
            // 
            this.testTypesTableAdapter.ClearBeforeFill = true;
            // 
            // frmListTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1001, 748);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FormTitle);
            this.Name = "frmListTestTypes";
            this.Text = "frmListTestTypes";
            this.Load += new System.EventHandler(this.frmListTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTestTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label FormTitle;
        private dsTestTypes dsTestTypes;
        private System.Windows.Forms.BindingSource testTypesBindingSource;
        private dsTestTypesTableAdapters.TestTypesTableAdapter testTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeFeesDataGridViewTextBoxColumn;
    }
}