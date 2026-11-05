namespace DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_Person_License_History
{
    partial class frmShowPersonInfo
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
            this.ucPersonInfo1 = new DVLD.ucPersonInfo();
            this.SuspendLayout();
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(3, 2);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.NationalNo = null;
            this.ucPersonInfo1.PersonID = 0;
            this.ucPersonInfo1.Size = new System.Drawing.Size(987, 370);
            this.ucPersonInfo1.TabIndex = 4;
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 371);
            this.Controls.Add(this.ucPersonInfo1);
            this.Name = "frmShowPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowPersonInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ucPersonInfo ucPersonInfo1;
    }
}