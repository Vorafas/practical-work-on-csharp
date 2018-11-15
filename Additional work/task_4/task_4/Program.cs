using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0) {
                Console.Write("Введите количество элементов массива: ");
            }
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = rnd.Next(-10, 10);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.WriteLine("Положительные элементы переставлены в начало массива, отрицательные - в конец");
            int[] arr = new int[n];
            for (int i = 0, a = numbers.Length - 1, b = 0; b < numbers.Length; i++, b++) {
                if (numbers[b] < 0)
                {
                    arr[i] = numbers[b];
                }
                else
                {
                    arr[a] = numbers[b];
                    i--;
                    a--;
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            Console.ReadLine();
        }
    }
}
