using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula003
{
    //Voltar a falar quando OO
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variavel
            string nome = "Diogo";

            //declarando variavel
            Int16 idade = 36;

            Carro Carro_gol = new Carro();
            Carro_gol.porta = 5;
            Carro_gol.cor = "Cinza";

            Carro Carro_uno = new Carro();
            Carro_uno.porta = 3;
            Carro_uno.cor = "Verde";

            Carro_gol.Ligar();
            Carro_uno.Ligar();

            Carro_gol.Rodas = 4;
            Carro_uno.Rodas = 3;
        }
    }

    class Carro
    {
        public int porta = 4;
        public string cor = "preto";

        //propriedade
        public int Rodas { get; set; }


        //Metodos
        public void Ligar() 
        { 

        }

        void Dirigir() 
        {

        }

        void Acelerar() 
        { 
        
        }

    }

}
