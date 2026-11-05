namespace UserControles
{
    partial class ctrlCalculator
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.lbCurrentOperation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labResulte = new System.Windows.Forms.Label();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSubtrack = new System.Windows.Forms.RadioButton();
            this.rdDivision = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeOperaion = new System.Windows.Forms.Button();
            this.labCurrentOperation = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.gbOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(17, 22);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(79, 53);
            this.tb1.TabIndex = 0;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(179, 22);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(79, 53);
            this.tb2.TabIndex = 1;
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCurrentOperation
            // 
            this.lbCurrentOperation.AutoSize = true;
            this.lbCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentOperation.Location = new System.Drawing.Point(121, 28);
            this.lbCurrentOperation.Name = "lbCurrentOperation";
            this.lbCurrentOperation.Size = new System.Drawing.Size(0, 40);
            this.lbCurrentOperation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // labResulte
            // 
            this.labResulte.AutoSize = true;
            this.labResulte.BackColor = System.Drawing.SystemColors.Control;
            this.labResulte.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResulte.ForeColor = System.Drawing.Color.DarkGreen;
            this.labResulte.Location = new System.Drawing.Point(351, 24);
            this.labResulte.Name = "labResulte";
            this.labResulte.Size = new System.Drawing.Size(83, 46);
            this.labResulte.TabIndex = 4;
            this.labResulte.Text = "???";
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdd.Location = new System.Drawing.Point(19, 32);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(61, 41);
            this.rbAdd.TabIndex = 5;
            this.rbAdd.TabStop = true;
            this.rbAdd.Tag = "+";
            this.rbAdd.Text = "+";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbSubtrack
            // 
            this.rbSubtrack.AutoSize = true;
            this.rbSubtrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubtrack.Location = new System.Drawing.Point(109, 32);
            this.rbSubtrack.Name = "rbSubtrack";
            this.rbSubtrack.Size = new System.Drawing.Size(52, 41);
            this.rbSubtrack.TabIndex = 6;
            this.rbSubtrack.TabStop = true;
            this.rbSubtrack.Tag = "-";
            this.rbSubtrack.Text = "-";
            this.rbSubtrack.UseVisualStyleBackColor = true;
            // 
            // rdDivision
            // 
            this.rdDivision.AutoSize = true;
            this.rdDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDivision.Location = new System.Drawing.Point(298, 32);
            this.rdDivision.Name = "rdDivision";
            this.rdDivision.Size = new System.Drawing.Size(61, 41);
            this.rdDivision.TabIndex = 7;
            this.rdDivision.TabStop = true;
            this.rdDivision.Tag = "÷";
            this.rdDivision.Text = "÷";
            this.rdDivision.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiply.Location = new System.Drawing.Point(225, 32);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(57, 41);
            this.rbMultiply.TabIndex = 8;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Tag = "x";
            this.rbMultiply.Text = "x";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // gbOperation
            // 
            this.gbOperation.Controls.Add(this.rdDivision);
            this.gbOperation.Controls.Add(this.rbSubtrack);
            this.gbOperation.Controls.Add(this.rbMultiply);
            this.gbOperation.Controls.Add(this.rbAdd);
            this.gbOperation.Location = new System.Drawing.Point(479, 67);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(383, 87);
            this.gbOperation.TabIndex = 9;
            this.gbOperation.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose The Operation";
            // 
            // btnChangeOperaion
            // 
            this.btnChangeOperaion.Location = new System.Drawing.Point(565, 160);
            this.btnChangeOperaion.Name = "btnChangeOperaion";
            this.btnChangeOperaion.Size = new System.Drawing.Size(171, 58);
            this.btnChangeOperaion.TabIndex = 11;
            this.btnChangeOperaion.Text = "Change Operation";
            this.btnChangeOperaion.UseVisualStyleBackColor = true;
            this.btnChangeOperaion.Click += new System.EventHandler(this.btnChangeOperaion_Click);
            // 
            // labCurrentOperation
            // 
            this.labCurrentOperation.AutoSize = true;
            this.labCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentOperation.Location = new System.Drawing.Point(121, 28);
            this.labCurrentOperation.Name = "labCurrentOperation";
            this.labCurrentOperation.Size = new System.Drawing.Size(38, 40);
            this.labCurrentOperation.TabIndex = 12;
            this.labCurrentOperation.Tag = "+";
            this.labCurrentOperation.Text = "+";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(93, 160);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(121, 58);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // ctrlCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.labCurrentOperation);
            this.Controls.Add(this.btnChangeOperaion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbOperation);
            this.Controls.Add(this.labResulte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCurrentOperation);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "ctrlCalculator";
            this.Size = new System.Drawing.Size(874, 262);
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label lbCurrentOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labResulte;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbSubtrack;
        private System.Windows.Forms.RadioButton rdDivision;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeOperaion;
        private System.Windows.Forms.Label labCurrentOperation;
        private System.Windows.Forms.Button btnCalc;
    }
}
