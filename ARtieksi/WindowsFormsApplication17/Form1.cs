using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        int sayi = 0;
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayi==0)
            {
                timer1.Start();
                sayi++;
            }
            else if  (sayi==1)
            {
                timer1.Stop();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Start();
            }
            Random a = new Random();
            progressBar1.Step = a.Next(1, 20);
            progressBar1.PerformStep();
        }
    }
}
