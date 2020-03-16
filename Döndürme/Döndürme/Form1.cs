using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döndürme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        float s0 = 0; float s1 = 180;
        float b0 = 0; float b1 = -180;
        
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics cember1,cember2;
            cember2 = this.CreateGraphics();
            cember1 = this.CreateGraphics();
            SolidBrush firca1 = new SolidBrush(Color.Black);
            cember1.FillPie(firca1, 100, 100, 500, 500, s0 , s1);
            SolidBrush firca2 = new SolidBrush(Color.Red);
            cember2.FillPie(firca2, 100, 100, 500, 500, b0 , b1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            s0 +=45;
            b0 += 45;


         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s0 -= 45;
            b0 -= 45;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }
    }
}
