using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0){
                Console.Write("Нельзя вычислить. Введите n: ");                          
            }
            Console.Write("Введите m: ");
            int m;
            while (!(int.TryParse(Console.ReadLine(), out m)) || m <= 1) {
                Console.Write("Нельзя вычислить. Введите m: ");
            }
            float k = (n++ / --m);
            Console.WriteLine("n++/--m = {0}, n = {1}, m={2}", k, n, m);
            Console.ReadLine();
        }
    }
}
