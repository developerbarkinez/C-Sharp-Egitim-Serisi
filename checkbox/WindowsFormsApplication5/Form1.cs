using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox3.Text);
            double c = Convert.ToInt32(textBox2.Text);
            if (checkBox1.Checked == false)
            {
                double top = b * a * (1 + (c / 100));
                label4.Text = top.ToString();
            }
           
           
            else {
                double top = b * a * (1 + (c / 100)) *0.95;
                label4.Text = top.ToString();
            }
        }
    }
}
