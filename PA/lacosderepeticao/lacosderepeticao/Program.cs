using System;

namespace lacosderepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, res;
            Console.WriteLine("Insira o primeiro número");
            numero = int.Parse(Console.ReadLine());
            res = numero + 0;
            Console.WriteLine(res);




            Console.ReadKey();
        }
    }
}

/*
    do
            {
                Console.WriteLine(res--);
            }
            while (res >= 20);
            Console.WriteLine("O programa acabou");
 */