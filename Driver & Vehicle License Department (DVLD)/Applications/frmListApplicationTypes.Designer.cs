namespace DVLD.Applications.Manage_Applications
{
    partial class frmListApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListApplicationTypes));
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.cmsApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsApplicationTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsApplicationTypes = new DVLD.dsApplicationTypes();
            this.applicationTypesTableAdapter = new DVLD.dsApplicationTypesTableAdapters.ApplicationTypesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormTitle = new System.Windows.Forms.Label();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.applicationTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationTypeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.cmsApplicationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApplicationTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApplicationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.AutoGenerateColumns = false;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicationTypeIDDataGridViewTextBoxColumn,
            this.applicationTypeTitleDataGridViewTextBoxColumn,
            this.applicationFeesDataGridViewTextBoxColumn});
            this.dgvApplicationTypes.ContextMenuStrip = this.cmsApplicationTypes;
            this.dgvApplicationTypes.DataSource = this.applicationTypesBindingSource;
            this.dgvApplicationTypes.GridColor = System.Drawing.Color.Black;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(13, 327);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            this.dgvApplicationTypes.RowHeadersWidth = 62;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(725, 336);
            this.dgvApplicationTypes.TabIndex = 0;
            // 
            // cmsApplicationTypes
            // 
            this.cmsApplicationTypes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypeToolStripMenuItem});
            this.cmsApplicationTypes.Name = "cmsApplicationTypes";
            this.cmsApplicationTypes.Size = new System.Drawing.Size(260, 36);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.editApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeToolStripMenuItem_Click);
            // 
            // applicationTypesBindingSource
            // 
            this.applicationTypesBindingSource.DataMember = "ApplicationTypes";
            this.applicationTypesBindingSource.DataSource = this.dsApplicationTypesBindingSource;
            // 
            // dsApplicationTypesBindingSource
            // 
            this.dsApplicationTypesBindingSource.DataSource = this.dsApplicationTypes;
            this.dsApplicationTypesBindingSource.Position = 0;
            // 
            // dsApplicationTypes
            // 
            this.dsApplicationTypes.DataSetName = "dsApplicationTypes";
            this.dsApplicationTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationTypesTableAdapter
            // 
            this.applicationTypesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Application_Types_64;
            this.pictureBox1.Location = new System.Drawing.Point(235, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.FormTitle.Location = new System.Drawing.Point(13, 242);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(725, 48);
            this.FormTitle.TabIndex = 6;
            this.FormTitle.Text = "Manage Application Types";
            this.FormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labRecordCount.Location = new System.Drawing.Point(132, 704);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(22, 23);
            this.labRecordCount.TabIndex = 1017;
            this.labRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1016;
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
            this.btnClose.Location = new System.Drawing.Point(622, 690);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1015;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // applicationTypeIDDataGridViewTextBoxColumn
            // 
            this.applicationTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ApplicationTypeID";
            this.applicationTypeIDDataGridViewTextBoxColumn.HeaderText = "ApplicationTypeID";
            this.applicationTypeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicationTypeIDDataGridViewTextBoxColumn.Name = "applicationTypeIDDataGridViewTextBoxColumn";
            this.applicationTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationTypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // applicationTypeTitleDataGridViewTextBoxColumn
            // 
            this.applicationTypeTitleDataGridViewTextBoxColumn.DataPropertyName = "ApplicationTypeTitle";
            this.applicationTypeTitleDataGridViewTextBoxColumn.HeaderText = "ApplicationTypeTitle";
            this.applicationTypeTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicationTypeTitleDataGridViewTextBoxColumn.Name = "applicationTypeTitleDataGridViewTextBoxColumn";
            this.applicationTypeTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationTypeTitleDataGridViewTextBoxColumn.Width = 300;
            // 
            // applicationFeesDataGridViewTextBoxColumn
            // 
            this.applicationFeesDataGridViewTextBoxColumn.DataPropertyName = "ApplicationFees";
            this.applicationFeesDataGridViewTextBoxColumn.HeaderText = "ApplicationFees";
            this.applicationFeesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicationFeesDataGridViewTextBoxColumn.Name = "applicationFeesDataGridViewTextBoxColumn";
            this.applicationFeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationFeesDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmListApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 748);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Name = "frmListApplicationTypes";
            this.Text = "frmListApplicationTypes";
            this.Load += new System.EventHandler(this.frmListApplicationTypes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.cmsApplicationTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApplicationTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApplicationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.BindingSource dsApplicationTypesBindingSource;
        private dsApplicationTypes dsApplicationTypes;
        private System.Windows.Forms.BindingSource applicationTypesBindingSource;
        private dsApplicationTypesTableAdapters.ApplicationTypesTableAdapter applicationTypesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationTypeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationFeesDataGridViewTextBoxColumn;
    }
}