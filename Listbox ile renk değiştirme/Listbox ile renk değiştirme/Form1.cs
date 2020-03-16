using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_ile_renk_değiştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==0)
            {
                this.BackColor = Color.Green;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                this.BackColor = Color.Blue;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
