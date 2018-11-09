using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n))) {
                Console.Write("Введите число n: ");
            }
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++) {
                numbers[i] = rnd.Next(-10, 10);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.WriteLine("Положительные элементы переставлены в начало массива, отрицательные - в конец");
            var numbersList = numbers.ToList();
            int r;
            for (var i = 0; i < n; i++) {
                if (numbersList[i] < 0) {
                    r = numbersList[i];
                    numbersList.RemoveAt(i);
                    numbersList.Insert(0, r);
                }
            }
            var numbersArr = numbersList.ToArray();
            for (int i = 0; i < numbersArr.Length; i++) {
                Console.WriteLine($"n[{i}] = {numbersArr[i]}");
            }
            Console.ReadLine();
        }
    }
}
