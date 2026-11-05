namespace DVLD.Applications.Schedule_Tests
{
    partial class frmTestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointments));
            this.pbFormLogo = new System.Windows.Forms.PictureBox();
            this.FormTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.testAppointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLockedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.testTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testAppointmentsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_TestAppointments = new DVLD.DS_TestAppointments();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnScheduleNewVisionTest = new System.Windows.Forms.Button();
            this.testAppointments_ViewTableAdapter = new DVLD.DS_TestAppointmentsTableAdapters.TestAppointments_ViewTableAdapter();
            this.ucApplicationBasicInfo2 = new DVLD.User_Controles.ucApplicationBasicInfo();
            this.ucDrivingLicenseApplicationInfo2 = new DVLD.User_Controles.ucDrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testAppointmentsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_TestAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFormLogo
            // 
            this.pbFormLogo.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pbFormLogo.Location = new System.Drawing.Point(448, 12);
            this.pbFormLogo.Name = "pbFormLogo";
            this.pbFormLogo.Size = new System.Drawing.Size(281, 184);
            this.pbFormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFormLogo.TabIndex = 2;
            this.pbFormLogo.TabStop = false;
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.FormTitle.Location = new System.Drawing.Point(372, 174);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(432, 48);
            this.FormTitle.TabIndex = 1027;
            this.FormTitle.Text = "Vision Test Appointments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1030;
            this.label1.Text = "Appointments:";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.AutoGenerateColumns = false;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testAppointmentIDDataGridViewTextBoxColumn,
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn,
            this.appointmentDateDataGridViewTextBoxColumn,
            this.paidFeesDataGridViewTextBoxColumn,
            this.isLockedDataGridViewCheckBoxColumn,
            this.testTypeIDDataGridViewTextBoxColumn});
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointments;
            this.dgvAppointments.DataSource = this.testAppointmentsViewBindingSource;
            this.dgvAppointments.Location = new System.Drawing.Point(11, 637);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 62;
            this.dgvAppointments.RowTemplate.Height = 28;
            this.dgvAppointments.Size = new System.Drawing.Size(1154, 195);
            this.dgvAppointments.TabIndex = 1031;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // testAppointmentIDDataGridViewTextBoxColumn
            // 
            this.testAppointmentIDDataGridViewTextBoxColumn.DataPropertyName = "TestAppointmentID";
            this.testAppointmentIDDataGridViewTextBoxColumn.HeaderText = "Appointment ID";
            this.testAppointmentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.testAppointmentIDDataGridViewTextBoxColumn.Name = "testAppointmentIDDataGridViewTextBoxColumn";
            this.testAppointmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testAppointmentIDDataGridViewTextBoxColumn.Width = 160;
            // 
            // localDrivingLicenseApplicationIDDataGridViewTextBoxColumn
            // 
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.DataPropertyName = "LocalDrivingLicenseApplicationID";
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.HeaderText = "LocalDrivingLicenseApplicationID";
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.Name = "localDrivingLicenseApplicationIDDataGridViewTextBoxColumn";
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.Visible = false;
            this.localDrivingLicenseApplicationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "Appointment Date";
            this.appointmentDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            this.appointmentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointmentDateDataGridViewTextBoxColumn.Width = 230;
            // 
            // paidFeesDataGridViewTextBoxColumn
            // 
            this.paidFeesDataGridViewTextBoxColumn.DataPropertyName = "PaidFees";
            this.paidFeesDataGridViewTextBoxColumn.HeaderText = "Paid Fees";
            this.paidFeesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paidFeesDataGridViewTextBoxColumn.Name = "paidFeesDataGridViewTextBoxColumn";
            this.paidFeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidFeesDataGridViewTextBoxColumn.Width = 150;
            // 
            // isLockedDataGridViewCheckBoxColumn
            // 
            this.isLockedDataGridViewCheckBoxColumn.DataPropertyName = "IsLocked";
            this.isLockedDataGridViewCheckBoxColumn.HeaderText = "Is Locked";
            this.isLockedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isLockedDataGridViewCheckBoxColumn.Name = "isLockedDataGridViewCheckBoxColumn";
            this.isLockedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isLockedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // testTypeIDDataGridViewTextBoxColumn
            // 
            this.testTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TestTypeID";
            this.testTypeIDDataGridViewTextBoxColumn.HeaderText = "TestTypeID";
            this.testTypeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.testTypeIDDataGridViewTextBoxColumn.Name = "testTypeIDDataGridViewTextBoxColumn";
            this.testTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testTypeIDDataGridViewTextBoxColumn.Visible = false;
            this.testTypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsAppointments.Name = "cmsAppointments";
            this.cmsAppointments.Size = new System.Drawing.Size(162, 68);
            this.cmsAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAppointments_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // testAppointmentsViewBindingSource
            // 
            this.testAppointmentsViewBindingSource.DataMember = "TestAppointments_View";
            this.testAppointmentsViewBindingSource.DataSource = this.dS_TestAppointments;
            // 
            // dS_TestAppointments
            // 
            this.dS_TestAppointments.DataSetName = "DS_TestAppointments";
            this.dS_TestAppointments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labRecordCount
            // 
            this.labRecordCount.AutoSize = true;
            this.labRecordCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labRecordCount.Location = new System.Drawing.Point(134, 857);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(22, 23);
            this.labRecordCount.TabIndex = 1034;
            this.labRecordCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 857);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1033;
            this.label2.Text = "# Records :";
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
            this.btnClose.Location = new System.Drawing.Point(1049, 848);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1032;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnScheduleNewVisionTest
            // 
            this.btnScheduleNewVisionTest.BackColor = System.Drawing.Color.Transparent;
            this.btnScheduleNewVisionTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnScheduleNewVisionTest.FlatAppearance.BorderSize = 2;
            this.btnScheduleNewVisionTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleNewVisionTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleNewVisionTest.Image = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btnScheduleNewVisionTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleNewVisionTest.Location = new System.Drawing.Point(1119, 594);
            this.btnScheduleNewVisionTest.Name = "btnScheduleNewVisionTest";
            this.btnScheduleNewVisionTest.Size = new System.Drawing.Size(45, 37);
            this.btnScheduleNewVisionTest.TabIndex = 1035;
            this.btnScheduleNewVisionTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScheduleNewVisionTest.UseVisualStyleBackColor = false;
            this.btnScheduleNewVisionTest.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // testAppointments_ViewTableAdapter
            // 
            this.testAppointments_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // ucApplicationBasicInfo2
            // 
            this.ucApplicationBasicInfo2.ApplicationID = 0;
            this.ucApplicationBasicInfo2.ApplicationPersonID = 0;
            this.ucApplicationBasicInfo2.Location = new System.Drawing.Point(11, 361);
            this.ucApplicationBasicInfo2.Name = "ucApplicationBasicInfo2";
            this.ucApplicationBasicInfo2.Size = new System.Drawing.Size(1154, 227);
            this.ucApplicationBasicInfo2.TabIndex = 1037;
            // 
            // ucDrivingLicenseApplicationInfo2
            // 
            this.ucDrivingLicenseApplicationInfo2.Location = new System.Drawing.Point(11, 236);
            this.ucDrivingLicenseApplicationInfo2.Name = "ucDrivingLicenseApplicationInfo2";
            this.ucDrivingLicenseApplicationInfo2.Size = new System.Drawing.Size(1154, 128);
            this.ucDrivingLicenseApplicationInfo2.TabIndex = 1036;
            this.ucDrivingLicenseApplicationInfo2.Load += new System.EventHandler(this.ucDrivingLicenseApplicationInfo2_Load);
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 893);
            this.Controls.Add(this.ucApplicationBasicInfo2);
            this.Controls.Add(this.ucDrivingLicenseApplicationInfo2);
            this.Controls.Add(this.btnScheduleNewVisionTest);
            this.Controls.Add(this.labRecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.pbFormLogo);
            this.Name = "frmTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTestAppointments";
            this.Load += new System.EventHandler(this.frmScheduleVisionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testAppointmentsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_TestAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ucPersonInfo ucPersonInfo1;
        private System.Windows.Forms.PictureBox pbFormLogo;
        private System.Windows.Forms.Label FormTitle;
        private User_Controles.ucApplicationBasicInfo ucApplicationBasicInfo1;
        private User_Controles.ucDrivingLicenseApplicationInfo ucDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnScheduleNewVisionTest;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestAppointmentID;
        private User_Controles.ucDrivingLicenseApplicationInfo ucDrivingLicenseApplicationInfo2;
        private User_Controles.ucApplicationBasicInfo ucApplicationBasicInfo2;
        private DS_TestAppointments dS_TestAppointments;
        private System.Windows.Forms.BindingSource testAppointmentsViewBindingSource;
        private DS_TestAppointmentsTableAdapters.TestAppointments_ViewTableAdapter testAppointments_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn testAppointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDrivingLicenseApplicationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidFeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLockedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeIDDataGridViewTextBoxColumn;
    }
}