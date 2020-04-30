using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //se for verdade
            if ( string.IsNullOrWhiteSpace( txtValor1.Text ) )
            {
                //condicao verdadeira
                MessageBox.Show("Você precisa digitar o valor 1",
                    "Erro", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                //foco no controle
                txtValor1.Focus();

                //Não continuar
                return;
            }
            if (string.IsNullOrWhiteSpace(txtValor2.Text))
            {
                //condicao verdadeira
                MessageBox.Show("Você precisa digitar o valor 2",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                //foco no controle
                txtValor2.Focus();

                //Não continuar
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


            if (cboOperacao.Text == "Somar")
            {
                lblResultado.Text = Convert.ToString(numero1 + numero2);
            }
            else if (cboOperacao.Text == "Subtrair") 
            {
                lblResultado.Text = Convert.ToString(numero1 - numero2);
            }
            else if (cboOperacao.Text == "Multiplicar") 
            {
                lblResultado.Text = Convert.ToString(numero1 * numero2);
            }
            else
            {
                //dividir
                lblResultado.Text = Convert.ToString(numero1 / numero2);
            }

                                           
            
            //lblResultado.Text =  (numero1 + numero2).ToString();
        }
    }
}
