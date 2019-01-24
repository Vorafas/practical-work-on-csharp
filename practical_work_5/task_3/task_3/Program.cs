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
            int strings;
            int columns;
            Console.Write("Введите количество строк: ");
            while (!(int.TryParse(Console.ReadLine(), out strings)) || strings <= 0)
            {
                Console.Write("Введите количество строк: ");
            }
            Random rnd = new Random();
            int[][] arr = new int[strings][];
            for (int i = 0; i < strings; i++)
            {
                Console.Write("Введите количество столбцов: ");
                while (!(int.TryParse(Console.ReadLine(), out columns)) || columns <= 0)
                {
                    Console.Write("Введите количество столбцов: ");
                }
                arr[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    arr[i][j] = rnd.Next(0, 10);
                }
            }
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            int newStrings = strings + 1;
            int[][] newArr = new int[newStrings][];
            for (int i = 0; i < newStrings; i++)
            {
                if (i == newStrings - 1)
                {
                    Console.Write("Введите количество столбцов: ");
                    while (!(int.TryParse(Console.ReadLine(), out columns)) || columns <= 0)
                    {
                        Console.Write("Введите количество столбцов: ");
                    }
                    newArr[i] = new int[columns];
                    for (int j = 0; j < columns; j++)
                    {
                        newArr[i][j] = rnd.Next(0, 10);
                    }
                }
                else
                {
                    int fcounter = 0;
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        fcounter += 1;
                    }
                    newArr[i] = new int[fcounter];
                    for (int j = 0; j < fcounter; j++)
                    {
                        newArr[i][j] = arr[i][j];
                    }
                }
            }
            for (int i = 0; i < newStrings; i++)
            {
                for (int j = 0; j < newArr[i].Length; j++)
                {
                    Console.Write(newArr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
