using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text=="1") {
                textBox2.Text = "Ocak";
            }
           else if (textBox1.Text == "2")
            {
                textBox2.Text = "Şubat";
            }
           else if (textBox1.Text == "3")
            {
                textBox2.Text = "Mart";
            }
            else if (textBox1.Text == "4")
            {
                textBox2.Text = "Nisan";
            }
           else if (textBox1.Text == "5")
            {
                textBox2.Text = "Mayıs";
            }
          else  if (textBox1.Text == "6")
            {
                textBox2.Text = "Haziran";
            }
           else if (textBox1.Text == "7")
            {
                textBox2.Text = "Temmuz";
            }
            else if (textBox1.Text == "8")
            {
                textBox2.Text = "Agustos";
            }
            else if (textBox1.Text == "9")
            {
                textBox2.Text = "Eylül";
            }
            else if (textBox1.Text == "10")
            {
                textBox2.Text = "Ekim";
            }
            else if (textBox1.Text == "11")
            {
                textBox2.Text = "Kasım";
            }
            else if (textBox1.Text == "12")
            {
                textBox2.Text = "Aralık";
            }


        }
    }
}
