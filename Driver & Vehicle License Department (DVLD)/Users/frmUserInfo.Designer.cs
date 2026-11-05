namespace DVLD.Users
{
    partial class frmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfo));
            this.ucPersonalnfo = new DVLD.ucPersonInfo();
            this.ucLoginInfo = new DVLD.User_Controles.ucUserInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucPersonalnfo
            // 
            this.ucPersonalnfo.Location = new System.Drawing.Point(12, 12);
            this.ucPersonalnfo.Name = "ucPersonalnfo";
            this.ucPersonalnfo.NationalNo = null;
            this.ucPersonalnfo.PersonID = 0;
            this.ucPersonalnfo.Size = new System.Drawing.Size(978, 382);
            this.ucPersonalnfo.TabIndex = 1008;
            // 
            // ucLoginInfo
            // 
            this.ucLoginInfo.Location = new System.Drawing.Point(12, 412);
            this.ucLoginInfo.Name = "ucLoginInfo";
            this.ucLoginInfo.Size = new System.Drawing.Size(978, 113);
            this.ucLoginInfo.TabIndex = 1009;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(854, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 44);
            this.btnClose.TabIndex = 1010;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 588);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucLoginInfo);
            this.Controls.Add(this.ucPersonalnfo);
            this.Name = "frmUserInfo";
            this.Text = "frmUserInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private DVLD.ucPersonInfo ucPersonalnfo;
        private User_Controles.ucUserInfo ucLoginInfo;
        private System.Windows.Forms.Button btnClose;
    }
}