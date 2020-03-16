using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Top += 15;
            this.Left += 15;
            this.Top -= 15;
            this.Left -= 15;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = s.ToString();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = s.ToString();
            s--;
            if (s == -1) s = 10;
            int c = s % 3;
            if (c == 0) this.BackColor = Color.Blue;
            else if (c == 1) this.BackColor = Color.Red;
            else if (c == 2) this.BackColor = Color.Yellow;
        }
    }
}
