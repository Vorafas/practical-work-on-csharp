using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            decimal n;
            while(!(decimal.TryParse(Console.ReadLine(), out n)) || n <= 0){
                Console.Write("Нельзя вычислить. Введите n: ");
            }
            Console.Write("Введите m: ");
            int m;
            while(!(int.TryParse(Console.ReadLine(), out m)) || m <= 0){
                Console.Write("Нельзя вычислить. Введите m: ");
            }
            var a = n-- > (n/m++);
            Console.Write("n-- > n/m++; {0}; n = {1}; m = {2}", a, n, m);
            Console.ReadLine();
        }
    }
}
