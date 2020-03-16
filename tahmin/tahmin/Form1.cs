using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(0, 100);

            int b = Convert.ToInt32(textBox1.Text);
            if (b > 100)
            {
                MessageBox.Show("0-100 Arası bir değer giriniz...");
            }
            else
            {

               
                if (b == a)
                {
                    MessageBox.Show("Helal be ");
                }
                if (b > a)
                {
                    MessageBox.Show("Çok gititn");
                }
                else
                {
                    MessageBox.Show("Yüksel");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
