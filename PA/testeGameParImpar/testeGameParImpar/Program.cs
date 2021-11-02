using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeGameParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nPc = new Random();
            int nUsuario, nComputador;
            double soma;
            nComputador = nPc.Next(0, 9);
            Console.WriteLine("Escreva o número que você quiser");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            nUsuario = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            // Abaixo você vai ver uma forma diferente de se usar o console writeline, aqui eu 
            // tratei ele usando o $ -> que significa "Tratamento de string"
            // dentro da chave, eu insiro a variável que eu quero, com isso reduzo as linhas de código.
            Console.WriteLine($"O computador escolheu: {nComputador}");
            Console.WriteLine();
            /*Abaixo vou te mostrar as duas formas, a com mais linhas e a com menos linhas. 
             Observem, 4 linhas para mostrar a soma, vou fazer isso virar uma só
             */
            Console.WriteLine("Abaixo a soma dos dois números");
            soma = Convert.ToDouble(nUsuario) + Convert.ToDouble(nComputador);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(soma);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            /*
             Abaixo, vamos mostrar a soma, usando apenas UMA LINHA
             */
            Console.WriteLine($"Confira a soma dos dois números: {nUsuario + nComputador}");
            /*
             Veja acima, ao invés de 4 linhas, tudo só em uma.
             */
            if (soma % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("É um número Par");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("É impar");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.ReadKey();
            
        }
    }
}
