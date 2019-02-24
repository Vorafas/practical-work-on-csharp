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
                    arr = new int[number];
                    label4.Text = "Введите 1 элемент массива";
                    textBox1.Focus();
                }
            }
        }

        private void PrintArray(int[] arr, TextBox element) {
            for (int i = 0; i < arr.Length; i++) {
                element.Text += $"array[{i}] = {arr[i]}" + Environment.NewLine;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int i;
            if (e.KeyCode == Keys.Enter) {
                if (number < arr.Length)
                {
                    if (!(int.TryParse(textBox1.Text, out i)))
                    {
                        textBox1.Clear();
                        return;
                    }
                    if(i > 0)
                    {
                        label4.Text = $"Введите {currentNumber++} элемент массива";
                        arr[number] = i;
                        number++;
                        textBox1.Clear();
                        if (number == arr.Length) {
                            label4.Text = $"Введите {currentNumber = currentNumber - 2} элемент массива";
                            textBox1.Enabled = false;
                            textBox1.Clear();
                            PrintArray(arr, textBox2);
                            redoneArray(arr);
                        }
                    }
                }
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
            PrintArray(newArr, textBox3);
        }
    }
}
