using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int summa = 0;
            int next;
            for (next = 0; int.TryParse(Console.ReadLine(), out next);) {
                Console.Write("Для прекрашения ввода введите букву. Введите число: ");
                if ((next % 2) != 0) {
                    summa += next;
                }
            }
            Console.Write("Сумма нечётных чисел = {0}", summa);
            Console.ReadLine();
        }
    }
}
