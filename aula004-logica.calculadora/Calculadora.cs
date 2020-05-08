using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula004_logica.calculadora
{
    public enum Operacoes 
    { 
        Somar = 1,
        Subtrair, 
        Multiplicar,
        Dividir
    }

    public class Calculadora
    {
        //teste
        string teste;

        public event EventHandler calcularEvent;

        //Propriedade
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public Operacoes Operacao { get; set; }

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
            teste = string.Empty;
        }
        public Calculadora(int numero1, int numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;
        }

        //evento
        protected virtual void OnProcessou(EventArgs e)
        {
            EventHandler handler = calcularEvent;
            if (handler != null)
            {
                handler(this, e);
            }
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

        public void RealizarOperacao() 
        {
            switch (this.Operacao)
            {
                case Operacoes.Somar:
                    {
                        this.Resultado = this.Numero1 + this.Numero2;
                        break;
                    }
                case Operacoes.Subtrair:
                    {
                        this.Resultado = this.Numero1 - this.Numero2;
                        break;
                    }
                case Operacoes.Multiplicar:
                    {
                        this.Resultado = this.Numero1 * this.Numero2;
                        break;
                    }
                case Operacoes.Dividir:
                    {
                        this.Resultado = this.Numero1 / this.Numero2;
                        break;
                    }
                default:
                    {
                        this.Resultado = -1;
                        break;
                    }
            }

            //Chamar o evento
            OnProcessou(EventArgs.Empty);
        }

        //int Subtrair(int vl1, int vl2)
        //{
        //    return vl1 - vl2;
        //}
        //int Multiplicar(int vl1, int vl2)
        //{
        //    return vl1 * vl2;
        //}
        //int Dividir(int vl1, int vl2)
        //{
        //    return vl1 / vl2;
        //}


        //Destrutor - GC (falado)
        ~Calculadora()
        {
            Debug.WriteLine("Calc Saiu da memória");
        }
    }
}
