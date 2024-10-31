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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            FormDestino formDestino = new FormDestino();
            this.Hide();
            formDestino.Show();
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            FormTransporte formTransporte = new FormTransporte();
            this.Hide();
            formTransporte.Show();
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            FormInformacoes formInformacoes = new FormInformacoes();
            this.Hide();
            formInformacoes.Show();
        }

        private void btnCalculoDeconto_Click(object sender, EventArgs e)
        {
            FormCalculoDesconto formCalculoDesconto = new FormCalculoDesconto();
            this.Hide();
            formCalculoDesconto.Show();
        }
    }
}
