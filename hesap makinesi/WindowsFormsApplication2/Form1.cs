using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox3.Text);
            label2.Text = (a + b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int c, d;
            c = Convert.ToInt32(textBox4.Text);
            d = Convert.ToInt32(textBox8.Text);
            label6.Text = (c - d).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c, d;
            c = Convert.ToInt32(textBox5.Text);
            d = Convert.ToInt32(textBox9.Text);
            label7.Text = (c * d).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double c, d;
            c = Convert.ToInt32(textBox6.Text);
            d = Convert.ToInt32(textBox10.Text);
            if (d == 0)
                MessageBox.Show("Payda Sıfır olamaz");
            else
                label8.Text = (c / d).ToString();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox8.Clear();
            textBox5.Clear();
            textBox9.Clear();
            textBox6.Clear();
            textBox10.Clear();
        }
    }
}
