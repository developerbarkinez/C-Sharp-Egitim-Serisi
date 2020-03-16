using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int cevap = 1881;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "İleri";
            soruno++;
            label1.Text = "Soru No:"+soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılında doğmuştur?";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1883";
                button4.Text = "1882";
                button5.Text = "1884";
                label5.Visible = false;
                label3.Text ="Dogru cevap"+Convert.ToString(cevap);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = button1.Text;
            label5.Visible = true;
            
            if (label5.Text == label6.Text)
            {
                MessageBox.Show("Verdiğiniz cevap doğru");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = button3.Text;
            label5.Visible = true;

            if (label5.Text == label6.Text)
            {
                MessageBox.Show("Verdiğiniz cevap doğru");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = button2.Text;
            label5.Visible = true;

            if (label5.Text == label6.Text)
            {
                MessageBox.Show("Verdiğiniz cevap doğru");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = button5.Text;
            label5.Visible = true;

            if (label5.Text == label6.Text)
            {
                MessageBox.Show("Verdiğiniz cevap doğru");
            }
        }
    }

}
