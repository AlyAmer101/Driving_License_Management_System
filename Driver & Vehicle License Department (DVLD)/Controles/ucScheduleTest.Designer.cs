namespace DVLD.User_Controles
{
    partial class ucScheduleTest
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
            this.gbScheduleTest = new System.Windows.Forms.GroupBox();
            this.labDateValue = new System.Windows.Forms.Label();
            this.labSubTitle = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labFeesValue = new System.Windows.Forms.Label();
            this.labTrialValue = new System.Windows.Forms.Label();
            this.labNameValue = new System.Windows.Forms.Label();
            this.labClassValue = new System.Windows.Forms.Label();
            this.labLDLAppIDValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FormTitle = new System.Windows.Forms.Label();
            this.pbFormLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbScheduleTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbScheduleTest
            // 
            this.gbScheduleTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScheduleTest.Controls.Add(this.labDateValue);
            this.gbScheduleTest.Controls.Add(this.labSubTitle);
            this.gbScheduleTest.Controls.Add(this.dtpDate);
            this.gbScheduleTest.Controls.Add(this.labFeesValue);
            this.gbScheduleTest.Controls.Add(this.labTrialValue);
            this.gbScheduleTest.Controls.Add(this.labNameValue);
            this.gbScheduleTest.Controls.Add(this.labClassValue);
            this.gbScheduleTest.Controls.Add(this.labLDLAppIDValue);
            this.gbScheduleTest.Controls.Add(this.label6);
            this.gbScheduleTest.Controls.Add(this.label5);
            this.gbScheduleTest.Controls.Add(this.label4);
            this.gbScheduleTest.Controls.Add(this.label3);
            this.gbScheduleTest.Controls.Add(this.label2);
            this.gbScheduleTest.Controls.Add(this.label1);
            this.gbScheduleTest.Controls.Add(this.FormTitle);
            this.gbScheduleTest.Controls.Add(this.pbFormLogo);
            this.gbScheduleTest.Location = new System.Drawing.Point(3, 3);
            this.gbScheduleTest.Name = "gbScheduleTest";
            this.gbScheduleTest.Size = new System.Drawing.Size(600, 608);
            this.gbScheduleTest.TabIndex = 0;
            this.gbScheduleTest.TabStop = false;
            this.gbScheduleTest.Text = "ScheduleTest";
            // 
            // labDateValue
            // 
            this.labDateValue.AutoSize = true;
            this.labDateValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labDateValue.Location = new System.Drawing.Point(160, 504);
            this.labDateValue.Name = "labDateValue";
            this.labDateValue.Size = new System.Drawing.Size(25, 29);
            this.labDateValue.TabIndex = 16;
            this.labDateValue.Text = "0";
            this.labDateValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labDateValue.Visible = false;
            // 
            // labSubTitle
            // 
            this.labSubTitle.AutoSize = true;
            this.labSubTitle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSubTitle.ForeColor = System.Drawing.Color.Red;
            this.labSubTitle.Location = new System.Drawing.Point(83, 243);
            this.labSubTitle.Name = "labSubTitle";
            this.labSubTitle.Size = new System.Drawing.Size(400, 19);
            this.labSubTitle.TabIndex = 15;
            this.labSubTitle.Text = "Person already Taked the test, Appointment Locked";
            this.labSubTitle.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(160, 507);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(160, 26);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.CloseUp += new System.EventHandler(this.dtpDate_CloseUp);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.Enter += new System.EventHandler(this.dtpDate_Enter);
            // 
            // labFeesValue
            // 
            this.labFeesValue.AutoSize = true;
            this.labFeesValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labFeesValue.Location = new System.Drawing.Point(160, 552);
            this.labFeesValue.Name = "labFeesValue";
            this.labFeesValue.Size = new System.Drawing.Size(35, 29);
            this.labFeesValue.TabIndex = 13;
            this.labFeesValue.Text = "??";
            this.labFeesValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labTrialValue
            // 
            this.labTrialValue.AutoSize = true;
            this.labTrialValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labTrialValue.Location = new System.Drawing.Point(160, 457);
            this.labTrialValue.Name = "labTrialValue";
            this.labTrialValue.Size = new System.Drawing.Size(25, 29);
            this.labTrialValue.TabIndex = 11;
            this.labTrialValue.Text = "0";
            this.labTrialValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labTrialValue.Click += new System.EventHandler(this.labTrialValue_Click);
            // 
            // labNameValue
            // 
            this.labNameValue.AutoSize = true;
            this.labNameValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labNameValue.Location = new System.Drawing.Point(160, 401);
            this.labNameValue.Name = "labNameValue";
            this.labNameValue.Size = new System.Drawing.Size(35, 29);
            this.labNameValue.TabIndex = 10;
            this.labNameValue.Text = "??";
            // 
            // labClassValue
            // 
            this.labClassValue.AutoSize = true;
            this.labClassValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labClassValue.Location = new System.Drawing.Point(160, 355);
            this.labClassValue.Name = "labClassValue";
            this.labClassValue.Size = new System.Drawing.Size(35, 29);
            this.labClassValue.TabIndex = 9;
            this.labClassValue.Text = "??";
            // 
            // labLDLAppIDValue
            // 
            this.labLDLAppIDValue.AutoSize = true;
            this.labLDLAppIDValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labLDLAppIDValue.Location = new System.Drawing.Point(160, 299);
            this.labLDLAppIDValue.Name = "labLDLAppIDValue";
            this.labLDLAppIDValue.Size = new System.Drawing.Size(35, 29);
            this.labLDLAppIDValue.TabIndex = 8;
            this.labLDLAppIDValue.Text = "??";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(78, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fees:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(77, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(76, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trial:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(68, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "D. Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "LDL App ID:";
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.FormTitle.ForeColor = System.Drawing.Color.Red;
            this.FormTitle.Location = new System.Drawing.Point(160, 195);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(249, 48);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Schedule Test";
            // 
            // pbFormLogo
            // 
            this.pbFormLogo.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pbFormLogo.Location = new System.Drawing.Point(181, 25);
            this.pbFormLogo.Name = "pbFormLogo";
            this.pbFormLogo.Size = new System.Drawing.Size(207, 195);
            this.pbFormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFormLogo.TabIndex = 1;
            this.pbFormLogo.TabStop = false;
            // 
            // ucScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbScheduleTest);
            this.Name = "ucScheduleTest";
            this.Size = new System.Drawing.Size(606, 614);
            this.gbScheduleTest.ResumeLayout(false);
            this.gbScheduleTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScheduleTest;
        private System.Windows.Forms.Label FormTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFormLogo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labFeesValue;
        private System.Windows.Forms.Label labTrialValue;
        private System.Windows.Forms.Label labNameValue;
        private System.Windows.Forms.Label labClassValue;
        private System.Windows.Forms.Label labLDLAppIDValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSubTitle;
        private System.Windows.Forms.Label labDateValue;
    }
}
