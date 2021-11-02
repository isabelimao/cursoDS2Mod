using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedra_papel_tesoura_oob
{
    class Program
    {
        static void Main(string[] args)
        {
            itens objItens = new itens();
            string usuarioEscolha;
            Console.WriteLine("1 - PEDRA; 2 - PAPEL; 3 TESOURA");
            // AQUI VAI TER UM WHILE
            Console.WriteLine("Escolha o  que você quer: ");
            usuarioEscolha = Console.ReadLine();

            while (usuarioEscolha == "PEDRA") 
            {
                Console.WriteLine("Escolha o  que você quer: ");
                usuarioEscolha = Console.ReadLine();
                Console.WriteLine($"Você escolheu {usuarioEscolha.ToUpper()}");
            }
            Console.ReadKey();
        }

    }
}

