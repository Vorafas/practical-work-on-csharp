using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            decimal n;
            while (!(decimal.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.Write("Нельзя вычислить. Введите n: ");
            }
            Console.Write("Введите m: ");
            decimal m;
            while (!(decimal.TryParse(Console.ReadLine(), out m)) || m <= 0)
            {
                Console.Write("Нельзя вычислить. Введите m: ");
            }
            var a = m < n--;
            Console.WriteLine("m < n--; {0}; n = {1}; m={2}", a, n, m);
            Console.ReadLine();
        }
    }
}
