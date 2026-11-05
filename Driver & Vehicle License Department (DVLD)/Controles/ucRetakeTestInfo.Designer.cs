namespace DVLD.User_Controles
{
    partial class ucRetakeTestInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbRetakeTestInfo = new System.Windows.Forms.GroupBox();
            this.labRetakeTestAppID = new System.Windows.Forms.Label();
            this.labTotaleFees = new System.Windows.Forms.Label();
            this.labRetakeApplicationFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRetakeTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRetakeTestInfo
            // 
            this.gbRetakeTestInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRetakeTestInfo.Controls.Add(this.labRetakeTestAppID);
            this.gbRetakeTestInfo.Controls.Add(this.labTotaleFees);
            this.gbRetakeTestInfo.Controls.Add(this.labRetakeApplicationFees);
            this.gbRetakeTestInfo.Controls.Add(this.label3);
            this.gbRetakeTestInfo.Controls.Add(this.label2);
            this.gbRetakeTestInfo.Controls.Add(this.label1);
            this.gbRetakeTestInfo.Location = new System.Drawing.Point(3, 3);
            this.gbRetakeTestInfo.Name = "gbRetakeTestInfo";
            this.gbRetakeTestInfo.Size = new System.Drawing.Size(599, 139);
            this.gbRetakeTestInfo.TabIndex = 0;
            this.gbRetakeTestInfo.TabStop = false;
            this.gbRetakeTestInfo.Text = "Retake Test  Info";
            this.gbRetakeTestInfo.Enter += new System.EventHandler(this.gbRetakeTestInfo_Enter);
            // 
            // labRetakeTestAppID
            // 
            this.labRetakeTestAppID.AutoSize = true;
            this.labRetakeTestAppID.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labRetakeTestAppID.Location = new System.Drawing.Point(204, 85);
            this.labRetakeTestAppID.Name = "labRetakeTestAppID";
            this.labRetakeTestAppID.Size = new System.Drawing.Size(54, 29);
            this.labRetakeTestAppID.TabIndex = 11;
            this.labRetakeTestAppID.Tag = "N/A";
            this.labRetakeTestAppID.Text = "N/A";
            // 
            // labTotaleFees
            // 
            this.labTotaleFees.AutoSize = true;
            this.labTotaleFees.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labTotaleFees.Location = new System.Drawing.Point(477, 39);
            this.labTotaleFees.Name = "labTotaleFees";
            this.labTotaleFees.Size = new System.Drawing.Size(25, 29);
            this.labTotaleFees.TabIndex = 10;
            this.labTotaleFees.Text = "0";
            // 
            // labRetakeApplicationFees
            // 
            this.labRetakeApplicationFees.AutoSize = true;
            this.labRetakeApplicationFees.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labRetakeApplicationFees.Location = new System.Drawing.Point(204, 39);
            this.labRetakeApplicationFees.Name = "labRetakeApplicationFees";
            this.labRetakeApplicationFees.Size = new System.Drawing.Size(25, 29);
            this.labRetakeApplicationFees.TabIndex = 9;
            this.labRetakeApplicationFees.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(346, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "R. Test App ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "R. App Fees:";
            // 
            // ucRetakeTestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbRetakeTestInfo);
            this.Name = "ucRetakeTestInfo";
            this.Size = new System.Drawing.Size(606, 145);
            this.gbRetakeTestInfo.ResumeLayout(false);
            this.gbRetakeTestInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRetakeTestInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labRetakeApplicationFees;
        private System.Windows.Forms.Label labRetakeTestAppID;
        private System.Windows.Forms.Label labTotaleFees;
    }
}
