namespace DVLD.User_Controles
{
    partial class ucLicenseInfoFilter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.tbLicenseIDValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucDriverLicenseInfo1 = new DVLD.User_Controles.ucDriverLicenseInfo();
            this.erValidateTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erValidateTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.tbLicenseIDValue);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(283, 23);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(538, 91);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // tbLicenseIDValue
            // 
            this.tbLicenseIDValue.Location = new System.Drawing.Point(162, 39);
            this.tbLicenseIDValue.Name = "tbLicenseIDValue";
            this.tbLicenseIDValue.Size = new System.Drawing.Size(218, 26);
            this.tbLicenseIDValue.TabIndex = 1;
            this.tbLicenseIDValue.TextChanged += new System.EventHandler(this.tbLicenseIDValue_TextChanged);
            this.tbLicenseIDValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbLicenseIDValue_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID:";
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(0, 106);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(1105, 397);
            this.ucDriverLicenseInfo1.TabIndex = 1;
            // 
            // erValidateTextBox
            // 
            this.erValidateTextBox.ContainerControl = this;
            // 
            // ucLicenseInfoFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Name = "ucLicenseInfoFilter";
            this.Size = new System.Drawing.Size(1108, 505);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erValidateTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox tbLicenseIDValue;
        private System.Windows.Forms.Label label1;
        private ucDriverLicenseInfo ucDriverLicenseInfo1;
        private System.Windows.Forms.ErrorProvider erValidateTextBox;
    }
}
