using System;

namespace exercicio1_ds2_juros
{
    class Program
    {
        static void Main(string[] args)
        {
            double investimento, taxa, meses;
            investimento = 1000;
            taxa = 0.0036;
            Console.WriteLine($"Informe quantos meses você quer investir com a taxa de {taxa}");
            meses = Convert.ToDouble(Console.ReadLine());
            while(meses > 12 || meses <= 0)
            {
                Console.WriteLine("Informe um número entre 1 e 12");
                Console.WriteLine($"Informe quantos meses você quer investir com a taxa de {taxa}");
                meses = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < meses; i++)
            {
                double res = i * taxa * investimento;
                Console.WriteLine($"Seu lucro de { res } .00");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
