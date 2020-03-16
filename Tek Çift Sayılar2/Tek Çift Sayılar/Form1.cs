using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tek_Çift_Sayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try {
            long i, a, b, top;
                top = 0;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                if (radioButton1.Checked == true)
                {
                    for (i = a; i <= b; i++)

                        top = top + i;
                    textBox3.Text = Convert.ToString(top);
                }


                else if (radioButton2.Checked == true)
                {
                    for (i = a; i <= b; i++)


                        if (i % 2 == 0)

                            top = top + i;
                    textBox4.Text = Convert.ToString(top);
                }
                else if (radioButton3.Checked == true)
                {
                    for (i = a; i <= b; i++)


                        if (i % 2 == 1)

                            top = top + i;
                    textBox5.Text = Convert.ToString(top);
                }
                }



                catch (Exception) { MessageBox.Show("eksik veri"); }






            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } }