using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boyama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı = 0;
        int x1, x2, x3, y1, y2, y3;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            Graphics oyun1;
            oyun1 = this.CreateGraphics();
            sayı++;
            if (sayı%4 ==1)
            {
                 x1 = e.X;
                 x2 = e.Y;
                

            }
            if (sayı % 4 == 2)
            {
                 x2 = e.X;
                 y2 = e.Y;
                
            }
            if (sayı % 4 == 3)
            {
                 x3 = e.X;
                 y3 = e.Y;

                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                Point p3 = new Point(x3, y3);
                Point[] noktalar = { p1, p2, p3 };

                Pen p = new Pen(Color.Red, 3);
                oyun1.DrawPolygon(p, noktalar);

            }
            if (sayı % 4 == 0)
            {
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                Point p3 = new Point(x3, y3);
                Point[] noktalar = { p1, p2, p3 };

                SolidBrush f = new SolidBrush(Color.Blue);
                oyun1.FillPolygon(f, noktalar);
            }
        }
    }
}
