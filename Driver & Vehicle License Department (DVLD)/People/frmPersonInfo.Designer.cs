namespace DVLD
{
    partial class frmPersonInfo
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
            this.labFormTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucPersonInfoInPersonalDetailsForm = new DVLD.ucPersonInfo();
            this.SuspendLayout();
            // 
            // labFormTitle
            // 
            this.labFormTitle.AutoSize = true;
            this.labFormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.labFormTitle.ForeColor = System.Drawing.Color.Red;
            this.labFormTitle.Location = new System.Drawing.Point(358, 28);
            this.labFormTitle.Name = "labFormTitle";
            this.labFormTitle.Size = new System.Drawing.Size(287, 48);
            this.labFormTitle.TabIndex = 1005;
            this.labFormTitle.Text = "Personal Details";
            this.labFormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Male_512;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(859, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 44);
            this.btnClose.TabIndex = 1006;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucPersonInfoInPersonalDetailsForm
            // 
            this.ucPersonInfoInPersonalDetailsForm.Location = new System.Drawing.Point(12, 92);
            this.ucPersonInfoInPersonalDetailsForm.Name = "ucPersonInfoInPersonalDetailsForm";
            this.ucPersonInfoInPersonalDetailsForm.NationalNo = null;
            this.ucPersonInfoInPersonalDetailsForm.PersonID = 0;
            this.ucPersonInfoInPersonalDetailsForm.Size = new System.Drawing.Size(978, 382);
            this.ucPersonInfoInPersonalDetailsForm.TabIndex = 1007;
            // 
            // frmPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 546);
            this.Controls.Add(this.ucPersonInfoInPersonalDetailsForm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labFormTitle;
        private ucPersonInfo ucPersonInfoInPersonalDetailsForm;
    }
}