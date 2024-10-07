using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rezultat;
            Console.WriteLine("*** Fibonacciev niz ***");
            Console.WriteLine();
            Console.WriteLine("Unesi broj n: ");
            n = Convert.ToInt32(Console.ReadLine());

            rezultat = Fibonacci(n);
            Console.WriteLine("{0}-ti član Fibonaccievog niza je: {1}", n, rezultat);
            Console.ReadKey();

        }

        public static int Fibonacci(int n)
        {
            int rezultat=0, a=0, b=1, i;

            if (n <= 1)
            {
                return n;
            }
            else
            {
                Console.WriteLine("1. -1");

                for (i = 2; i <= n; i++)
                {
                    rezultat = a + b;
                    a = b;
                    b = rezultat;
                    Console.WriteLine(i + ". - " + rezultat);
                }

                return rezultat;
            }
        }
    }
}
