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
    public partial class Form2 : Form
    {
        float _Result = 0;
        public Form2(float Result)
        {
            InitializeComponent();

            _Result = Result;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labResult.Text = _Result.ToString();
        }
    }
}
