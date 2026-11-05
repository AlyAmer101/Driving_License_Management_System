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
    public partial class Form3 : Form
    {

        public delegate void DataBackEventHundler(object sender, int PersonID);

        public event DataBackEventHundler DataBack;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSendDataBack_Click(object sender, EventArgs e)
        {
            int personId = int.Parse(textBox1.Text);

            DataBack?.Invoke(this, personId);

            this.Close();
        }
    }
}
