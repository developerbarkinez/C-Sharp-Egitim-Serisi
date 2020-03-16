using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çemberdöndür
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float s0 = 90;
        float b0 = 90;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics cember1, cember2;
            cember1 = this.CreateGraphics();
            SolidBrush firca = new SolidBrush(Color.Black);
            cember1.FillPie(firca, 100, 100, 400, 400, s0, 180);

            cember2 = this.CreateGraphics();
            SolidBrush firca2 = new SolidBrush(Color.White);
            cember1.FillPie(firca2, 100, 100, 400, 400, b0, -180);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s0 -= 45;
            b0 -=45;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s0 += 45;
            b0 += 45;
        }
    }
}
