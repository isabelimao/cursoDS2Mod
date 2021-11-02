using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianguloOrientacaoObjetoTp
{
    class Program
    {
        static void Main(string[] args)
        {

            classe_triangulo objTriangulo = new classe_triangulo();
            Console.WriteLine("Insira o primeiro valor");
            objTriangulo.lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            objTriangulo.lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor");
            objTriangulo.lado3 = Convert.ToDouble(Console.ReadLine());

            if (objTriangulo.lado1 < (objTriangulo.lado2 + objTriangulo.lado3) == true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                objTriangulo.isTriangle();
            }
            else if (objTriangulo.lado2 < (objTriangulo.lado1 + objTriangulo.lado3) == true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                objTriangulo.isTriangle();
            }
            else if (objTriangulo.lado3 < (objTriangulo.lado1 + objTriangulo.lado2) == true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                objTriangulo.isTriangle();
            }
            else
            {
                objTriangulo.notTriangle();
            }
            Console.WriteLine();
             
            objTriangulo.CalcularPerimetro();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"O perimetro desse Triangulo é de {objTriangulo.perimetro}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (objTriangulo.lado1 == objTriangulo.lado2 && objTriangulo.lado2 == objTriangulo.lado3)
            {
                objTriangulo.tipoEquilatero();

            } else if (objTriangulo.lado1 != objTriangulo.lado2 && objTriangulo.lado1 != objTriangulo.lado3 && objTriangulo.lado2 != objTriangulo.lado3)
            {
                objTriangulo.tipoEscaleno();
            } else
            {
                objTriangulo.tipoIsosceles();
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            objTriangulo.calcularArea();
            Console.WriteLine();
            Console.WriteLine($"A área desse triangulo é de {objTriangulo.area}");

            Console.ReadKey();
            
        }
    }
}
