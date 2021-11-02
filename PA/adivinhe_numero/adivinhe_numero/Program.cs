using System;

namespace adivinhe_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_pc, number_usuario, pontuacaoUsuario, pontuacaoPc; 
            Random nPc = new Random();
            number_pc = nPc.Next(0, 9);
            pontuacaoUsuario = 0;
            pontuacaoPc = 0;
            Console.WriteLine("Escolha o seu número entre 0 e 10 :");
            number_usuario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number_usuario);
            Console.WriteLine("O PC escolheu: " + number_pc);
            
            while (pontuacaoPc <= 3 || pontuacaoUsuario <= 3)
            {
                if (number_usuario == number_pc)
                {
                    pontuacaoUsuario++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Essa é a sua pontuação: " + pontuacaoUsuario);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Essa é a pontuação do PC: " + pontuacaoPc);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (number_usuario != number_pc)
                {
                    pontuacaoPc++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Essa é a pontuação do PC: " + pontuacaoPc);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Essa é a sua pontuação: " + pontuacaoUsuario);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine("Escolha mais um número de 0 até 10:");
                number_usuario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number_usuario);
                Console.WriteLine("O PC escolheu: " + number_pc);

            } 

                        

            Console.ReadKey();

        }
    }
}
