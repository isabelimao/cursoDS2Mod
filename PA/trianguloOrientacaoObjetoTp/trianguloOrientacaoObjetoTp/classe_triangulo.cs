using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianguloOrientacaoObjetoTp
{
    class classe_triangulo
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }
        public string tipo { get; set; }

        public bool sim_triangulo { get; set; }
        public double perimetro { get; set; }
        public double area { get; set; }

        public void isTriangle()
        {
            sim_triangulo = true;
            Console.WriteLine("Isso é um triangulo");
        }

        public void notTriangle()
        {
            sim_triangulo = false;
            Console.WriteLine("Isso não é um triangulo");
        }

        public void tipoEquilatero()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("É um triângulo Equilatero".ToString());
            }
        }

        public void tipoEscaleno()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("É um triângulo Escaleno".ToString());
            }
        }
        public void tipoIsosceles()
        {
            Console.WriteLine("É um triângulo Isosceles.".ToString());
        }
        public void CalcularPerimetro()
        {
            perimetro = lado1 + lado2 + lado3;
        }
        public void calcularArea()
        {
            double sp;
            sp = perimetro / 2;
            area = Math.Sqrt((sp*(sp-lado1)* (sp - lado2)* (sp - lado3)));
        }
    }
}
