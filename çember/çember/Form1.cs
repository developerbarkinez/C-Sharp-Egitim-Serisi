using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Random r = new Random();
            int x = r.Next(0, 450);
            int y = r.Next(0, 300);
            Graphics cember;
            cember = this.CreateGraphics();
            SolidBrush firca = new SolidBrush(Color.Turquoise);
            cember.FillEllipse(firca, x, y, 50, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
