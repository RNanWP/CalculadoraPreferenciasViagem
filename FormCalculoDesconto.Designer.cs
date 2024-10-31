namespace Calculadora_de_Preferências_de_Viagem
{
    partial class FormCalculoDesconto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblValor = new Label();
            lblParcelas = new Label();
            txtValorProduto = new TextBox();
            rbAVista = new RadioButton();
            rbAte3Parcelas = new RadioButton();
            rb4a12Parcelas = new RadioButton();
            gbParcelamento = new GroupBox();
            btnCalcularDesconto = new Button();
            txtResultado = new TextBox();
            btnVoltar = new Button();
            gbParcelamento.SuspendLayout();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(26, 47);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(183, 20);
            lblValor.TabIndex = 0;
            lblValor.Text = "Digite o valor do produto:";
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.Location = new Point(26, 121);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(234, 20);
            lblParcelas.TabIndex = 1;
            lblParcelas.Text = "Escolha a quantidade de parcelas:";
            lblParcelas.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(215, 47);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(267, 27);
            txtValorProduto.TabIndex = 2;
            txtValorProduto.Text = "Campo para inserir o valor do produto";
            // 
            // rbAVista
            // 
            rbAVista.AutoSize = true;
            rbAVista.Location = new Point(6, 35);
            rbAVista.Name = "rbAVista";
            rbAVista.Size = new Size(225, 24);
            rbAVista.TabIndex = 3;
            rbAVista.TabStop = true;
            rbAVista.Text = "À vista com 10% de desconto";
            rbAVista.UseVisualStyleBackColor = true;
            // 
            // rbAte3Parcelas
            // 
            rbAte3Parcelas.AutoSize = true;
            rbAte3Parcelas.Location = new Point(6, 87);
            rbAte3Parcelas.Name = "rbAte3Parcelas";
            rbAte3Parcelas.Size = new Size(220, 24);
            rbAte3Parcelas.TabIndex = 4;
            rbAte3Parcelas.TabStop = true;
            rbAte3Parcelas.Text = "Até 3 parcelas sem desconto";
            rbAte3Parcelas.UseVisualStyleBackColor = true;
            // 
            // rb4a12Parcelas
            // 
            rb4a12Parcelas.AutoSize = true;
            rb4a12Parcelas.Location = new Point(5, 140);
            rb4a12Parcelas.Name = "rb4a12Parcelas";
            rb4a12Parcelas.Size = new Size(282, 24);
            rb4a12Parcelas.TabIndex = 5;
            rb4a12Parcelas.TabStop = true;
            rb4a12Parcelas.Text = "Entre 4 e 12 parcelas com juros de X%";
            rb4a12Parcelas.UseVisualStyleBackColor = true;
            rb4a12Parcelas.CheckedChanged += rba12Parcerlas_CheckedChanged;
            // 
            // gbParcelamento
            // 
            gbParcelamento.Controls.Add(rbAVista);
            gbParcelamento.Controls.Add(rb4a12Parcelas);
            gbParcelamento.Controls.Add(rbAte3Parcelas);
            gbParcelamento.Location = new Point(266, 121);
            gbParcelamento.Name = "gbParcelamento";
            gbParcelamento.Size = new Size(302, 170);
            gbParcelamento.TabIndex = 6;
            gbParcelamento.TabStop = false;
            gbParcelamento.Text = "Agrupar as opções de pagamento";
            // 
            // btnCalcularDesconto
            // 
            btnCalcularDesconto.Location = new Point(51, 181);
            btnCalcularDesconto.Name = "btnCalcularDesconto";
            btnCalcularDesconto.Size = new Size(148, 51);
            btnCalcularDesconto.TabIndex = 7;
            btnCalcularDesconto.Text = "Calcular Desconto";
            btnCalcularDesconto.UseVisualStyleBackColor = true;
            btnCalcularDesconto.Click += btnCalcularDesconto_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(45, 333);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(215, 27);
            txtResultado.TabIndex = 8;
            txtResultado.Text = "Exibe o valor final a ser pago";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(536, 344);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(61, 34);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCalculoDesconto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 390);
            Controls.Add(btnVoltar);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcularDesconto);
            Controls.Add(gbParcelamento);
            Controls.Add(txtValorProduto);
            Controls.Add(lblParcelas);
            Controls.Add(lblValor);
            Name = "FormCalculoDesconto";
            Text = "Form1";
            gbParcelamento.ResumeLayout(false);
            gbParcelamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private Label lblParcelas;
        private TextBox txtValorProduto;
        private RadioButton rbAVista;
        private RadioButton rbAte3Parcelas;
        private RadioButton rb4a12Parcelas;
        private GroupBox gbParcelamento;
        private Button btnCalcularDesconto;
        private TextBox txtResultado;
        private Button btnVoltar;
    }
}
