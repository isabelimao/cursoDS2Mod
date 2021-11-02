using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            DateTime data = DateTime.Now;
            
            string mens = "Esta é a nossa aula de tratamento de strings";

            

            Console.WriteLine(mens.Contains("r"));
            if((mens.Contains("r")) == true)
            {
                Console.WriteLine("TEM R");
            }
            Console.ReadKey();
        }
    }
}

/*
 int numero = 10;
            DateTime data = DateTime.Now; 

            Console.WriteLine(numero + " - " + data.ToString("HH:mm"));
            Console.ReadKey();
 
 
 */