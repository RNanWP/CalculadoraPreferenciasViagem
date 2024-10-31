namespace Calculadora_de_Preferências_de_Viagem
{
    public partial class FormCalculoDesconto : Form
    {
        public FormCalculoDesconto()
        {
            InitializeComponent();
        }

        private void rba12Parcerlas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }

        private void btnCalcularDesconto_Click(object sender, EventArgs e)
        {
            decimal valorProduto;
            if (decimal.TryParse(txtValorProduto.Text, out valorProduto))
            {
                if (rbAVista.Checked)
                {
                    txtResultado.Text = (valorProduto * 0.9m).ToString("C");
                }
                else if (rbAte3Parcelas.Checked)
                {
                    txtResultado.Text = valorProduto.ToString("C");
                }
                else if (rb4a12Parcelas.Checked)
                {
                    decimal juros = 0.2m;  //Exemplo de juros de 20%
                    txtResultado.Text = (valorProduto * (1 + juros)).ToString("C");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.");
            }
        }
    }
}
