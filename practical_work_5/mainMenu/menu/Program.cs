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
            bool flag = false;
            int number;
            Console.WriteLine(@"1. Удалить N элементов, начиная с номера K.
2. Добавить столбцы после каждого четного столбца матрицы.
3. Добавить строку в конец массива.
4. Выход.");
            do {
                Console.WriteLine();
                do
                {
                    Console.Write("Введите номер пункта : ");
                } while (!(int.TryParse(Console.ReadLine(), out number)) || number <= 0 || number > 4);
                switch (number) {
                    case 1:
                        GetOnedimensionalArray();
                        break;
                    case 2:
                        GetTwodimensionalArray();
                        break;
                    case 3:
                        GetBrokenArray();
                        break;
                    case 4:
                        flag = true;
                        break;
                }
            } while (!flag);
        }
        static void GetOnedimensionalArray() // Функция, которая удаляет N элементов, начиная с номера K.
        { 
            int n;
            Console.Write("Введите количество элементов массива: ");
            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.Write("Введите количество элементов массива: ");
            }
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
            int a;
            Console.Write("Введите номер, с которого будут удалятся элементы: ");
            while (!(int.TryParse(Console.ReadLine(), out a)) || a < 0 || a >= n)
            {
                Console.Write("Введите номер, с которого будут удалятся элементы: ");
            }
            int b;
            if (a < n - 1)
            {
                Console.Write("Введите количество удаляемых элементов: ");
                while (!(int.TryParse(Console.ReadLine(), out b)) || b > (n - a) || b < 0)
                {
                    Console.Write("Введите количество удаляемых элементов: ");
                }
                int cnt = n - b;
                int[] arr = new int[cnt];
                for (int i = 0, c = 0; i < numbers.Length; i++, c++)
                {
                    if (i == a)
                    {
                        i = i + b;
                    }
                    if (i > numbers.Length - 1)
                    {
                        break;
                    }
                    arr[c] = numbers[i];
                }
                if (cnt != 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                        Console.WriteLine($"arr[{i}] = {arr[i]}");
                }
                else
                {
                    Console.WriteLine("Увы, но МАССИВ ПУСТ!!!");
                }
            }
            else
            {
                n = n - 1;
                int[] arr = new int[n];
                for (int i = 0, d = 0; i < numbers.Length; i++, d++)
                {
                    if (i == a)
                    {
                        i++;
                    }
                    if (i > numbers.Length - 1)
                    {
                        break;
                    }
                    arr[d] = numbers[i];
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"arr[{i}] = {arr[i]}");
                }

            }
        }
        static void GetTwodimensionalArray()  // Функция, которая добавляет столбцы после каждого четного столбца матрицы.
        { 
            Random rnd = new Random();
            int strings, columns;
            Console.Write("Введите количество строк: ");
            while (!(int.TryParse(Console.ReadLine(), out strings)) || strings <= 0)
                Console.Write("Введите количество строк: ");
            Console.Write("Введите количество столбцов: ");
            while (!(int.TryParse(Console.ReadLine(), out columns)) || columns <= 0)
                Console.Write("Введите количество столбцов: ");
            int[,] table = new int[strings, columns];
            int i, j;
            for (i = 0; i < strings; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    table[i, j] = rnd.Next(1, 100);
                    Console.WriteLine($"table[{i}, {j}] = {table[i, j]}");
                }
            }
            int n = (columns - 1) / 2;
            Console.WriteLine($"Четных элементов {n}");
            int col = columns + n;
            int[,] arr = new int[strings, col];
            for (i = 0; i < strings; i++)
            {
                for (j = 0; j < col; j++)
                {
                    if (j >= columns)
                    {
                        arr[i, j] = rnd.Next(1, 100);
                    }
                    else
                    {
                        arr[i, j] = table[i, j];
                    }

                }
            }
            for (i = 0; i < strings; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.WriteLine($"arr[{i}, {j}] = {arr[i, j]}");
                }
            }
        }
        static void GetBrokenArray() // Функия, которая добавляет строку в конец массива.
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
        }
    }
}
