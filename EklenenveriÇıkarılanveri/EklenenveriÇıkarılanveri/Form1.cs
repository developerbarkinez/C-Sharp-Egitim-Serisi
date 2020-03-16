using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EklenenveriÇıkarılanveri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            label4.Text = listBox1.Items.Count.ToString()+":Toplam veri indisi";

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text=Convert.ToString(listBox1.Items.IndexOf(textBox1.Text))+":Aranan veri indisi";
        }
    }
}
