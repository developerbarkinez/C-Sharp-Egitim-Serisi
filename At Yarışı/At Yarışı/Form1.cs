using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatinsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatıngenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;
            
            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);

            int bitisuzakligi = label11.Left;
            int bitisuzakliği2 = label12.Left;
            int bitisuzakligi3 = label13.Left;
            if (birinciatıngenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                label16.Text="AT1";
            }
            else if (ikinciatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                label12.Text = "AT2";
            }   
            else if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                label13.Text = "AT3";
            }
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label17.Text = "1 numaralı at yarışı önde götürüyor";

            }
            else if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label17.Text = "2 numaralı at yarışı önde götürüyor";
            }
            else if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left)
            {
                label17.Text = "3 numaralı at yarışı önde götürüyor";
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int birinciathiz, ikinciathiz, ucuncuathiz;
            birinciathiz = Convert.ToInt32(label8.Text);
            ikinciathiz = Convert.ToInt32(label9.Text);
            ucuncuathiz = Convert.ToInt32(label10.Text);
            birinciathiz += 1;
            ikinciathiz += 1;
            ucuncuathiz += 1;
            label8.Text = birinciathiz.ToString();
            label9.Text = ikinciathiz.ToString();
            label10.Text = ucuncuathiz.ToString();
            if (pictureBox1.Left == label11.Left)
            {
                label8.Text = "Bitti";
            }
            else if (pictureBox2.Left == label12.Left)
            {
                label9.Text = "Bitti";
            }
            else if (pictureBox3.Left == label13.Left)
            {
                label9.Text = "Bitti";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatinsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;
        }
    }
}
