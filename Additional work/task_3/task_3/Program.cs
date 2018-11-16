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
            int[,] days = new int[365, 1];
            int[] winds = new int[8] {0,0,0,0,0,0,0,0};
            int i, j;
            int max = 8;
            int min;
            for (i = 0, min = 1; i < 365; min++, i++) {
                for (j = 0; j < 1; j++) {
                    if (min > max)
                        min = 1;
                    days[i, j] = min;
                    --min;
                    winds[min] += 1;
                    ++min;
                    //Console.WriteLine($"days[{i}, {j}] = {days[i, j]}");
                }
            }
            for (int c = 0; c < winds.Length; c++)
            {
                switch (c) {
                    case 0:
                        Console.WriteLine($"Северный = {winds[c]}");
                        break;
                    case 1:
                        Console.WriteLine($"Южный = {winds[c]}");
                        break;
                    case 2:
                        Console.WriteLine($"Восточный = {winds[c]}");
                        break;
                    case 3:
                        Console.WriteLine($"Западный = {winds[c]}");
                        break;
                    case 4:
                        Console.WriteLine($"Северо-западный = {winds[c]}");
                        break;
                    case 5:
                        Console.WriteLine($"Северо-восточный = {winds[c]}");
                        break;
                    case 6:
                        Console.WriteLine($"Юго-западный = {winds[c]}");
                        break;
                    default:
                        Console.WriteLine($"Юго-восточный = {winds[c]}");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
