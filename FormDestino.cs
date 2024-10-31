using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Preferências_de_Viagem
{
    public partial class FormDestino : Form
    {
        public FormDestino()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }

        private void btnConfirmarDestino_Click(object sender, EventArgs e)
        {
            string destinoSelecionado = "";
            if (rbPraia.Checked)
                destinoSelecionado = "Praia";
            else if (rbMontanha.Checked)
                destinoSelecionado = "Montanha";
            else if (rbCidade.Checked)
                destinoSelecionado = "Cidade";

            MessageBox.Show($"Destino selecionado: {destinoSelecionado}");
        }
    }
}
