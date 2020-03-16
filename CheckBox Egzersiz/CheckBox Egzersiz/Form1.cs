using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double sonuc;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            sonuc = (a + b) * (1+c/100);
            label5.Text = sonuc.ToString();
            if (checkBox1.Checked == true)
            {
                sonuc = (a + b) * c - (a + b * c) * 0.05;
                label5.Text = sonuc.ToString();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
   
}
