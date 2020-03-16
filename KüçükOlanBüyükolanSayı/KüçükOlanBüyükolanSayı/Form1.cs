using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KüçükOlanBüyükolanSayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random sayi = new Random();
            int s;
            for(int i = 0; i < 10; i++) {

                s = sayi.Next(100);
                listBox1.Items.Add(s);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Bir sayi giriniz");
            }


            else { 
               int sayii = Convert.ToInt32(textBox1.Text);
               if (radioButton1.Checked == true)
            {
                foreach (int i in listBox1.Items)
                {
                        if (i > sayii)
                        {
                            listBox2.Items.Add(i);
                        }
                   
                }
                    if (radioButton2.Checked == true)
                    {
                        foreach(int i in listBox1.Items)
                        {
                            if (i < sayii)
                            {
                                listBox2.Items.Add(i);
                            }
                        }
                    }
                }
            }
        }

        }
    }

