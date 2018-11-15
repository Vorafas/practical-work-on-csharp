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
            Console.Write("Введите число : ");
            int a;
            while(!(int.TryParse(Console.ReadLine(), out a)) || n <=0){
                Console.Write("Введите число :");
            }
            int b = n + a;
            int[] arr = new int[b];
            for(int i = 0; i < a; i++){
                arr[i] = rnd.Next(1, 100);
            }
            for(int i = a, c = 0; i < arr.Length; i++){
                arr[i] = numbers[c];
                c++;
            }
            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            Console.ReadLine();
        }
    }
}
