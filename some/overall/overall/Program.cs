﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overall
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int number;
            Console.WriteLine("1. Работа с одномерными массивыми. \n2. Работа с двумерными массивами. \n3. Работа с рваными массивами. \n4. Выход");
            do{
                number = Textq("Введите номер пункта: ");
                switch(number){
                    case 1:
                        Console.WriteLine($"{1}");
                        break;
                    case 2:
                        Console.WriteLine($"{2}");
                        break;
                    case 3:
                        Console.WriteLine($"{3}");
                        break;
                    case 4:
                        Console.WriteLine($"{4}");
                        break;
                    default:
                        flag = true;
                        break;
                }
            }while (!flag);
        }
        static int Textq(string text) {
            int number;
            Console.Write(text);
            while (!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write(text);
            }
            return number;
        }
    }
}
