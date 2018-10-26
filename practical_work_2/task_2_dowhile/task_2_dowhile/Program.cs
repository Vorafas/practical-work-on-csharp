using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int max = 0;
            int next;
            next = Convert.ToInt32(Console.ReadLine());
            do {
                Console.Write("Для прекрашения ввода введите букву или 0. Введите число: ");
                if (max < next) {
                    max = next;
                }
            } while(int.TryParse(Console.ReadLine(), out next) && next > 0);
            Console.Write("Максимальный элемент в последовательности = {0}", max);
            Console.ReadLine();
        }
    }
}
