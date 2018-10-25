using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a;
            while (!(double.TryParse(Console.ReadLine(), out a))) {
                Console.Write("Нельзя вычислить. Введите a: ");
            }
            double b;
            Console.Write("Введите b: ");
            while (!(double.TryParse(Console.ReadLine(), out b))) {
                Console.Write("Нельзя вычислить. Введите b: ");
            }
            double res = ((Math.Pow(a, 4) - (4 * Math.Pow(a, 3) * b) + (6 * Math.Pow(a, 2) * Math.Pow(b, 2)) - (4 * a * Math.Pow(b, 3)) + Math.Pow(b, 4)) - (Math.Pow(a, 4) - 4 * Math.Pow(a, 3) * b)) / ((6 * Math.Pow(a, 2) * Math.Pow(b, 2)) - (4 * a * Math.Pow(b, 3)) + Math.Pow(b, 4));
            Console.WriteLine("result = {0}; a = {1}; b = {2};", res, a, b);
            Console.ReadLine();
        }
    }
}
