namespace DVLD.User_Controles
{
    partial class ucUserInfo
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
            this.gbLogInInfo = new System.Windows.Forms.GroupBox();
            this.labIsActiveValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labUsernameValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labUserIDValue = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gbLogInInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogInInfo
            // 
            this.gbLogInInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogInInfo.Controls.Add(this.labIsActiveValue);
            this.gbLogInInfo.Controls.Add(this.label3);
            this.gbLogInInfo.Controls.Add(this.labUsernameValue);
            this.gbLogInInfo.Controls.Add(this.label2);
            this.gbLogInInfo.Controls.Add(this.labUserIDValue);
            this.gbLogInInfo.Controls.Add(this.label23);
            this.gbLogInInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogInInfo.Location = new System.Drawing.Point(6, 3);
            this.gbLogInInfo.Name = "gbLogInInfo";
            this.gbLogInInfo.Size = new System.Drawing.Size(959, 94);
            this.gbLogInInfo.TabIndex = 83;
            this.gbLogInInfo.TabStop = false;
            this.gbLogInInfo.Text = "Login Information";
            this.gbLogInInfo.Enter += new System.EventHandler(this.gbLogInInfo_Enter);
            // 
            // labIsActiveValue
            // 
            this.labIsActiveValue.AutoSize = true;
            this.labIsActiveValue.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIsActiveValue.Location = new System.Drawing.Point(771, 38);
            this.labIsActiveValue.Name = "labIsActiveValue";
            this.labIsActiveValue.Size = new System.Drawing.Size(38, 32);
            this.labIsActiveValue.TabIndex = 107;
            this.labIsActiveValue.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(658, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 106;
            this.label3.Text = "Is Active:";
            // 
            // labUsernameValue
            // 
            this.labUsernameValue.AutoSize = true;
            this.labUsernameValue.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsernameValue.Location = new System.Drawing.Point(471, 38);
            this.labUsernameValue.Name = "labUsernameValue";
            this.labUsernameValue.Size = new System.Drawing.Size(38, 32);
            this.labUsernameValue.TabIndex = 105;
            this.labUsernameValue.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(358, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 104;
            this.label2.Text = "Username:";
            // 
            // labUserIDValue
            // 
            this.labUserIDValue.AutoSize = true;
            this.labUserIDValue.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserIDValue.Location = new System.Drawing.Point(190, 38);
            this.labUserIDValue.Name = "labUserIDValue";
            this.labUserIDValue.Size = new System.Drawing.Size(38, 32);
            this.labUserIDValue.TabIndex = 103;
            this.labUserIDValue.Text = "??";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(77, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 29);
            this.label23.TabIndex = 102;
            this.label23.Text = "User ID:";
            // 
            // ucUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLogInInfo);
            this.Name = "ucUserInfo";
            this.Size = new System.Drawing.Size(970, 113);
            this.gbLogInInfo.ResumeLayout(false);
            this.gbLogInInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogInInfo;
        private System.Windows.Forms.Label labUsernameValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labUserIDValue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labIsActiveValue;
        private System.Windows.Forms.Label label3;
    }
}
