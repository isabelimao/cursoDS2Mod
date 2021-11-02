using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procurarNomeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char[] letras = {'A','B','C','D','E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
            'P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l',
            'l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'}; 
            */

            int[] vetor = { 'A','B','C','D','E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
            'P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l',
            'l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

            Console.WriteLine("Insira um valor para buscar: ");
            string valorBuscado = Convert.ToString(Console.ReadLine());

            int posicao = Array.IndexOf(vetor, valorBuscado.ToLower());

            if (valorBuscado == "")
            {
                Console.WriteLine("Não tem nada aqui");
            }

            if (posicao > 0)
            {
                Console.WriteLine($"Achei o nome: {valorBuscado[posicao]} na posição {posicao}");

            }
            else
            {
                Console.WriteLine("Não achei");

            }




            Console.ReadKey();
        }
    }
}
