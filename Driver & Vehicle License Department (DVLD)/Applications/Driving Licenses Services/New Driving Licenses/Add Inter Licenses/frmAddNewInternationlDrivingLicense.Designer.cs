namespace DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses
{
    partial class frmAddNewInternationlDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewInternationlDrivingLicense));
            this.FormTitle = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.btnShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnFilter = new System.Windows.Forms.PictureBox();
            this.ucLicenseApplicationInfo1 = new DVLD.User_Controles.ucLicenseApplicationInfo();
            this.ucLicenseInfoFilter1 = new DVLD.User_Controles.ucLicenseInfoFilter();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.FormTitle.Location = new System.Drawing.Point(273, 17);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(543, 48);
            this.FormTitle.TabIndex = 1021;
            this.FormTitle.Text = "Internationl License Application";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnIssue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnIssue.FlatAppearance.BorderSize = 2;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(1005, 822);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(116, 37);
            this.btnIssue.TabIndex = 1028;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
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
            this.btnClose.Location = new System.Drawing.Point(869, 822);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1029;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowLicensesHistory
            // 
            this.btnShowLicensesHistory.AutoSize = true;
            this.btnShowLicensesHistory.Enabled = false;
            this.btnShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowLicensesHistory.Location = new System.Drawing.Point(21, 830);
            this.btnShowLicensesHistory.Name = "btnShowLicensesHistory";
            this.btnShowLicensesHistory.Size = new System.Drawing.Size(192, 22);
            this.btnShowLicensesHistory.TabIndex = 1030;
            this.btnShowLicensesHistory.TabStop = true;
            this.btnShowLicensesHistory.Text = "Show Licenses History";
            this.btnShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnShowLicensesHistory_LinkClicked);
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.AutoSize = true;
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(228, 830);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(156, 22);
            this.btnShowLicenseInfo.TabIndex = 1031;
            this.btnShowLicenseInfo.TabStop = true;
            this.btnShowLicenseInfo.Text = "Show License Info";
            this.btnShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnShowLicenseInfo_LinkClicked);
            // 
            // btnFilter
            // 
            this.btnFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFilter.Image = global::DVLD.Properties.Resources.License_View_32;
            this.btnFilter.Location = new System.Drawing.Point(713, 131);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 52);
            this.btnFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFilter.TabIndex = 1032;
            this.btnFilter.TabStop = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ucLicenseApplicationInfo1
            // 
            this.ucLicenseApplicationInfo1.Location = new System.Drawing.Point(21, 589);
            this.ucLicenseApplicationInfo1.Name = "ucLicenseApplicationInfo1";
            this.ucLicenseApplicationInfo1.Size = new System.Drawing.Size(1100, 222);
            this.ucLicenseApplicationInfo1.TabIndex = 1022;
            // 
            // ucLicenseInfoFilter1
            // 
            this.ucLicenseInfoFilter1.CanIssueInternationalLicense = false;
            this.ucLicenseInfoFilter1.IsLicenseFound = false;
            this.ucLicenseInfoFilter1.LocalLicenseID = 0;
            this.ucLicenseInfoFilter1.Location = new System.Drawing.Point(21, 78);
            this.ucLicenseInfoFilter1.Name = "ucLicenseInfoFilter1";
            this.ucLicenseInfoFilter1.Size = new System.Drawing.Size(1100, 505);
            this.ucLicenseInfoFilter1.TabIndex = 0;
            // 
            // frmAddNewInternationlDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 869);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ucLicenseApplicationInfo1);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.ucLicenseInfoFilter1);
            this.Name = "frmAddNewInternationlDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewInternationlDrivingLicense";
            this.Load += new System.EventHandler(this.frmAddNewInternationlDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controles.ucLicenseInfoFilter ucLicenseInfoFilter1;
        private System.Windows.Forms.Label FormTitle;
        private User_Controles.ucLicenseApplicationInfo ucLicenseApplicationInfo1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel btnShowLicensesHistory;
        private System.Windows.Forms.LinkLabel btnShowLicenseInfo;
        private System.Windows.Forms.PictureBox btnFilter;
    }
}