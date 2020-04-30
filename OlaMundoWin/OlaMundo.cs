using System.Windows.Forms;

namespace OlaMundoWin
{
    public partial class OlaMundo : Form
    {
        public OlaMundo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string nome = txtNome.Text;
            MessageBox.Show("Olá Mundo, Olá " + nome);
        }
    }
}
