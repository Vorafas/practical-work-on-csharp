using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x;
            while (!(double.TryParse(Console.ReadLine(), out x))) {
                Console.Write("Нельзя вычислить. Введите x: ");
            }
            double a = 1 + x * (Math.Pow(Math.Cos(x), 2)) + (Math.Pow(Math.Sin(x), 3));
            Console.WriteLine("1 + xcos^2(x) + sin^3(x) = {0}; x = {1}", a, x);
            Console.ReadLine();
        }
    }
}
