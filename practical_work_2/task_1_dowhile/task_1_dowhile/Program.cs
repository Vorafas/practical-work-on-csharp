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
            int n = 10;
            int summ = 0;
            int k;
            int i = 0;
            do{
                Console.Write($"Введите {i+1}-й элемент: ");
                while (!(int.TryParse(Console.ReadLine(), out k))) {
                    Console.Write($"Введите {i+1}-й элемент: ");
                }   
                if(k % 2 != 0){
                    summ += k;
                }
                i++;
            }while(i < n);
            Console.WriteLine("Сумма нечётных чисел = {0}", summ);
            Console.ReadLine();
        }
    }
}
