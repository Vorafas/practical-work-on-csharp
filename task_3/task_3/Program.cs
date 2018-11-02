using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = (2 - 1);
            int x = 32;
            int k = 1;
            for (int i = 2; i <= x; i = i * 2) {
                k = k + i;
                p *= (2 - k);
                Console.WriteLine($"{i}");
            }
            Console.Write($"{p}");
            Console.ReadLine();
        }
    }
}
