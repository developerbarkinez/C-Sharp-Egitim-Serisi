using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tek_Çift_Sayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
            { 

            int i, a, b;
            
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            for (i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                   
                    listBox1.Items.Add(i.ToString());
                }
                else
                {
                    
                    listBox2.Items.Add(i.ToString());
                }
            }
           









        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for(int i=0;i<10;i++)
            {
                int s = r.Next(100);
                listBox3.Items.Add(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}