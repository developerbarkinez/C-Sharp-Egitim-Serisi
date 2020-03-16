using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basamaklarınaayır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox1.Text);
                if(99 <a&&a<1000)
                {
                    int b = a / (100);
                    int c = (a % 100) / 10;
                    int d = a % 10;
                    textBox2.Text = b.ToString();
                    textBox3.Text = c.ToString();
                    textBox4.Text = d.ToString();
                }
                else { MessageBox.Show("lütfen 3 basamaklı bir sayı giriniz"); }
            }
            catch { MessageBox.Show("lütfen üç basamaklı sayı giriniz."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox1.Text);
                if (99<a && a<1000)
                {
                    int b = a / 100;
                    int c = (a % 100) / 10;
                    int d = a % 10;
                    textBox2.Text = b.ToString();
                    textBox3.Text = c.ToString();
                    textBox4.Text = d.ToString();
                    if ((b + c + d) % 2 == 0) MessageBox.Show("çift");
                    else MessageBox.Show("tek");
                }
                else { MessageBox.Show("3 basamaklı sayı giriniz"); }
            }
            catch { MessageBox.Show("3 basamaklı sayı giriniz"); }
        }
    }
}
