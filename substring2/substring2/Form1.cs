using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace substring2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string yazi;
        private void Form1_Load(object sender, EventArgs e)
        {
            yazi = label1.Text;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string ilk = yazi.Substring(0, 2);
            yazi = yazi.Remove(0, 2);
            yazi += ilk;
            label1.Text = yazi;
        }
    }
}
