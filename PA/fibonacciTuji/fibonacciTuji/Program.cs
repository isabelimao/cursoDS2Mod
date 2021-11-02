using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciTuji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o termo Fibonacci?");

            int tam = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[tam];

            for (int i = 0; i < tam; i++)
            {
                if (i == 0)
                {
                    fibonacci[i] = 0;
                }
                else if (i == 1)
                {
                    fibonacci[i] = 1;
                }
                else
                {
                    fibonacci[i] = (fibonacci[i - 1]) + (fibonacci[i - 2]);
                }
                Console.WriteLine("fibonacci[" + i + "] - " + fibonacci[i]);
            } Console.WriteLine("\n\n0" + tam + "° termo da sequencia Fibonacci é " + fibonacci[tam - 1]);
            Console.ReadKey();
        }  
    }
}
