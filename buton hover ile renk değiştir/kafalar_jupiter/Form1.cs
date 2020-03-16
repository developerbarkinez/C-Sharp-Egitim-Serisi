using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafalar_jupiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor =Color.Red;
            MessageBox.Show("Hile yapma! :D");
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            MessageBox.Show("Yandınız.");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            MessageBox.Show("Yandınız.");
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hile yapma! :D");
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandınız!");
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {

            MessageBox.Show("Hile yapma");
        }
    }
}
