using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int next = 0;
            int summa = 0;
            next = Convert.ToInt32(Console.ReadLine());
            do {
                Console.Write("Для прекрашения ввода введите букву. Введите число: ");
                if ((next % 2) != 0) {
                    summa += next;
                }
            } while (int.TryParse(Console.ReadLine(), out next) && next > 0);
            Console.Write("Сумма нечётных чисел = {0}", summa);
            Console.ReadLine();
        }
    }
}
