using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
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
            for (int i = 0; i < charArr.Length; i++) {
                for (int j = 0; j < vowels.Length; j++) {
                    //result = charArr[i] == vowels[j] ? true : false;
                    if (charArr[i] == vowels[j])
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        static bool CheckrElem(char checkElem, char[] vowels) {
            bool result = false;
            for (int i = 0; i < vowels.Length; i++) {
                if (vowels[i] == checkElem) {
                    result = true;
                }
            }
            return result;
        }

        static int CheckrElemArr(char[] charArr, char[] vowels)
        {
            int number = 0;
            for (int i = charArr.Length - 1; i < charArr.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++) {
                    if (charArr[i] == vowels[j])
                    {
                        number = i;
                        break;
                    }
                }
            }
            return number;
        }

        static void  Result(ref char[] charArr, char[] vowels)
        {
            char[] newArr = new char[charArr.Length-1];
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
            else if(!(CheckrElem(charArr[0], vowels)))
            {
                Console.WriteLine("Гласных букв не обнаружено!");
                GetArray(charArr);
            }
            else
            {
                Console.WriteLine("Массив пуст!!!");
            }
            
        }
        static void Main(string[] args)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            int a = MakeIntNumber("Введите количество элементов массива: ");
            char[] charArr = MakeMas(a);    
            Result(ref charArr, vowels);
            Console.ReadLine();
        }
    }
}
