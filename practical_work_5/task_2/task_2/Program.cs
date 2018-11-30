﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int strings, columns;
            Console.Write("Введите количество строк: ");
            while (!(int.TryParse(Console.ReadLine(), out strings)) || strings <= 0)
                Console.Write("Введите количество строк: ");
            Console.Write("Введите количество столбцов: ");
            while (!(int.TryParse(Console.ReadLine(), out columns)) || columns <= 0)
                Console.Write("Введите количество столбцов: ");
            int[,] table = new int[strings, columns];
            int i, j;
            for (i = 0; i < strings; i++) {
                for (j = 0; j < columns; j++) {
                    table[i, j] = rnd.Next(1, 100);
                    Console.WriteLine($"table[{i}, {j}] = {table[i, j]}");
                }
            }
            int n = (columns - 1) / 2;
            Console.WriteLine($"Четных элементов {n}");
            int col = columns + n; 
            int[,] arr = new int[strings, col];
            for (i = 0; i < strings; i++) {
                for (j = 0; j < col; j++) {
                    if (j >= columns)
                    {
                        arr[i, j] = rnd.Next(1, 100);
                    }
                    else {
                        arr[i, j] = table[i, j];
                    }
                    
                }
            }
            for (i = 0; i < strings; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.WriteLine($"arr[{i}, {j}] = {arr[i, j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
