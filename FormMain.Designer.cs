namespace Calculadora_de_Preferências_de_Viagem
{
    partial class FormMain
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
            btnDestino = new Button();
            btnTransporte = new Button();
            btnInformacoes = new Button();
            btnCalculoDeconto = new Button();
            SuspendLayout();
            // 
            // btnDestino
            // 
            btnDestino.Location = new Point(12, 12);
            btnDestino.Name = "btnDestino";
            btnDestino.Size = new Size(171, 84);
            btnDestino.TabIndex = 0;
            btnDestino.Text = "Destino";
            btnDestino.UseVisualStyleBackColor = true;
            btnDestino.Click += btnDestino_Click;
            // 
            // btnTransporte
            // 
            btnTransporte.Location = new Point(213, 12);
            btnTransporte.Name = "btnTransporte";
            btnTransporte.Size = new Size(171, 84);
            btnTransporte.TabIndex = 1;
            btnTransporte.Text = "Transporte";
            btnTransporte.UseVisualStyleBackColor = true;
            // 
            // btnInformacoes
            // 
            btnInformacoes.Location = new Point(12, 116);
            btnInformacoes.Name = "btnInformacoes";
            btnInformacoes.Size = new Size(171, 84);
            btnInformacoes.TabIndex = 2;
            btnInformacoes.Text = "Informações Pessoais";
            btnInformacoes.UseVisualStyleBackColor = true;
            // 
            // btnCalculoDeconto
            // 
            btnCalculoDeconto.Location = new Point(213, 116);
            btnCalculoDeconto.Name = "btnCalculoDeconto";
            btnCalculoDeconto.Size = new Size(171, 84);
            btnCalculoDeconto.TabIndex = 3;
            btnCalculoDeconto.Text = "Cálculo de Desconto";
            btnCalculoDeconto.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 217);
            Controls.Add(btnCalculoDeconto);
            Controls.Add(btnInformacoes);
            Controls.Add(btnTransporte);
            Controls.Add(btnDestino);
            Name = "FormMain";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDestino;
        private Button btnTransporte;
        private Button btnInformacoes;
        private Button btnCalculoDeconto;
    }
}