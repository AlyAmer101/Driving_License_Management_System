namespace DVLD.Applications.Schedule_Tests.Vision_Test
{
    partial class frmScheduleTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleTest));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ucRetakeTestInfo1 = new DVLD.User_Controles.ucRetakeTestInfo();
            this.ucScheduleTest1 = new DVLD.User_Controles.ucScheduleTest();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(256, 862);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 1028;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(500, 777);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 37);
            this.btnSave.TabIndex = 1029;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucRetakeTestInfo1
            // 
            this.ucRetakeTestInfo1.Enabled = false;
            this.ucRetakeTestInfo1.LDLAppID = 0;
            this.ucRetakeTestInfo1.Location = new System.Drawing.Point(12, 610);
            this.ucRetakeTestInfo1.Name = "ucRetakeTestInfo1";
            this.ucRetakeTestInfo1.RetakeTestAppID = 0;
            this.ucRetakeTestInfo1.Size = new System.Drawing.Size(606, 145);
            this.ucRetakeTestInfo1.TabIndex = 1;
            this.ucRetakeTestInfo1.TestAppointmentID = 0;
            // 
            // ucScheduleTest1
            // 
            this.ucScheduleTest1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucScheduleTest1.IsFormLocked = false;
            this.ucScheduleTest1.Location = new System.Drawing.Point(2, -2);
            this.ucScheduleTest1.Name = "ucScheduleTest1";
            this.ucScheduleTest1.Size = new System.Drawing.Size(624, 840);
            this.ucScheduleTest1.TabIndex = 0;
            this.ucScheduleTest1.TestMode = DVLD.General_Classes.clsUtility.enVisionTestMode.Normal;
            this.ucScheduleTest1.Load += new System.EventHandler(this.ucVisionTest1_Load);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 912);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucRetakeTestInfo1);
            this.Controls.Add(this.ucScheduleTest1);
            this.Name = "frmScheduleTest";
            this.Text = "Add New Appointment";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controles.ucScheduleTest ucScheduleTest1;
        private User_Controles.ucRetakeTestInfo ucRetakeTestInfo1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}