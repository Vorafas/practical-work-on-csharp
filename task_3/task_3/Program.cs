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
            int max = 32;
            int k = 1;
            int t = 2;
            int x;
            Console.Write("Введите x: ");
            while (!(int.TryParse(Console.ReadLine(), out x)) || Ok(x) || Ok2(x))
            {
                Console.Write("Нельзя вычислить. Введите x: ");
            }
            int a = (x - 1);
            int b = (x - 2);
            for (int i = 2; i <= max; i = i * 2) {
                k = k + i;
                a *= (x - k);
            }
            for (int y = 2; y <= max; y = y * 2)
            {
                t = t + y;
                b *= (x - t);
            }
            int p = a / b;
            Console.Write($"P = {p}; a = {a}; b = {b}");
            Console.ReadLine();
        }
        public static bool Ok(int x)
        {
            bool ok = false;
            int s = 0;
            for (int i = 2; i <= 64; i = i * 2)
            {
                s = i - 1;
                if (x == s)
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }
        public static bool Ok2(int x)
        {
            bool ok = false;
            for (int i = 2; i <= 64; i = i * 2)
            {
                if (x == i)
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }
    }
}
