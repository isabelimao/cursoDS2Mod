using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveisFrequentes
{
    class Program
    {
        static void Main(string[] args)
        {
            // No curso usamos diversas variaveis, mas eu quero trazer aqui algumas mais comuns.
            // Este é um estudo ilustrativo, então não precisa daquele PDF clássifco, basta você copiar isso no seu C#

            // Strings -> Quando voce quer que o PC reconheça o que você quer colocar como letra. Precisa de aspas duplas
            // Int -> Trabalha com números inteiros sem virgula.
            // float -> Números com virgula.

            Console.WriteLine("O que você quer testar?");
            Console.WriteLine("DIGITE 1 PARA STRING ou 0 PARA ESCOLHER OUTRA COISA");
            string numString;
            numString = "1";
            Convert.ToString(Console.ReadLine());
         if (numString == "1")
            {
                Console.WriteLine("Este Programa");
                Console.ReadKey();
                return;
            } else if (numString == "0") {

                Console.WriteLine("DIGITE 2 PARA INT ou 0 PARA ESCOLHER OUTRA COISA");
                int numInt;
                numInt = 2;
                if (numInt == 2)
                {
                    Console.WriteLine("Este Programa de Int");
                    Console.ReadKey();
                    return;
                }
            }
            
            Console.WriteLine("Se você chegou até aqui, você quer o FLoat");
            Console.ReadLine();

            
            
        }
    }
}
