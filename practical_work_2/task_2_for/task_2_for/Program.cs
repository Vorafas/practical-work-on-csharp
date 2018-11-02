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
            int max = 0,
                n = 10,
                k;
            for (int i = 0; i < n; i++){
                Console.Write($"Введите {i + 1}-й элемент: ");
                while(!(int.TryParse(Console.ReadLine(), out k))){
                    Console.Write($"Введите {i + 1}-й элемент: ");
                }
                if(k == 0)
                    break;
                if(max < k){
                    max = k;
                }
            }
            Console.Write("Максимальный элемент в последовательности = {0}", max);
            Console.ReadLine();
        }
    }
}
