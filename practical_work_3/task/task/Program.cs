using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1, b = 1, h;
            int k = 10;
            h = (b - a) / k;
            double eps = 0.0001;

            for (double x = a; x <= b; x = x + h)
            {
                double an = 1;
                double sn = 0;

                for (int i = 0; i < 10; i++)
                {
                    sn += an;
                    an *= (Math.Pow(Math.Log(3), i + 1) / Math.Pow(Math.Log(3), i)) * x / (i + 1);
                }

                an = 1;
                double se = 0;
                int t = 0;
                while (Math.Abs(an) > eps)
                {
                    se += an;
                    an *= (Math.Pow(Math.Log(3), t + 1) / Math.Pow(Math.Log(3), t)) * x / (t + 1);
                    t++;
                }

                Console.WriteLine("X={0}\tSN={1}\tSE={2}\tY={3}", x, sn, se, Math.Pow(3, x));
            }

            Console.ReadKey();
        }
    }
}
