﻿using System;
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
            Console.Write("Введите а: ");
            int a;
            while (!(int.TryParse(Console.ReadLine(), out a)) || a <= 0) {
                Console.WriteLine("Нельзя вычислить. Введите a: ");
            }
            Console.Write("Введите b: ");
            float b;
            while (!(float.TryParse(Console.ReadLine(), out b)) || b <= 0) {
                Console.WriteLine("Нельзя вычислить. Введите b: ");
            }
            var result = (((Math.Pow(a, 4) - 4 * (Math.Pow(a, 3) * b + 6 * (Math.Pow(a, 2) * (Math.Pow(b, 2) - 4 * a * Math.Pow(b, 3) + Math.Pow(b, 4))))) - 
                ((Math.Pow(a, 4)) - (4 * Math.Pow(a, 3) * b))) / ((6 * Math.Pow(a, 2) * Math.Pow(b, 2)) - (4 * a * Math.Pow(a, 3)) + Math.Pow(b, 4)));
            Console.Write("result = {0}", result);
            Console.ReadLine();
        }
    }
}
