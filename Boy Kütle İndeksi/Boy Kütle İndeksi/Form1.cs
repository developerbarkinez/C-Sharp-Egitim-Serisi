using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boy_Kütle_İndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b, k, bmi;
            b = Convert.ToInt32(textBox1.Text);
            k = Convert.ToInt32(textBox2.Text);
            bmi = (k / b * b);
            textBox3.Text = Convert.ToString(bmi);
            if (bmi < 18.5)
            {
                textBox4.Text = "Zayıf";
            }
            else if (18.5 < bmi || bmi > 25)
            {
                textBox4.Text = "Normal";
            }
            else if (25 < bmi || bmi > 30)
            {
                textBox4.Text = "Kilolu";
            }
            else if (30 > bmi)
            {
                textBox4.Text = "Obez";
            }   
            
        }
    }
}
