using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNaString
{
    class Program
    {


        static void Main(string[] args)
        {
            byte[] randBytes = new byte[] { };
            Random randNum = new Random();
            randNum.NextBytes(randBytes);
            Console.WriteLine("Escolha um número");
            int numUsuario = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numUsuario; i++)
            {
                int impar = randNum.Next(20);
                int imparCerto = impar;
                if (imparCerto % 2 == 1)
                {

                    Console.WriteLine(imparCerto.ToString());
                }
                Console.WriteLine(randBytes.Length);
               
            }
                Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}

/*
 Console.WriteLine("" + (randNum.Next()));
 */

/*
 
            byte[] randBytes = new byte[] {};
            Random randNum = new Random();
            randNum.NextBytes(randBytes);
            Console.WriteLine("Escolha um número");
            int numUsuario = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numUsuario; i++)
            {
                int impar = randNum.Next();
                int imparCerto = impar;
                if (imparCerto %2 == 1)
                {
                    Console.WriteLine(imparCerto);
                }

             }
 */