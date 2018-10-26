using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int max = 0;
            int next;
            int s;
            for (s = 0; (int.TryParse(Console.ReadLine(), out next)) && next > 0;) {
                Console.Write("Для прекрашения ввода введите букву или 0. Введите число: ");
                if (max < next)
                {
                    max = next;
                }
            }
            Console.Write("Максимальный элемент в последовательности = {0}", max);
            Console.ReadLine();
        }
    }
}
