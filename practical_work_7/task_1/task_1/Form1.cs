using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void arraySize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                int number;
                if (!(int.TryParse(arraySize.Text, out number)))
                { 
                    arraySize.Clear();
                }
                if (number > 0) {
                    arraySize.Text = $"Элементов в массиве: {number}";
                    arraySize.Enabled = false;
                    textBox1.Enabled = true;
                    int[] arr = new int[number];
                }
            }
        }

    }
}
