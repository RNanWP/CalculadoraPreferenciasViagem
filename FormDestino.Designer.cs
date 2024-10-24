namespace Calculadora_de_Preferências_de_Viagem
{
    partial class FormDestino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDestino = new Label();
            gbDestino = new GroupBox();
            rbPraia = new RadioButton();
            rbCidade = new RadioButton();
            rbMontanha = new RadioButton();
            btnConfirmarDestino = new Button();
            btnVoltar = new Button();
            gbDestino.SuspendLayout();
            SuspendLayout();
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(12, 35);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(217, 20);
            lblDestino.TabIndex = 0;
            lblDestino.Text = "Escolha o seu destino preferido";
            // 
            // gbDestino
            // 
            gbDestino.Controls.Add(rbPraia);
            gbDestino.Controls.Add(rbCidade);
            gbDestino.Controls.Add(rbMontanha);
            gbDestino.Location = new Point(33, 75);
            gbDestino.Name = "gbDestino";
            gbDestino.Size = new Size(172, 165);
            gbDestino.TabIndex = 1;
            gbDestino.TabStop = false;
            gbDestino.Text = "Agrupa as opções";
            // 
            // rbPraia
            // 
            rbPraia.AutoSize = true;
            rbPraia.Location = new Point(6, 42);
            rbPraia.Name = "rbPraia";
            rbPraia.Size = new Size(63, 24);
            rbPraia.TabIndex = 2;
            rbPraia.TabStop = true;
            rbPraia.Text = "Praia";
            rbPraia.UseVisualStyleBackColor = true;
            // 
            // rbCidade
            // 
            rbCidade.AutoSize = true;
            rbCidade.Location = new Point(6, 135);
            rbCidade.Name = "rbCidade";
            rbCidade.Size = new Size(77, 24);
            rbCidade.TabIndex = 4;
            rbCidade.TabStop = true;
            rbCidade.Text = "Cidade";
            rbCidade.UseVisualStyleBackColor = true;
            // 
            // rbMontanha
            // 
            rbMontanha.AutoSize = true;
            rbMontanha.Location = new Point(6, 90);
            rbMontanha.Name = "rbMontanha";
            rbMontanha.Size = new Size(97, 24);
            rbMontanha.TabIndex = 3;
            rbMontanha.TabStop = true;
            rbMontanha.Text = "Montanha";
            rbMontanha.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarDestino
            // 
            btnConfirmarDestino.Location = new Point(33, 269);
            btnConfirmarDestino.Name = "btnConfirmarDestino";
            btnConfirmarDestino.Size = new Size(169, 62);
            btnConfirmarDestino.TabIndex = 5;
            btnConfirmarDestino.Text = "Confirmar";
            btnConfirmarDestino.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(299, 311);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(61, 25);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormDestino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 348);
            Controls.Add(btnVoltar);
            Controls.Add(btnConfirmarDestino);
            Controls.Add(gbDestino);
            Controls.Add(lblDestino);
            Name = "FormDestino";
            Text = "FormDestino";
            gbDestino.ResumeLayout(false);
            gbDestino.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDestino;
        private GroupBox gbDestino;
        private RadioButton rbPraia;
        private RadioButton rbMontanha;
        private RadioButton rbCidade;
        private Button btnConfirmarDestino;
        private Button btnVoltar;
    }
}