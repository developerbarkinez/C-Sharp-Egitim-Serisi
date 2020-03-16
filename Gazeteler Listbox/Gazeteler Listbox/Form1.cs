using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazeteler_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (checkedListBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bir gazete seçin!");
            }
            else
            {
                foreach(string gazete in checkedListBox1.CheckedItems)
                {
                    listBox1.Items.Add(gazete);
                }
            }
        }
    }
}
