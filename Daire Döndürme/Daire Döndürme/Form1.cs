using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daire_Döndürme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
       


        private void button3_Click(object sender, EventArgs e)
        {
            a++;


            if (a % 4 == 1) {
                Pen p = new Pen(Color.White, 4);
                Graphics a = this.CreateGraphics();
                Rectangle rec = new Rectangle(100, 100, 330, 330);
                Brush b1 = new SolidBrush(Color.Green);
                Brush b2 = new SolidBrush(Color.Pink);
                Brush b3 = new SolidBrush(Color.Yellow);
                a.Clear(Form1.DefaultBackColor);
                a.DrawPie(p, rec, 45, 145);
                a.FillPie(b1, rec, 45, 145);
                a.DrawPie(p, rec, 45, 145);
                a.FillPie(b2, rec, 145, 145);
                a.DrawPie(p, rec, 145 + 145, 145);
                a.FillPie(b3, rec, 145 + 145, 145);
                
            }
            if (a % 4 == 2)
            {
                Pen p = new Pen(Color.White, 4);
                Graphics a = this.CreateGraphics();
                Rectangle rec = new Rectangle(100, 100, 330, 330);
                Brush b1 = new SolidBrush(Color.Green);
                Brush b2 = new SolidBrush(Color.Pink);
                Brush b3 = new SolidBrush(Color.Yellow);
                a.Clear(Form1.DefaultBackColor);
                a.DrawPie(p, rec, 90, 190);
                a.FillPie(b1, rec, 90, 190);
                a.DrawPie(p, rec, 90, 190);
                a.FillPie(b2, rec, 190, 190);
                a.DrawPie(p, rec, 190 + 190, 190);
                a.FillPie(b3, rec, 190 + 140, 180);

            }
            if (a % 4 == 3)
            {
                Pen p = new Pen(Color.White, 4);
                Graphics a = this.CreateGraphics();
                Rectangle rec = new Rectangle(100, 100, 330, 330);
                Brush b1 = new SolidBrush(Color.Green);
                Brush b2 = new SolidBrush(Color.Pink);
                Brush b3 = new SolidBrush(Color.Yellow);
                a.Clear(Form1.DefaultBackColor);
                a.DrawPie(p, rec, 145, 235);
                a.FillPie(b1, rec, 145, 235);
                a.DrawPie(p, rec, 135, 235);
                a.FillPie(b2, rec, 235, 235);
                a.DrawPie(p, rec, 235 + 235, 200);
                a.FillPie(b3, rec, 235 + 185, 200);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b++;

            if (b % 4 == 1)
            {
                Pen p = new Pen(Color.White, 4);
                Graphics g = this.CreateGraphics();
                Rectangle rec = new Rectangle(100, 100, 330, 330);
                Brush b1 = new SolidBrush(Color.Green);
                Brush b2 = new SolidBrush(Color.Pink);
                Brush b3 = new SolidBrush(Color.Yellow);
                g.Clear(Form1.DefaultBackColor);
                g.DrawPie(p, rec, -45, 100);
                g.FillPie(b1, rec, -45, 100);
                g.DrawPie(p, rec, 55, 100);
                g.FillPie(b2, rec, 55, 100);
                g.DrawPie(p, rec, 100 + 100, 100);
                g.FillPie(b3, rec, 100 + 100, 100);
            }
            if (b % 4 == 2)
            {
                Pen p = new Pen(Color.White, 4);
                Graphics g = this.CreateGraphics();
                Rectangle rec = new Rectangle(100, 100, 330, 330);
                Brush b1 = new SolidBrush(Color.Green);
                Brush b2 = new SolidBrush(Color.Pink);
                Brush b3 = new SolidBrush(Color.Yellow);
                g.Clear(Form1.DefaultBackColor);
                g.DrawPie(p, rec, -90,100);
                g.FillPie(b1, rec, -90,100);
                g.DrawPie(p, rec, -90, 10);
                g.FillPie(b2, rec, -90, 10);
                g.DrawPie(p, rec, 10 + 10, 10);
                g.FillPie(b3, rec, 55 + 55, 55);
            }
            if (b % 4 == 3)
            {
                Pen p = new Pen(Color.White, 4);
                Graphics g = this.CreateGraphics();
                Rectangle rec = new Rectangle(100, 100, 330, 330);
                Brush b1 = new SolidBrush(Color.Green);
                Brush b2 = new SolidBrush(Color.Pink);
                Brush b3 = new SolidBrush(Color.Yellow);
                g.Clear(Form1.DefaultBackColor);
                g.DrawPie(p, rec, -100, -50);
                g.FillPie(b1, rec, -100, -50);
                g.DrawPie(p, rec, -100, -50);
                g.FillPie(b2, rec, -135, -35);
                g.DrawPie(p, rec, -35 + -35, -35);
                g.FillPie(b3, rec,10 + 10, 10);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.White, 4);
            Graphics g = this.CreateGraphics();
            Rectangle rec = new Rectangle(100, 100, 330, 330);
            Brush b1 = new SolidBrush(Color.Green);
            Brush b2 = new SolidBrush(Color.Pink);
            Brush b3 = new SolidBrush(Color.Yellow);
            g.Clear(Form1.DefaultBackColor);
            g.DrawPie(p, rec, 0, 100);
            g.FillPie(b1, rec, 0, 100);
            g.DrawPie(p, rec, 100, 100);
            g.FillPie(b2, rec, 100, 100);
            g.DrawPie(p, rec, 100 + 100, 100);
            g.FillPie(b3, rec, 100 + 100, 100);
        }
    }
}
