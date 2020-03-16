using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(this.Width - 40);
            button1.Top = r.Next(this.Height - 40);
            Point p = new Point(r.Next(this.Width - 60), r.Next(this.Height - 55));
            button1.Location = p;

     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tebrikler");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
