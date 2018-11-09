using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
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
                numbers[i] = rnd.Next(-10, 10);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            int j;

            for (int i = 1; i < n; i++) { 
                for (j = n - 1; j >= i; j--) {
                    if (numbers[j] < numbers[j - 1])
                    {

                        int temp = numbers[j];

                        numbers[j] = numbers[j - 1];

                        numbers[j - 1] = temp;

                    }
                }
            }
            Console.WriteLine("Отсортированный массив");
            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.ReadLine();
        }
    }
}
