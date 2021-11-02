using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosCorteControle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dadosProdutos = new string[,]
            {
                {"1", "martelos","01/2019", "10"},
                {"1", "martelos","01/2019", "14"},
                {"1", "martelos","02/2019", "5"},
                {"1", "martelos","03/2019", "2"},
                {"2", "chaves fenda","02/2019", "2"},
                {"2", "chaves fenda","03/2019", "1"},
                {"3", "chaves philips","01/2019", "20"},
                {"3", "chaves philips","01/2019", "30"},
                {"3", "chaves philips","01/2019", "50"},
                {"4", "baldes","03/2019", "100"},
                {"5", "pas","02/2019", "50"},
                {"5", "pas","03/2019", "150"},
            }; 

            int totalProdutos = 0;
            int totalGeral = 0;
            string idProdutoAtual = "";
            string idProdutoAnterior = "";
            int cont = 0;
            Console.WriteLine("Id - Produto - Data - Qtd"); //CABEÇALHO DE CADA CADO                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
            while (cont < 12)
            {
                idProdutoAtual = idProdutoAnterior = dadosProdutos[cont, 0];
                while (cont < 12 && idProdutoAnterior == idProdutoAtual)
                {
                    Console.WriteLine($"{dadosProdutos[cont, 0]} - {dadosProdutos[cont, 1]} - {dadosProdutos[cont, 2]} - {dadosProdutos[cont, 3]} ");
                    totalProdutos += Convert.ToInt32(dadosProdutos[cont, 3]);
                    cont++;
                    if (cont < 12)
                        idProdutoAtual = dadosProdutos[cont, 0];
                }
                Console.WriteLine($"Total do produto: {totalProdutos}");
                Console.WriteLine();
                totalGeral += totalProdutos;
                totalProdutos = 0;
            }
            Console.WriteLine($"Total Geral: {totalGeral}");

            Console.ReadKey();
        }
    }
}
