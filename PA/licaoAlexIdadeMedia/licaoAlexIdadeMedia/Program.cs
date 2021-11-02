using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace licaoAlexIdadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dadosAlunos = new string[,]
           {
                {"TURMA 1", "Fulaninho","25", "170"},
                {"TURMA 1", "Ciclaninho","19", "140"},
                {"TURMA 1", "Beltraninho","35", "175"},
                {"TURMA 1", "Abigobaldo","21", "102"},
              
           };

            int totalProdutos = 0;
            int totalGeral = 0;
            string idAlunoAtual = "";
            string idAlunoAnterior = "";
            int cont = 0;
            Console.WriteLine("IdAluno - IdNome - Idade - Altura"); //CABEÇALHO DE CADA CADO                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
            while (cont < 4)
            {
                idAlunoAtual = idAlunoAnterior = dadosAlunos[cont, 0];
                while (cont < 4 && idAlunoAnterior == idAlunoAtual)
                {
                    Console.WriteLine($"{dadosAlunos[cont, 0]} - {dadosAlunos[cont, 1]} - {dadosAlunos[cont, 2]} - {dadosAlunos[cont, 3]} ");
                    totalProdutos += Convert.ToInt32(dadosAlunos[cont, 3]);
                    cont++;
                    if (cont < 4)
                        idAlunoAtual = dadosAlunos[cont, 0];

                    
                }
                Console.WriteLine($"Total de altura: {totalProdutos}");
                Console.WriteLine();
                totalGeral += totalProdutos;
                totalProdutos = 0;

                
            }
            Console.WriteLine($"Total Geral: {totalGeral}");

            Console.ReadKey();
        }
    }
}
