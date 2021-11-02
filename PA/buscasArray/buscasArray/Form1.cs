using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscasArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        { // 1º tipo da variavel -> string
          // 2º coloca os colchetes -> []
          // 3º coloca um nome para a variavel -> nomes
          // 4º coloca o sinal de igual -> = 
          // 5º colocar a frase -> new string[] (Se necessário, coloque o numero de elementos)
          // 6º coloque chave no final da string -> {}
          // string[] nomes = new string[36]{}; 
            string[] nomes = new string[36] {"ADILSON EMANUEL EDUARDO", "ANA BEATRIZ YUJRA ESPEJO", "ANA CAROLINA XAVIER BARBOSA",
                "ANA CLARA LOUREIRO DE SANTANA","ANDERSON ALVES DE MACEDO","ANGELO MATEUS CORDEIRO","BRUNNA CRISTINA SILVA MARTINIANO",
                "CAIO HENRIQUE GOMES LIMA","CHRISTIAN VICENTE KALOUPIS","CRISTIENE FONSECA DA SILVA","DANIEL PAULO DE SOUZA",
                "DANILO COSTA CALHEIROS JUNIOR","FELIPE DA SILVA MACEDO","GABRIEL PLATINI MENDES VIEIRA","GIOVANA GREGATI RAMOS",
                "GIOVANNA RIBEIRO PEREIRA SILVA","HUGO OLIVEIRA FIGUEREDO","ISABEL GOMES LIMAO","ISABELA DEL VECCHIO BUENO GOES",
                "JEFFERSON LOPES DA SILVA","JEFSON ALVES GUIMARAES","JENNIFER GOMES ROSA DA SILVA","LEONARDO SILVA MATTOS",
                "LETICIA PEREIRA LIMA DO CARMO","LUCAS MACIEL DE LIMA CARVALHO","MANUELE SOUSA DA SILVA","MARIA NATASHA VITORINO PEIXOTO",
                "MARIA PAULA DA SILVA ROCHA","RAFAELA MACEDO LIZARDO","RENATO ZAMBONI DE ALBUQUERQUE","RICARDO GENESI DE FREITAS",
                "RONALDO CAETANO DE FREITAS JUNIOR","TAINA SOUZA RIBEIRO","TARCILIA BARBOSA CORREIA","VICTOR DE MORAIS BESSI",
                "VINICIUS SODRE DOS SANTOS"};


            // primeira coisa a definir -> tipo da variavel
            string buscar;
            // segunda coisa a definir -> o que vai ser a sua variável
            buscar = /*Converter para tipo String*/Convert.ToString/*Tudo que estiver na minha textbox*/(textBox1.Text);

                                             // tipo string -- no lugar de "item" eu coloquei "nome"
            foreach /*foreach -> Para Cada*/ (string nomeBuscar in nomes)
            {                   // Contains - Contém
                if (/*Buscar para mim o que contem em*/nomeBuscar.Contains/*Variavel buscar*/(buscar.ToUpper()) || nomeBuscar.Contains(buscar.ToLower()))
                {
                    MessageBox.Show("Aluno encontrado: " + nomeBuscar);
                   
                }
            }

           
        }
    }
}
        