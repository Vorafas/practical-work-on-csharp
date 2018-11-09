using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0) {
                Console.WriteLine("Введите число n: ");
            }
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++) {
                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine($"n[{n}] = {numbers[i]}");
            }
            var numbersList = numbers.ToList();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) {
                    Console.WriteLine($"Первый четный 'элемент в массиве {numbers[i]}");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
