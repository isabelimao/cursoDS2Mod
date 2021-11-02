using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedra_papel_tesoura_oob
{
    class itens
    {

        public int escolhaPc { get; set; }
        public int escolhaUsuario { get; set; }

        public void escolha_usuario()
        {
            if (escolhaUsuario == 1)
            {
                Console.WriteLine("VOCÊ ESCOLHEU TESOURA");
            }
        }
        public void escolhaPC()
        {
            Random itensGame = new Random();
            escolhaPc = itensGame.Next(1, 4);

            if (escolhaPc == 1)
            {
                Console.WriteLine($"O PC ESCOLHEU TESOURA");
            } else if (escolhaPc == 2)
            {
                Console.WriteLine("O PC ESCOLHEU PAPEL");
            } else if (escolhaPc == 3)
            {
                Console.WriteLine("O PC ESCOLHEU TESOURA");
            }
        }

      

    }
}
