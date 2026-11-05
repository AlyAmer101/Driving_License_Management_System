namespace DVLD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tsMainButtons = new System.Windows.Forms.ToolStrip();
            this.Applications = new System.Windows.Forms.ToolStripDropDownButton();
            this.drToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.releToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicensesApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicensesApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.People = new System.Windows.Forms.ToolStripButton();
            this.Drivers = new System.Windows.Forms.ToolStripButton();
            this.Users = new System.Windows.Forms.ToolStripButton();
            this.AccountSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsMainButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMainButtons
            // 
            this.tsMainButtons.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tsMainButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMainButtons.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsMainButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.People,
            this.Drivers,
            this.Users,
            this.AccountSettings});
            this.tsMainButtons.Location = new System.Drawing.Point(0, 0);
            this.tsMainButtons.Name = "tsMainButtons";
            this.tsMainButtons.Size = new System.Drawing.Size(1151, 73);
            this.tsMainButtons.TabIndex = 0;
            this.tsMainButtons.Text = "tsMainButtons";
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.Applications.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Applications.Image = ((System.Drawing.Image)(resources.GetObject("Applications.Image")));
            this.Applications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Applications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(212, 68);
            this.Applications.Text = "Applications";
            // 
            // drToolStripMenuItem
            // 
            this.drToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.reToolStripMenuItem,
            this.toolStripSeparator2,
            this.replacementForToolStripMenuItem,
            this.toolStripSeparator3,
            this.releToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drToolStripMenuItem.Image")));
            this.drToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drToolStripMenuItem.Name = "drToolStripMenuItem";
            this.drToolStripMenuItem.Size = new System.Drawing.Size(406, 74);
            this.drToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicensesToolStripMenuItem,
            this.interToolStripMenuItem});
            this.dToolStripMenuItem.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(518, 36);
            this.dToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicensesToolStripMenuItem
            // 
            this.localLicensesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Local_32;
            this.localLicensesToolStripMenuItem.Name = "localLicensesToolStripMenuItem";
            this.localLicensesToolStripMenuItem.Size = new System.Drawing.Size(312, 36);
            this.localLicensesToolStripMenuItem.Text = "Local License";
            this.localLicensesToolStripMenuItem.Click += new System.EventHandler(this.localLicensesToolStripMenuItem_Click);
            // 
            // interToolStripMenuItem
            // 
            this.interToolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.interToolStripMenuItem.Name = "interToolStripMenuItem";
            this.interToolStripMenuItem.Size = new System.Drawing.Size(312, 36);
            this.interToolStripMenuItem.Text = "International License";
            this.interToolStripMenuItem.Click += new System.EventHandler(this.interToolStripMenuItem_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(518, 36);
            this.reToolStripMenuItem.Text = "Renew Driving License";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(515, 6);
            // 
            // replacementForToolStripMenuItem
            // 
            this.replacementForToolStripMenuItem.Image = global::DVLD.Properties.Resources.Lost_Driving_License_32;
            this.replacementForToolStripMenuItem.Name = "replacementForToolStripMenuItem";
            this.replacementForToolStripMenuItem.Size = new System.Drawing.Size(518, 36);
            this.replacementForToolStripMenuItem.Text = "Replacement For Lost Or Damaged License";
            this.replacementForToolStripMenuItem.Click += new System.EventHandler(this.replacementForToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(515, 6);
            // 
            // releToolStripMenuItem
            // 
            this.releToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detained_Driving_License_32;
            this.releToolStripMenuItem.Name = "releToolStripMenuItem";
            this.releToolStripMenuItem.Size = new System.Drawing.Size(518, 36);
            this.releToolStripMenuItem.Text = "Release Detained Driving License";
            this.releToolStripMenuItem.Click += new System.EventHandler(this.releToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(518, 36);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicensesApplicationsToolStripMenuItem,
            this.internationalDrivingLicensesApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsToolStripMenuItem.Image")));
            this.manageApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(406, 74);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicensesApplicationsToolStripMenuItem
            // 
            this.localDrivingLicensesApplicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.localDrivingLicensesApplicationsToolStripMenuItem.Name = "localDrivingLicensesApplicationsToolStripMenuItem";
            this.localDrivingLicensesApplicationsToolStripMenuItem.Size = new System.Drawing.Size(447, 36);
            this.localDrivingLicensesApplicationsToolStripMenuItem.Text = "Local Driving Licenses Applications";
            this.localDrivingLicensesApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicensesApplicationsToolStripMenuItem_Click);
            // 
            // internationalDrivingLicensesApplicationToolStripMenuItem
            // 
            this.internationalDrivingLicensesApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.internationalDrivingLicensesApplicationToolStripMenuItem.Name = "internationalDrivingLicensesApplicationToolStripMenuItem";
            this.internationalDrivingLicensesApplicationToolStripMenuItem.Size = new System.Drawing.Size(447, 36);
            this.internationalDrivingLicensesApplicationToolStripMenuItem.Text = "International Licenses Applications";
            this.internationalDrivingLicensesApplicationToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLicensesApplicationToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.reToolStripMenuItem1});
            this.detainLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicensesToolStripMenuItem.Image")));
            this.detainLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(406, 74);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_64;
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_64;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // reToolStripMenuItem1
            // 
            this.reToolStripMenuItem1.Image = global::DVLD.Properties.Resources.Release_Detained_License_64;
            this.reToolStripMenuItem1.Name = "reToolStripMenuItem1";
            this.reToolStripMenuItem1.Size = new System.Drawing.Size(366, 36);
            this.reToolStripMenuItem1.Text = "Release Detained License";
            this.reToolStripMenuItem1.Click += new System.EventHandler(this.reToolStripMenuItem1_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationTypesToolStripMenuItem.Image")));
            this.manageApplicationTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(406, 74);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageTestTypesToolStripMenuItem.Image")));
            this.manageTestTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(406, 74);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // People
            // 
            this.People.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.People.Image = ((System.Drawing.Image)(resources.GetObject("People.Image")));
            this.People.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.People.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(143, 68);
            this.People.Text = "People";
            this.People.Click += new System.EventHandler(this.People_Click);
            // 
            // Drivers
            // 
            this.Drivers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Drivers.Image = ((System.Drawing.Image)(resources.GetObject("Drivers.Image")));
            this.Drivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Drivers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Drivers.Name = "Drivers";
            this.Drivers.Size = new System.Drawing.Size(148, 68);
            this.Drivers.Text = "Drivers";
            this.Drivers.Click += new System.EventHandler(this.Drivers_Click);
            // 
            // Users
            // 
            this.Users.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Users.Image = ((System.Drawing.Image)(resources.GetObject("Users.Image")));
            this.Users.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Users.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(131, 68);
            this.Users.Text = "Users";
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // AccountSettings
            // 
            this.AccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCurrentUserInfo,
            this.itemChangePassword,
            this.toolStripSeparator1,
            this.itemSignOut});
            this.AccountSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AccountSettings.Image = ((System.Drawing.Image)(resources.GetObject("AccountSettings.Image")));
            this.AccountSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AccountSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AccountSettings.Name = "AccountSettings";
            this.AccountSettings.Size = new System.Drawing.Size(255, 68);
            this.AccountSettings.Text = "Account Settings";
            this.AccountSettings.Click += new System.EventHandler(this.AccountSettings_Click);
            // 
            // itemCurrentUserInfo
            // 
            this.itemCurrentUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("itemCurrentUserInfo.Image")));
            this.itemCurrentUserInfo.Name = "itemCurrentUserInfo";
            this.itemCurrentUserInfo.Size = new System.Drawing.Size(279, 36);
            this.itemCurrentUserInfo.Text = "Current User Info";
            this.itemCurrentUserInfo.Click += new System.EventHandler(this.itemCurrentUserInfo_Click);
            // 
            // itemChangePassword
            // 
            this.itemChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("itemChangePassword.Image")));
            this.itemChangePassword.Name = "itemChangePassword";
            this.itemChangePassword.Size = new System.Drawing.Size(279, 36);
            this.itemChangePassword.Text = "Change Password";
            this.itemChangePassword.Click += new System.EventHandler(this.itemChangePassword_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(276, 6);
            // 
            // itemSignOut
            // 
            this.itemSignOut.Image = ((System.Drawing.Image)(resources.GetObject("itemSignOut.Image")));
            this.itemSignOut.Name = "itemSignOut";
            this.itemSignOut.Size = new System.Drawing.Size(279, 36);
            this.itemSignOut.Text = "Sign Out";
            this.itemSignOut.Click += new System.EventHandler(this.itemSignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1151, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tsMainButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tsMainButtons.ResumeLayout(false);
            this.tsMainButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainButtons;
        private System.Windows.Forms.ToolStripButton People;
        private System.Windows.Forms.ToolStripButton Drivers;
        private System.Windows.Forms.ToolStripButton Users;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton AccountSettings;
        private System.Windows.Forms.ToolStripMenuItem itemCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem itemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem itemSignOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton Applications;
        private System.Windows.Forms.ToolStripMenuItem drToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem replacementForToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem releToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicensesApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicensesApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem1;
    }
}

