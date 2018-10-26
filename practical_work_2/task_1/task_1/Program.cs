using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int summ = 0;
            int next = 0;
            while ((int.TryParse(Console.ReadLine(), out next) && next > 0)) {
                Console.Write("Для прекрашения ввода введите букву. Введите число: ");
                if (next % 2 != 0) {
                    summ += next;
                }
            }
            Console.WriteLine("Сумма нечётных чисел = {0}", summ);
            Console.ReadLine();
        }
    }
}
