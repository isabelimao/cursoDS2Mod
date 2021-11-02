using System;

namespace algoritmosBusca
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine("Insira um valor para buscar: ");
            int valorBuscado = Convert.ToInt16(Console.ReadLine());

            // busca binária 

            int inf, meio, sup;
            inf = -1;
            sup = vetor.Length;

            //Enquanto (inf > sup) /2;.

            while (inf < sup - 1)
            {
                meio = (inf + sup) / 2;
                if (vetor[meio] < valorBuscado)
                    inf = meio;
                else
                    sup = meio;
            }

            if (sup >= 0 && sup < vetor.Length)
            {
                if (vetor[sup] == valorBuscado)
                {
                    Console.WriteLine("Valor encontrado na posição: " + sup);
                }
                else
                {
                }
            }
            else
            {
                Console.WriteLine("Valor não encontrado!");
            }

            Console.ReadKey();
        }
    }
}
