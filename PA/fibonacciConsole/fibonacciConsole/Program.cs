using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;


            for (int i = 0; i < 100; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;

                Console.WriteLine(fibonacci);    
                Console.ReadKey();
            }
        }
    }
}
