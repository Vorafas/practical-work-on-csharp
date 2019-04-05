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
    public partial class Form2 : Form
    {
        int strings, columns, newStrings;
        int[,] array;
        public Form2()
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

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetNumber();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetColumn();
        }

        private void GetColumn()
        {
            if (!(int.TryParse(textBox2.Text, out columns)) || Convert.ToInt32(columns) <= 0)
            {
                DialogResult dr = MessageBox.Show("Введите корректное число!",
                      "Предупреждение", MessageBoxButtons.OK);
                textBox2.Clear();
            }
            if (columns > 0)
            {
                int[,] table = new int[strings, columns];
                textBox2.Text = $"Количество столбцов: {columns}";
                textBox2.Enabled = false;
                button2.Enabled = false;
                textBox4.Enabled = true;
                button3.Enabled = true;
                textBox4.Focus();
                GetArray(strings, columns, textBox3);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetColumn();
            }
        }

        private int[,] GetArray(int strings, int columns, TextBox element) {
            array = new int[strings, columns];
            Random rnd = new Random();
            for (int i = 0; i < strings; i++) {
                for (int j = 0; j < columns; j++) {
                    array[i, j] = rnd.Next(10, 99);
                    element.Text += $"{array[i, j]}      ";
                }
                element.Text += Environment.NewLine;
            }
            return array;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetNewSrings();
        }

        private void GetNewSrings()
        {
            if (!(int.TryParse(textBox4.Text, out newStrings)) || Convert.ToInt32(newStrings) <= 0)
            {
                DialogResult dr = MessageBox.Show("Введите корректное число!",
                      "Предупреждение", MessageBoxButtons.OK);
                textBox4.Clear();
            }
            if (newStrings > 0)
            {
                int str = newStrings + strings;
                int[,] newArr = new int[str, columns];
                textBox4.Text = $"Количество строк: {strings}";
                textBox4.Enabled = false;
                button3.Enabled = false;
                NewArray(array, newArr);
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetNewSrings();
            }
        }

        private void NewArray(int[,] array, int[,] newArr) {
            Random rnd = new Random();
            for (int i = 0; i < newArr.GetLength(0); i++) {
                for (int j = 0; j < newArr.GetLength(1); j++) {
                    if (i < array.GetLength(0))
                    {
                        newArr[i, j] = array[i, j];
                        textBox5.Text += $"{newArr[i, j]}      ";
                    }
                    else {
                        newArr[i, j] = rnd.Next(10, 99);
                        textBox5.Text += $"{newArr[i, j]}      ";
                    }
                }
                textBox5.Text += Environment.NewLine;
            }
        }

        private void GetNumber()
        {
            if (!(int.TryParse(textBox1.Text, out strings)) || Convert.ToInt32(strings) <= 0)
            {
                DialogResult dr = MessageBox.Show("Введите корректное число!",
                      "Предупреждение", MessageBoxButtons.OK);
                textBox1.Clear();
            }
            if (strings > 0)
            {
                textBox1.Text = $"Количество строк: {strings}";
                textBox1.Enabled = false;
                button1.Enabled = false;
                textBox2.Enabled = true;
                button2.Enabled = true;
                textBox2.Focus();
            }
        }
    }
}
