using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив из 20-ти элементов: ");
            Random rnd = new Random();
            int[] numbers = new int[20];
            int t;
            numbers[1] = rnd.Next(0, 20);
            for (int i = 1; i < numbers.Length; i++) {
                while (true) {
                    t = rnd.Next(0, 20);
                    if (!Check(numbers, t)) {
                        break;
                    }
                }
                numbers[i] = t;
            }
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            Console.ReadLine();
        }
        static bool Check(int[] array, int value){
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == value) {
                    return true;
                }
            }
            return false;
        }
    }
}
