using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testandoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            decimal soma = 0, media = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(String.Format("Informe o elemento de índice {0}:", i));
                valores[i] = int.Parse(Console.ReadLine());
                soma += valores[i];
            }
            media = soma / 10;
            for (int i = 0; i < 10; i++)
            {
                if (valores[i] < media)
                    Console.WriteLine(String.Format("O elemento de índice {0}, cujo valor é {1}, está abaixo da média.", i, valores[i]));
            }
            Console.ReadKey();
        }
    }
}
