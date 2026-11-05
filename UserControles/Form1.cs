using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserControles
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

     
         private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form2(calculator2.Result);

            frm.Show();
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               (
                   $"{calculator2.TextBox1.ToString()} {calculator2.OperationChar.ToString()} {calculator2.TextBox2.ToString()} = {calculator2.Result.ToString()}"
               );
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();

            frm3.DataBack += Form3_DataBack;

            frm3.Show();
        }


        private void Form3_DataBack(object sender, int PersonID)
        {
            tbGetBackedData.Text = PersonID.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
