using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        int[] arr;
        int number = 0;
        int currentNumber = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetNumber() {
            int number;
            if (!(int.TryParse(arraySize.Text, out number)) || Convert.ToInt32(number) <= 0)
            {
                DialogResult dr = MessageBox.Show("Введите корректное число!",
                      "Предупреждение", MessageBoxButtons.OK);
                arraySize.Clear();
            }
            if (number > 0)
            {
                arraySize.Text = $"Элементов в массиве: {number}";
                arraySize.Enabled = false;
                textBox1.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
                arr = new int[number];
                label4.Text = "Введите 1 элемент массива";
                textBox1.Focus();
            }
        }

        private void arraySize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                GetNumber();
            }
        }

        private void PrintArray(int[] arr, TextBox element, string text) {
            for (int i = 0; i < arr.Length; i++) {
                element.Text += $"array[{i}] = {arr[i]}" + Environment.NewLine;
            }
            element.Text += $"{text}" + Environment.NewLine;
            element.Text.Trim();
        }

        private void FillArray() {
            int i;
            if (number < arr.Length)
            {
                if (!(int.TryParse(textBox1.Text, out i)))
                {
                    DialogResult dr = MessageBox.Show("Введите корректное число!",
                      "Предупреждение", MessageBoxButtons.OK);
                    textBox1.Clear();
                    return;
                }
                if (i > 0)
                {
                    label4.Text = $"Введите {currentNumber++} элемент массива";
                    arr[number] = i;
                    number++;
                    textBox1.Clear();
                    if (number == arr.Length)
                    {
                        label4.Text = $"Введите {currentNumber = currentNumber - 2} элемент массива";
                        textBox1.Enabled = false;
                        button2.Enabled = false;
                        textBox1.Clear();
                        PrintArray(arr, textBox2, "");
                        redoneArray(arr);
                    }
                }
            }
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                FillArray();
            }
        }

        private void redoneArray(int[] arr) {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] % 2 == 0) {
                    counter++;
                }
            }
            int[] newArr = new int[arr.Length - counter];
            for (int i = 0, j = 0; i < arr.Length; i++) {
                if (arr[i] % 2 != 0) {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            if(counter == 0){
                PrintArray(newArr, textBox3, "Массив не изменен");
            }else if(arr.Length - counter == 0)
            {
                PrintArray(newArr, textBox3, "Массив пуст");
            }
            else {
                PrintArray(newArr, textBox3, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillArray();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(openFileDialog.FileName);
                streamWriter.WriteLine(textBox2.Text);
                streamWriter.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(textBox2.Text);
                streamWriter.Close();
                //textBox2.SaveFile(saveFileDialog.FileName);
            }
        }

        private void двумерныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Form2 newForm = new Form2();
            newForm.Show();            
        }

        private void одномерныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
