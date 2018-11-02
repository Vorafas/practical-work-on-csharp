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
            int i = 0,
                max = 0,
                n = 10,
                k;
            do{
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
            }while(i < n);
            Console.Write("Максимальный элемент в последовательности = {0}", max);
            Console.ReadLine();
        }
    }
}
