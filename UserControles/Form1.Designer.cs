namespace UserControles
{
    partial class Form1
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
            this.btnSendResult = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.tbGetBackedData = new System.Windows.Forms.TextBox();
            this.calculator2 = new UserControles.ctrlCalculator();
            this.SuspendLayout();
            // 
            // btnSendResult
            // 
            this.btnSendResult.Location = new System.Drawing.Point(380, 274);
            this.btnSendResult.Name = "btnSendResult";
            this.btnSendResult.Size = new System.Drawing.Size(112, 61);
            this.btnSendResult.TabIndex = 4;
            this.btnSendResult.Text = "Send Result";
            this.btnSendResult.UseVisualStyleBackColor = true;
            this.btnSendResult.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(227, 274);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(112, 61);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "btn1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(33, 394);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(118, 54);
            this.btnForm3.TabIndex = 6;
            this.btnForm3.Text = "open form3";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // tbGetBackedData
            // 
            this.tbGetBackedData.Enabled = false;
            this.tbGetBackedData.Location = new System.Drawing.Point(202, 408);
            this.tbGetBackedData.Name = "tbGetBackedData";
            this.tbGetBackedData.Size = new System.Drawing.Size(200, 26);
            this.tbGetBackedData.TabIndex = 7;
            // 
            // calculator2
            // 
            this.calculator2.Location = new System.Drawing.Point(12, 12);
            this.calculator2.Name = "calculator2";
            this.calculator2.Size = new System.Drawing.Size(874, 262);
            this.calculator2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 702);
            this.Controls.Add(this.tbGetBackedData);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSendResult);
            this.Controls.Add(this.calculator2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlCalculator calculator2;
        private System.Windows.Forms.Button btnSendResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnForm3;
        private System.Windows.Forms.TextBox tbGetBackedData;
    }
}

