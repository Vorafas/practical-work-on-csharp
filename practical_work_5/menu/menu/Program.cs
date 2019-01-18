using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
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
            for (int i = 0; i < strings; i++) {
                Console.Write("Введите количество столбцов: ");
                while (!(int.TryParse(Console.ReadLine(), out columns)) || columns <= 0)
                {
                    Console.Write("Введите количество столбцов: ");
                }
                arr[i] = new int[columns];
                for (int j = 0; j < columns; j++) {
                    arr[i][j] = rnd.Next(0, 10);
                }
            }
            for (int i = 0; i < strings; i++) {
                for (int j = 0; j < arr[i].Length; j++) {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            int addStr;
            Console.Write("Введите количество добавляемых строк: ");
            while (!(int.TryParse(Console.ReadLine(), out addStr)) || addStr < 0)
            {
                Console.Write("Введите количество добавляемых строк: ");
            }
            int number;
            int counter = 0;
            Console.Write("С какой строки добавить? ");
            while (!(int.TryParse(Console.ReadLine(), out number)) || number <= 0 || number > strings)
            {
                Console.Write("С какой строки добавить? ");
            }
            int newStrings = strings + addStr;
            int[][] newArr = new int[newStrings][];
            for (int i = 0, a = 0;  i < newStrings; i++) {
                if (i >= number && i <= (newStrings - (newStrings - addStr)))
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
                    counter = 0;
                    for (int j = 0; j < arr[a].Length; j++)
                        counter += 1;
                    newArr[i] = new int[counter];
                    for (int j = 0; j < counter; j++) {
                        newArr[i][j] = arr[a][j];
                    }
                    a++;
                }
                
            }
            for (int i = 0; i < strings; i++)
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

// найти ограничитель в строке 55