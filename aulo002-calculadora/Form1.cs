using aula004_logica.calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulo002_calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //validando textbox
        bool ValidarControles() 
        {
            //loop
            foreach (var ctx in groupBox1.Controls)
            {
                //If por Tipo
                if (typeof(TextBox) == ctx.GetType())
                {
                    //verificar se campo está vazio
                    if (string.IsNullOrWhiteSpace(((TextBox)ctx).Text))
                    {
                        //outra conversão
                        var txt = (TextBox)ctx;
                        MessageBox.Show("Você precisa digitar o valor no campo",
                                        "Erro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                        );
                        txt.Focus();

                        return false;
                    }
                }
            }
            //controle valido
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //é falso o que está retornando? (!)
            if (!ValidarControles())
            {
                return;
            }

            if ( string.IsNullOrWhiteSpace( cboOperacao.Text) ) 
            {
                MessageBox.Show("Você precisa selecionar a operação",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                cboOperacao.Focus();

                return;
            }

            int numero1 = Convert.ToInt32( txtValor1.Text );
            int numero2 = Convert.ToInt32( txtValor2.Text );

            int resultado;

            if (cboOperacao.Text == "Somar")
            {
                resultado = Somar(numero1, numero2);
            }
            else if (cboOperacao.Text == "Subtrair") 
            {
                resultado = Subtrair(numero1, numero2);

            }
            else if (cboOperacao.Text == "Multiplicar") 
            {
                resultado = Multiplicar(numero1, numero2);
            }
            else
            {
                //dividir
                resultado = Dividir(numero1, numero2);
            }

            lblResultado.Text = resultado.ToString();
            //lblResultado.Text =  (numero1 + numero2).ToString();
        }

        int Somar(int vl1, int vl2) 
        {
            return vl1 + vl2;  
        }
        int Subtrair(int vl1, int vl2) 
        {
            return vl1 - vl2;
        }
        int Multiplicar(int vl1, int vl2)
        {
            return vl1 * vl2;
        }
        int Dividir(int vl1, int vl2)
        {
            return vl1 / vl2;
        }

        /***
         * Apaguei o botão, nós podemos e devemos remover esse código*/
        //exemplo de botão apagado
        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("O Resultado é:" + Somar(100, 50) );
        }

        private void btnCalcularDll_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            //lblResultado.Text = calc.Somar(txtValor1.Text, txtValor2.Text).ToString() ;

            //propriedades
            calc.Numero1 = Convert.ToInt32(txtValor1.Text);
            calc.Numero2 = Convert.ToInt32(txtValor2.Text);

            //enum
            calc.Operacao = Operacoes.Somar;

            calc.RealizarOperacao();

            lblResultado.Text = calc.Resultado.ToString();
        }
    }
}
