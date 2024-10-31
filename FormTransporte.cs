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
    public partial class FormTransporte : Form
    {
        public FormTransporte()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }

        private void btnConfirmarTransporte_Click(object sender, EventArgs e)
        {
            string transportesSelecionados = "Transportes selecionados: ";
            if (cbCarro.Checked) transportesSelecionados += "Carro, ";
            if (cbAviao.Checked) transportesSelecionados += "Avião, ";
            if (cbTrem.Checked) transportesSelecionados += "Trem, ";

            txtTransporteResultado.Text = transportesSelecionados.TrimEnd(',', ' ');
        }
    }
}
