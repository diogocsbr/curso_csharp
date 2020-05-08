using aula004_logica.calculadora;
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
    public delegate void SimplesMensagemDelegate();
    public partial class frmCalculadora : Form
    {
        String strNumero1;
        Operacoes ? operacoes;
        private string strNumero2;
        bool numero1Preenchido = false;

        aula004_logica.calculadora.Calculadora calc = new Calculadora();

        SimplesMensagemDelegate simplesDel = new SimplesMensagemDelegate(Mensagem);

        public frmCalculadora()
        {
            InitializeComponent();

            //fazer funcionar
            calc.calcularEvent += Calc_calcularEvent;
        }

        private void Calc_calcularEvent(object sender, EventArgs e)
        {
            txtVisor.Text = calc.Resultado.ToString();
            Reiniciar();
        }

        static void Mensagem() 
        {
            MessageBox.Show("chamado via delegate","C");
        }

        //Concatenar o numero1
        void ConcatenaNumero(string txtNumero)
        {
            if (numero1Preenchido) // simmmmm
            {
                //preencheremos o numero2
                this.strNumero2 = this.strNumero2 + txtNumero;
                txtVisor.Text = this.strNumero2;
            }
            else //naaaaao
            {
                //preencheremos o numero1
                this.strNumero1 = this.strNumero1 + txtNumero;
                txtVisor.Text = this.strNumero1;
            }
        }

        void Reiniciar()
        {
            strNumero1 = string.Empty;
            strNumero2 = string.Empty;
            this.operacoes = null;
            this.numero1Preenchido = false;
        }

        void ApagarTudo() {

            Reiniciar();
            txtVisor.Clear();
        }

        void DeterminarOperacao(Operacoes _operacao)
        {
            this.operacoes = _operacao;
            this.numero1Preenchido = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("1");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("0");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chamada do delegate
            //simplesDel();
            calc.Numero1 = Convert.ToInt32(this.strNumero1);
            calc.Numero2 = Convert.ToInt32(this.strNumero2);
            
            calc.Operacao = this.operacoes.Value;

            calc.RealizarOperacao();

            //txtVisor.Text = calc.Resultado.ToString();

            //
            //Reiniciar();
        }


        private void btnDividir_Click(object sender, EventArgs e)
        {
            DeterminarOperacao(Operacoes.Dividir);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("6");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("9");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ConcatenaNumero("7");
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            DeterminarOperacao(Operacoes.Somar);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            DeterminarOperacao(Operacoes.Subtrair);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            DeterminarOperacao(Operacoes.Multiplicar);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ApagarTudo();
        }
    }
}
