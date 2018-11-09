using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n;
            while(!(int.TryParse(Console.ReadLine(), out n)) || n <= 0){
                Console.Write("Введите число n: ");
            }
            int [] numbers = new int[n];
            Random rnd = new Random();
            for(int i = 0; i < n; i++){
                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.Write("Введите число :");
            int a;
            while(!(int.TryParse(Console.ReadLine(), out a)) || n <=0){
                Console.Write("Введите число :");
            }
            var numbersList = numbers.ToList();
            for(int i = n; i < (n + a); i++){
                numbersList.Insert(i, rnd.Next(0, 100));
            }
            var numbersArr = numbersList.ToArray();
            for(var i = 0; i < numbersArr.Length; i++){
                Console.WriteLine($"n[{i}] = {numbersArr[i]}");
            }
            Console.ReadLine();
        }
    }
}
