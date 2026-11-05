namespace DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Issue_New_Driving_License
{
    partial class frmIssueDrivingLicenseForFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDrivingLicenseForFirstTime));
            this.ucApplicationBasicInfo2 = new DVLD.User_Controles.ucApplicationBasicInfo();
            this.ucDrivingLicenseApplicationInfo2 = new DVLD.User_Controles.ucDrivingLicenseApplicationInfo();
            this.tbNotes = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucApplicationBasicInfo2
            // 
            this.ucApplicationBasicInfo2.ApplicationID = 0;
            this.ucApplicationBasicInfo2.ApplicationPersonID = 0;
            this.ucApplicationBasicInfo2.Location = new System.Drawing.Point(11, 128);
            this.ucApplicationBasicInfo2.Name = "ucApplicationBasicInfo2";
            this.ucApplicationBasicInfo2.Size = new System.Drawing.Size(1154, 227);
            this.ucApplicationBasicInfo2.TabIndex = 1039;
            // 
            // ucDrivingLicenseApplicationInfo2
            // 
            this.ucDrivingLicenseApplicationInfo2.Location = new System.Drawing.Point(12, 3);
            this.ucDrivingLicenseApplicationInfo2.Name = "ucDrivingLicenseApplicationInfo2";
            this.ucDrivingLicenseApplicationInfo2.Size = new System.Drawing.Size(1154, 128);
            this.ucDrivingLicenseApplicationInfo2.TabIndex = 1038;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(128, 373);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(1037, 159);
            this.tbNotes.TabIndex = 1042;
            this.tbNotes.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point(85, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1041;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 1040;
            this.label4.Text = "Notes:";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnIssue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnIssue.FlatAppearance.BorderSize = 2;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnIssue.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(1050, 561);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(116, 37);
            this.btnIssue.TabIndex = 1044;
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
            this.btnClose.Location = new System.Drawing.Point(915, 561);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1043;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmIssueDrivingLicenseForFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 619);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ucApplicationBasicInfo2);
            this.Controls.Add(this.ucDrivingLicenseApplicationInfo2);
            this.Name = "frmIssueDrivingLicenseForFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License For First Time";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicenseForFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controles.ucApplicationBasicInfo ucApplicationBasicInfo2;
        private User_Controles.ucDrivingLicenseApplicationInfo ucDrivingLicenseApplicationInfo2;
        private System.Windows.Forms.RichTextBox tbNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
    }
}