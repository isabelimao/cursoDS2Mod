using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_exercicio_ds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int w = 100; w > 10; w--)
            {
                Console.WriteLine(w);
            }
            Console.ReadKey();
            
            int num = 0; String nome = "Gabriela"; foreach (char c in nome) { num += c; }
            Console.Write(num);
            Console.ReadKey();
           
            int num = 0; String email = "jeffinho.je8@gmail.com"; 
            foreach (char c in email) {
                Console.WriteLine(num += c);
                };
            Console.Write(num);
            Console.ReadKey();
             
            String texto = "jeffinho.je8@gmail.com"; char[] letras = texto.ToCharArray(); 
            for (int i = 0; i < letras.Length; i++) 
            {
                
                Console.Write(letras[i]); 
            }
            Console.ReadKey();
           

            try

            {
                int num;
                num = Convert.ToInt32(Console.ReadLine());
                do
                    num++;
                while (num <= 10);
                    

            }

            catch (FormatException)

            {

                Console.WriteLine("Digite algo numérico");

            }

          

            catch (Exception ex)

            {
                ex.ToString();
                Console.WriteLine();

            }
            Console.ReadKey();
            

            string email; 
                email = email = "jeffinho.je8@gmail.com"; int count = 3; for (; ; ) 
            { Console.WriteLine(++count); 
                if (count > email.Length) { break; } }
            Console.ReadKey();
            
                bool fomos;
            
            fomos = false; for (int x = 0; x < 5; x++) { fomos = fomos ? !fomos : fomos; }
            Console.ReadKey();
            */
            String[,] tabuleiro = new String[2, 4];
            int contador = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tabuleiro[i, j] = Convert.ToString(++contador);
                    Console.WriteLine("[i,j]=" + i + "," + j + " contador=" + contador);
                }
            }
            Console.ReadKey();
        }
    }
}
