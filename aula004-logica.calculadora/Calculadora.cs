﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula004_logica.calculadora
{
    public class Calculadora
    {
        //Propriedade
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int Resultado { get; private set; }

        /*
        private int resultado2;
        public int Resultado2 { 
            get 
            {
                return resultado2;
            } 
            set
            {
                resultado2 = value;
            }
        }
        */

        //Construtor
        public Calculadora()
        {
            string teste = string.Empty;
            
        }
        public Calculadora(int numero1, int numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;
        }

        //método //função
        public int Somar() 
        {
            this.Resultado = this.Numero1 + this.Numero2;
            
            return this.Resultado;
            //futuramente falaremos de Delegate e Events
        }
        public int Somar(string numero1, string numero2)
        {
            int n1 = Convert.ToInt32(numero1);
            int n2 = Convert.ToInt32(numero2);

            return n1 + n2;
        }


        //Destrutor - GC
    }
}