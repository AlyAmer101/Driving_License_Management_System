namespace DVLD.Applications.Driving_Licenses_Services.Replacement_For_Damaged_Or_Lost_Licenses
{
    partial class frmReplacementForDamagedOrLostLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacementForDamagedOrLostLicenses));
            this.btnShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.PictureBox();
            this.FormTitle = new System.Windows.Forms.Label();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.rdLost = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucApplicationInfoForLicenseReplacement1 = new DVLD.User_Controles.ucApplicationInfoForLicenseReplacement();
            this.ucLicenseInfoFilter1 = new DVLD.User_Controles.ucLicenseInfoFilter();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.AutoSize = true;
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(215, 723);
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
            this.btnShowLicensesHistory.Location = new System.Drawing.Point(6, 723);
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
            this.btnClose.Location = new System.Drawing.Point(840, 715);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 37);
            this.btnClose.TabIndex = 1045;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnIssue.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(981, 715);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(125, 37);
            this.btnIssue.TabIndex = 1044;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
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
            this.FormTitle.Location = new System.Drawing.Point(279, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(563, 48);
            this.FormTitle.TabIndex = 1042;
            this.FormTitle.Text = "Replacement For Lost Application";
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Location = new System.Drawing.Point(31, 37);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(104, 24);
            this.rbDamaged.TabIndex = 1049;
            this.rbDamaged.Text = "Damaged";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // rdLost
            // 
            this.rdLost.AutoSize = true;
            this.rdLost.Checked = true;
            this.rdLost.Location = new System.Drawing.Point(159, 37);
            this.rdLost.Name = "rdLost";
            this.rdLost.Size = new System.Drawing.Size(65, 24);
            this.rdLost.TabIndex = 1050;
            this.rdLost.TabStop = true;
            this.rdLost.Text = "Lost";
            this.rdLost.UseVisualStyleBackColor = true;
            this.rdLost.CheckedChanged += new System.EventHandler(this.rdLost_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLost);
            this.groupBox1.Controls.Add(this.rbDamaged);
            this.groupBox1.Location = new System.Drawing.Point(840, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 83);
            this.groupBox1.TabIndex = 1051;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repalce License Because:";
            // 
            // ucApplicationInfoForLicenseReplacement1
            // 
            this.ucApplicationInfoForLicenseReplacement1.Location = new System.Drawing.Point(6, 562);
            this.ucApplicationInfoForLicenseReplacement1.Name = "ucApplicationInfoForLicenseReplacement1";
            this.ucApplicationInfoForLicenseReplacement1.Size = new System.Drawing.Size(1100, 147);
            this.ucApplicationInfoForLicenseReplacement1.TabIndex = 1048;
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
            // frmReplacementForDamagedOrLostLicenses
            // 
            this.AcceptButton = this.btnIssue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 767);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucApplicationInfoForLicenseReplacement1);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.ucLicenseInfoFilter1);
            this.Name = "frmReplacementForDamagedOrLostLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReplacementForDamagedOrLostLicenses";
            this.Load += new System.EventHandler(this.frmReplacementForDamagedOrLostLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFilter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel btnShowLicenseInfo;
        private System.Windows.Forms.LinkLabel btnShowLicensesHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.PictureBox btnFilter;
        private System.Windows.Forms.Label FormTitle;
        private User_Controles.ucLicenseInfoFilter ucLicenseInfoFilter1;
        private User_Controles.ucApplicationInfoForLicenseReplacement ucApplicationInfoForLicenseReplacement1;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.RadioButton rdLost;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}