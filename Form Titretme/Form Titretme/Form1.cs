using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Titretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {
                this.Top += 5;
                this.Left += 5;
                this.Top -= 5;
                this.Left -= 5;
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
