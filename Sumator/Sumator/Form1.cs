using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal a = decimal.Parse(textBox1.Text);
                decimal b = decimal.Parse(textBox2.Text);
                decimal sum = a + b;
                textBoxSum.Text = sum.ToString();
            }
            catch(Exception)
            {
                textBoxSum.Text = "Error";
            }
        }
    }
}
