using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {
        static int MakeIntNumber(string message)
        {
            int n;
            do
            {
                Console.Write(message);
            } while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0);
            return n;

        }
        static char[] MakeMas(int n)
        {
            char[] charArr = new char[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"Введите {i + 1} элемент массива: ");
                } while (!(char.TryParse(Console.ReadLine(), out charArr[i])));
            }

            return charArr;
        }

        static void GetArray(char[] charArr)
        {
            for (int i = 0; i < charArr.Length; i++)
            {
                Console.WriteLine($"{charArr[i]}");
            }
        }

        static bool CheckArr(char[] charArr, char[] vowels)
        {
            bool result = false;
            for (int i = 0; i < charArr.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    //result = charArr[i] == vowels[j] ? true : false;
                    if (charArr[i] == vowels[j])
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        static bool CheckrElem(char checkElem, char[] vowels)
        {
            bool result = false;
            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == checkElem)
                {
                    result = true;
                }
            }
            return result;
        }

        static int CheckrElemArr(char[] charArr, char[] vowels)
        {
            int number = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (charArr[i] == vowels[j])
                    {
                        number = i;
                        break;
                    }
                }
            }
            return number;
        }

        static void Result(ref char[] charArr, char[] vowels)
        {
            char[] newArr = new char[charArr.Length - 1];
            if (charArr.Length - 1 >= 1)
            {
                if (CheckArr(charArr, vowels))
                {
                    for (int i = 0, c = 0; i < charArr.Length; i++, c++)
                    {
                        if (i == CheckrElemArr(charArr, vowels))
                        {
                            c--;
                        }
                        else
                        {
                            newArr[c] = charArr[i];
                        }

                    }
                    charArr = newArr;
                    GetArray(charArr);
                }
                else
                {
                    Console.WriteLine("Гласных букв не обнаружено!");
                }
            }
            else if (!(CheckrElem(charArr[0], vowels)))
            {
                Console.WriteLine("Гласных букв не обнаружено!");
                GetArray(charArr);
            }
            else
            {
                Console.WriteLine("Массив пуст!!!");
            }

        }

        static int GetRandomNumber(string text) {
            int number;
            do {
                Console.Write(text);
            } while (!(int.TryParse(Console.ReadLine(), out number)) || number <=0 || number >= 3);
            return number;
        }

        static void GetText(string text) {
            Console.WriteLine(text);
        }

        static int GetNumber(string text) {
            int number;
            do {
                Console.WriteLine();
                Console.Write(text);
            } while (!(int.TryParse(Console.ReadLine(), out number)) || number <= 0 || number >= 5);
            return number;
        }

        static char[] GetRandomArr(char[] randomChar) {
            Random rnd = new Random();
            int number = rnd.Next(5, 10);
            char[] array = new char[number];
            for (int i = 0; i < array.Length; i++) {
                var num = randomChar[rnd.Next(0, randomChar.Length - 1)];
                array[i] = num;
            }
            return array;
        }

        static string[] GetStirng(string txt)
        {
            string text;
            do
            {
                Console.Write(txt);
                text = Console.ReadLine();
            } while (false);
            text = text.Trim();
            text = text.Replace(".", ".\\").Trim();
            text = text.Replace("!", "!\b").Trim();
            text = text.Replace("?", "?\f").Trim();
            string [] sentense = text.Split(new char[] { '\\', '\b', '\f' });
            return sentense;
        }

        static void GetArray1(string[] charArr)
        {
            for (int i = 0; i < charArr.Length; i++)
            {
                Console.WriteLine($"{charArr[i]}");
            }
        }

        static string[] GetChangedArray(string[] array) {
            string[] newArr = new string [array.Length - 1];
            //GetArray1(array);
            //GetArray1(newArr);
            //Console.WriteLine(array.Length + "\n" + newArr.Length);
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i == 0)
                {
                    newArr[0] = array[array.Length - 2];
                }
                else if (i == array.Length - 2)
                {
                    newArr[array.Length - 2] = array[0];
                }
                else
                {
                    if (i != 0 || i != array.Length - 2)
                    {
                        newArr[i] = array[i];
                    }

                }
            }
            return newArr;
        }

        static void GetStringArr(string[] array)
        {
            string text = "";
            foreach (string s in array) {
                text += s.Trim() + " ";
            }
            Console.WriteLine("Выполнена обработка строки.");
            Console.WriteLine(text.Trim());
        }

        static void Main(string[] args)
        {
            bool flag = false;
            GetText("1. Удалить элемент из массива. \n2. Поменять местами элементы массива.\n3. Вывести меню. \n4. Выход");
            do {
                int number = GetNumber("Введите номер пункта: ");
                switch (number) {
                    case 1:
                        char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
                        char[] randomChar = {'3', 'I', '0', '2', '5', 'R', 'X', 'T','9', 'p', '4', 'O', 'U', 'a', 'e', };
                        char[] charArr = null;
                        int a;
                        GetText("1. Ввести массив вручную. \n2. Ввести массив с помощью ДСЧ.");
                        int num = GetRandomNumber("Введите номер пункта: ");
                        switch (num)
                        {
                            case 1:
                                a = MakeIntNumber("Введите количество элементов массива: ");
                                charArr = MakeMas(a);
                                break;
                            case 2:
                                charArr = GetRandomArr(randomChar);
                                GetArray(charArr);
                                Console.WriteLine("Обработанный массив");
                                break;
                        }
                        if (charArr == null)
                        {
                            charArr = randomChar;
                        }
                        Result(ref charArr, vowels);
                        break;
                    case 2:
                        string[] str = GetStirng("Введите символы :");
                        string[] newArr = GetChangedArray(str);
                        GetStringArr(newArr);
                        break;
                    case 3:
                        GetText("1. Удалить элемент из массива. \n2. Поменять местами элементы массива.\n3. Вывести меню. \n4. Выход");
                        break;
                    case 4:
                        flag = true;
                        break;
                }
            } while (!flag);
        }
    }
}
