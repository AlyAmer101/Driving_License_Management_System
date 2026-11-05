namespace DVLD.Applications.Driving_Licenses_Services.Detain_Licenses
{
    partial class frmDetainAndReleaseLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainAndReleaseLicenses));
            this.btnShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetainRelease = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.PictureBox();
            this.FormTitle = new System.Windows.Forms.Label();
            this.ucLicenseInfoFilter1 = new DVLD.User_Controles.ucLicenseInfoFilter();
            this.ucDetainInfoOnReleaseMode1 = new DVLD.User_Controles.ucDetainInfoOnReleaseMode();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.AutoSize = true;
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(213, 781);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(156, 22);
            this.btnShowLicenseInfo.TabIndex = 1047;
            this.btnShowLicenseInfo.TabStop = true;
            this.btnShowLicenseInfo.Text = "Show License Info";
            this.btnShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnShowLicenseInfo_LinkClicked);
            // 
            // btnShowLicensesHistory
            // 
            this.btnShowLicensesHistory.AutoSize = true;
            this.btnShowLicensesHistory.Enabled = false;
            this.btnShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowLicensesHistory.Location = new System.Drawing.Point(6, 781);
            this.btnShowLicensesHistory.Name = "btnShowLicensesHistory";
            this.btnShowLicensesHistory.Size = new System.Drawing.Size(192, 22);
            this.btnShowLicensesHistory.TabIndex = 1046;
            this.btnShowLicensesHistory.TabStop = true;
            this.btnShowLicensesHistory.Text = "Show Licenses History";
            this.btnShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnShowLicensesHistory_LinkClicked);
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
            this.btnClose.Location = new System.Drawing.Point(838, 773);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 37);
            this.btnClose.TabIndex = 1045;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetainRelease
            // 
            this.btnDetainRelease.BackColor = System.Drawing.Color.Transparent;
            this.btnDetainRelease.Enabled = false;
            this.btnDetainRelease.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDetainRelease.FlatAppearance.BorderSize = 2;
            this.btnDetainRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainRelease.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.btnDetainRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainRelease.Location = new System.Drawing.Point(981, 773);
            this.btnDetainRelease.Name = "btnDetainRelease";
            this.btnDetainRelease.Size = new System.Drawing.Size(125, 37);
            this.btnDetainRelease.TabIndex = 1044;
            this.btnDetainRelease.Text = "Detain";
            this.btnDetainRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetainRelease.UseVisualStyleBackColor = false;
            this.btnDetainRelease.Click += new System.EventHandler(this.btnDetainRelease_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFilter.Image = global::DVLD.Properties.Resources.License_View_32;
            this.btnFilter.Location = new System.Drawing.Point(693, 100);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 52);
            this.btnFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFilter.TabIndex = 1043;
            this.btnFilter.TabStop = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.FormTitle.Location = new System.Drawing.Point(431, 11);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(259, 48);
            this.FormTitle.TabIndex = 1042;
            this.FormTitle.Text = "Detain License";
            // 
            // ucLicenseInfoFilter1
            // 
            this.ucLicenseInfoFilter1.CanIssueInternationalLicense = false;
            this.ucLicenseInfoFilter1.IsLicenseFound = false;
            this.ucLicenseInfoFilter1.LocalLicenseID = 0;
            this.ucLicenseInfoFilter1.Location = new System.Drawing.Point(6, 51);
            this.ucLicenseInfoFilter1.Name = "ucLicenseInfoFilter1";
            this.ucLicenseInfoFilter1.Size = new System.Drawing.Size(1108, 505);
            this.ucLicenseInfoFilter1.TabIndex = 1041;
            // 
            // ucDetainInfoOnReleaseMode1
            // 
            this.ucDetainInfoOnReleaseMode1.Location = new System.Drawing.Point(12, 562);
            this.ucDetainInfoOnReleaseMode1.Name = "ucDetainInfoOnReleaseMode1";
            this.ucDetainInfoOnReleaseMode1.Size = new System.Drawing.Size(1094, 194);
            this.ucDetainInfoOnReleaseMode1.TabIndex = 1049;
            // 
            // frmDetainAndReleaseLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 828);
            this.Controls.Add(this.ucDetainInfoOnReleaseMode1);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetainRelease);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.ucLicenseInfoFilter1);
            this.Name = "frmDetainAndReleaseLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetainAndReleaseLicenses";
            this.Load += new System.EventHandler(this.frmDetainAndReleaseLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel btnShowLicenseInfo;
        private System.Windows.Forms.LinkLabel btnShowLicensesHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetainRelease;
        private System.Windows.Forms.PictureBox btnFilter;
        private System.Windows.Forms.Label FormTitle;
        private User_Controles.ucLicenseInfoFilter ucLicenseInfoFilter1;
        private User_Controles.ucDetainInfo ucDetainInfo1;
        private User_Controles.ucDetainInfoOnReleaseMode ucDetainInfoOnReleaseMode1;
    }
}