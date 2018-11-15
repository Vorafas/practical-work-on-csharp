using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0) {
                Console.Write("Введите число n: ");
            }
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++) {
                numbers[i] = rnd.Next(-10, 10);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.WriteLine("Положительные элементы переставлены в начало массива, отрицательные - в конец");
            int[] arr = new int[n];
            for(int i = 0, c = n - 1, d = 0, e = 0; d < arr.Length; d++, e++){
                if(numbers[e] < 0){
                    arr[i] = numbers[e];
                    i++;
                }else{
                    arr[c] = numbers[e];
                    c--;
                }
            }
            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            Console.ReadLine();
        }
    }
}
