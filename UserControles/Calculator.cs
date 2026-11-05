using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControles
{
    public partial class ctrlCalculator : UserControl
    {
        public ctrlCalculator()
        {
            InitializeComponent();
        }

        public float Result { get{ return (float)Convert.ToDouble(labResulte.Text); } }
        public float TextBox1 { get{ return (float)Convert.ToDouble(tb1.Text); } }
        public float TextBox2 { get{ return (float)Convert.ToDouble(tb2.Text); } }
        public char OperationChar { get{ return Convert.ToChar(labCurrentOperation.Text); } }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            rbAdd.Checked = true;
            labCurrentOperation.Text = rbAdd.Tag.ToString();
        }

        enum enOperations { Add, Subtrack, Division, Multiply};

        enOperations CurrentOperation;
        private void btnChangeOperaion_Click(object sender, EventArgs e)
        {
            if (rbAdd.Checked)
            {
                CurrentOperation = enOperations.Add;
                labCurrentOperation.Text = rbAdd.Tag.ToString();
            }
            else if (rbSubtrack.Checked)
            {
                CurrentOperation = enOperations.Subtrack;
                labCurrentOperation.Text = rbSubtrack.Tag.ToString();
            }
            else if (rdDivision.Checked)
            {
                CurrentOperation = enOperations.Division;
                labCurrentOperation.Text = rdDivision.Tag.ToString();
            }
            else if (rbMultiply.Checked)
            {
                CurrentOperation = enOperations.Multiply;
                labCurrentOperation.Text = rbMultiply.Tag.ToString();
            }

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            switch (CurrentOperation)
            {

                case enOperations.Add:
                    labResulte.Text = (int.Parse(tb1.Text) + int.Parse(tb2.Text)).ToString();
                    break;

                case enOperations.Subtrack:
                    labResulte.Text = (int.Parse(tb1.Text) - int.Parse(tb2.Text)).ToString();
                    break;

                case enOperations.Division:
                    labResulte.Text = (float.Parse(tb1.Text) / float.Parse(tb2.Text)).ToString();
                    break;

                case enOperations.Multiply:
                    labResulte.Text = (int.Parse(tb1.Text) * int.Parse(tb2.Text)).ToString();
                    break;


            }

        }
    }
}
