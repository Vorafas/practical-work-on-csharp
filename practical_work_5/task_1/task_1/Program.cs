﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество элементов массива: ");
            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.Write("Введите количество элементов массива: ");
            }
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
            int a;
            Console.Write("Введите номер, с которого будут удалятся элементы: ");
            while (!(int.TryParse(Console.ReadLine(), out a)) || a < 0 || a >= n)
            {
                Console.Write("Введите номер, с которого будут удалятся элементы: ");
            }
            int b;
            if (a < n - 1)
            {
                Console.Write("Введите количество удаляемых элементов: ");
                while (!(int.TryParse(Console.ReadLine(), out b)) || b > (n - a) || b < 0)
                {
                    Console.Write("Введите количество удаляемых элементов: ");
                }
                int cnt = n - b;
                int[] arr = new int[cnt];
                for (int i = 0, c = 0; i < numbers.Length; i++, c++)
                {
                    if (i == a)
                    {
                        i = i + b;
                    }
                    if (i > numbers.Length - 1)
                    {
                        break;
                    }
                    arr[c] = numbers[i];
                }
                if (cnt != 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    Console.WriteLine($"arr[{i}] = {arr[i]}");
                }
                else {
                    Console.WriteLine("Увы, но МАССИВ ПУСТ!!!");
                }
            }
            else
            {
                n = n - 1;
                int[] arr = new int[n];
                for (int i = 0, d = 0; i < numbers.Length; i++, d++)
                {
                    if (i == a)
                    {
                        i++;
                    }
                    if (i > numbers.Length - 1)
                    {
                        break;
                    }
                    arr[d] = numbers[i];
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"arr[{i}] = {arr[i]}");
                }

            }
            Console.ReadLine();
        }
    }
}
