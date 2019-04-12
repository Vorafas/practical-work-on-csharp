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
    public partial class Form3 : Form
    {
        int strings, columns;

        int n = 0;
        Random rnd = new Random();
        int[][] array;
        public Form3()
        {
            InitializeComponent();
        }

        private void одномерныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void двумерныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void рванныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetStrings();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetStrings();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetColumns();
            }
        }

        private void GetColumns() { //Испаравить ошибку!!!!!!!!!!!!!!!!!
            if (n < strings - 1)
            {
                if (!(int.TryParse(textBox2.Text, out columns)) || Convert.ToInt32(columns) <= 0)
                {
                    DialogResult dr = MessageBox.Show("Введите корректное число!",
                      "Предупреждение", MessageBoxButtons.OK);
                    textBox2.Focus();
                    textBox2.Clear();
                }
                else
                {
                    array[n] = new int[columns];
                    for (int i = 0; i < columns; i++)
                    {
                        array[n][i] = rnd.Next(10, 99);
                    }
                    n++;
                    textBox2.Focus();
                    textBox2.Clear();
                }
            }
            else {
                textBox2.Text = "";
                textBox2.Enabled = false;
                button2.Enabled = false;
                GetArray(array);
            }
        } //Испаравить ошибку!!!!!!!!!!!!!!!!!

        private void GetArray(int[][] array) {
            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array[i].Length; j++) {
                    textBox3.Text += $" {array[i][j]}  ";
                }
                textBox3.Text += Environment.NewLine;
            }
        }

        private void GetStrings() {
            if (!(int.TryParse(textBox1.Text, out strings)) || Convert.ToInt32(strings) <= 0)
            {
                DialogResult dr = MessageBox.Show("Введите корректное число!",
                      "Предупреждение", MessageBoxButtons.OK);
                textBox1.Focus();
                textBox1.Clear();
            }
            else {
                array = new int[strings][];
                textBox1.Text = $"Количество строк: {strings}";
                textBox1.Enabled = false;
                button1.Enabled = false;
                textBox2.Enabled = true;
                textBox2.Focus();
                button2.Enabled = true;
            }
        }
    }
}
