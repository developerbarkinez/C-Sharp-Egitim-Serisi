using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamben = 0;
        int toplamben1 = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);
            toplamben = toplamben + a + b;
            label2.Text = a.ToString();
            label3.Text = b.ToString();
            label5.Text = toplamben.ToString();
            label17.Text = toplamben.ToString();
            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\1.jpg";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\2.jpg";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\3.jpg";

            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\4.jpg";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\5.jpg";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\6.jpg";
            }
            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\1.jpg";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\2.jpg";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\3.jpg";

            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\4.jpg";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\5.jpg";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\6.jpg";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);
            toplamben1 = toplamben1 + c + d;
            label11.Text = c.ToString();
            label9.Text = d.ToString();
            label7.Text = toplamben1.ToString();
            label15.Text = toplamben1.ToString();
            if (c == 1)
            {
                pictureBox3.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\1.jpg";
            }
            if (c == 2)
            {
                pictureBox3.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\2.jpg";
            }
            if (c == 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\3.png";

            }
            if (c == 4)
            {
                pictureBox3.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\4.png";
            }
            if (c == 5)
            {
                pictureBox3.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\5.jpg";
            }
            if (c == 6)
            {
                pictureBox3.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\6.jpg";
            }
            if (d == 1)
            {
                pictureBox4.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\1.jpg";
            }
            if (d == 2)
            {
                pictureBox4.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\2.jpg";
            }
            if (d == 3)
            {
                pictureBox4.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\3.png";

            }
            if (d == 4)
            {
                pictureBox4.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\4.png";
            }
            if (d == 5)
            {
                pictureBox4.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\5.jpg";
            }
            if (d == 6)
            {
                pictureBox4.ImageLocation = "C:\\Users\\barkines\\Desktop\\zar\\6.jpg";
            }
            if (toplamben > 100 && toplamben > toplamben1)
            {
                label13.Text = "Kazanan Sizsiniz Tebrikler!";
            }
            if (toplamben1 > 100 && toplamben1 > toplamben)
            {
                label13.Text = "Kazanan Bilgisayar üzgünüz!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
