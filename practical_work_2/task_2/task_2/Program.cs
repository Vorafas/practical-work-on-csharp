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
            int i = 0;
            int max = 0;
            int n = 10;
            int k;
            while (i < 10) {
                Console.Write($"Введите {i + 1}-й элемент: ");
                while(!(int.TryParse(Console.ReadLine(), out k))){
                    Console.Write($"Введите {i + 1}-й элемент: ");
                }
                if(k == 0)
                    break;
                if(max < k){
                    max = k;
                }
                i++;
            }
            Console.Write("Максимальный элемент в последовательности = {0}", max);
            Console.ReadLine();
        }
    }
}
