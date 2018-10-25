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
            Console.Write("Введите x: ");
            double x;
            while (!(double.TryParse(Console.ReadLine(), out x))) {
                Console.Write("Нельзя вычислить. Введите x: ");
            }
            Console.Write("Введите y: ");
            double y;
            while (!(double.TryParse(Console.ReadLine(), out y))) {
                Console.Write("Нельзя вычислить. Введите y: ");
            }
            bool result;
            if ((x * x + y * y <= 1) && ((x <= 0) || (y <= 0))) {
                result = true;
            }
            else {
                result = false;
            }
            Console.WriteLine("{0}; x = {1}; y = {2}", result, x, y);
            Console.ReadLine();
        }
    }
}
