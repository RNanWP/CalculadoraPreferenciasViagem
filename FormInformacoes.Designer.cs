namespace Calculadora_de_Preferências_de_Viagem
{
    partial class FormInformacoes
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
            lblNome = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            btnConfirmarInformacoes = new Button();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 37);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 87);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(13, 139);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(69, 20);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(68, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 3;
            // 
            // btnConfirmarInformacoes
            // 
            btnConfirmarInformacoes.Location = new Point(163, 215);
            btnConfirmarInformacoes.Name = "btnConfirmarInformacoes";
            btnConfirmarInformacoes.Size = new Size(162, 57);
            btnConfirmarInformacoes.TabIndex = 0;
            btnConfirmarInformacoes.Text = "Confirmar";
            btnConfirmarInformacoes.UseVisualStyleBackColor = true;
            btnConfirmarInformacoes.Click += btnConfirmarInformacoes_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(88, 136);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 27);
            txtTelefone.TabIndex = 9;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(387, 238);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(61, 34);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormInformacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 284);
            Controls.Add(btnVoltar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(btnConfirmarInformacoes);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Name = "FormInformacoes";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtNome;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button btnConfirmarInformacoes;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Button btnVoltar;
    }
}