using System;
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
            Console.Write("Введите количество элементов массива: ");
            int n;
            int cnt = 0;
            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0) {
                Console.Write("Введите количество элементов массива: ");
            }
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = rnd.Next(-10, 10);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i] >= 0) {
                    --i;
                    if (numbers[i] < 0) {
                        cnt += 1;
                    }
                    ++i;
                }
                if (numbers[i] < 0)
                {
                    --i;
                    if (numbers[i] >= 0)
                    {
                        cnt += 1;
                    }
                    ++i;
                }
            }
            Console.Write($"Знак менялся: {cnt}");
            Console.ReadLine();
        }
    }
}
