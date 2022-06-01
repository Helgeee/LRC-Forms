using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z = Convert.ToDouble(textBox1.Text);
            double v = Convert.ToDouble(textBox2.Text);
            double max;
            if (z > v)
            {
                max = z;
                label4.Text = "Max: " + z;
            }
            else
            {
                max = v;
                label4.Text = "Max: " + v;
            }
            

        }
    }
}
