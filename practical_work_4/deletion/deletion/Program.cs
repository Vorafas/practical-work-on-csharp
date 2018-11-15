using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deletion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0) {
                Console.Write("Введите число n: ");
            }
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++) {
                numbers[i] = rnd.Next(0, 100);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.Write("Введите номер удаляемого элемента : ");
            int a;
            while (!(int.TryParse(Console.ReadLine(), out a)) || a < 0 || a >= n)
            {
                Console.Write("Введите номер удаляемого элемента : ");
            }
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
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            Console.ReadLine();
        }
    }
}
