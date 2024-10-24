namespace Calculadora_de_Preferências_de_Viagem
{
    partial class FormTransporte
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
            lblTransporte = new Label();
            gbTransporte = new GroupBox();
            cbCarro = new CheckBox();
            cbAviao = new CheckBox();
            cbTrem = new CheckBox();
            btnConfirmarTransporte = new Button();
            txtTransporteResultado = new TextBox();
            gbTransporte.SuspendLayout();
            SuspendLayout();
            // 
            // lblTransporte
            // 
            lblTransporte.AutoSize = true;
            lblTransporte.Location = new Point(12, 31);
            lblTransporte.Name = "lblTransporte";
            lblTransporte.Size = new Size(229, 20);
            lblTransporte.TabIndex = 0;
            lblTransporte.Text = "Selecione os meios de transporte";
            // 
            // gbTransporte
            // 
            gbTransporte.Controls.Add(cbCarro);
            gbTransporte.Controls.Add(cbAviao);
            gbTransporte.Controls.Add(cbTrem);
            gbTransporte.Location = new Point(23, 66);
            gbTransporte.Name = "gbTransporte";
            gbTransporte.Size = new Size(171, 125);
            gbTransporte.TabIndex = 1;
            gbTransporte.TabStop = false;
            gbTransporte.Text = "Agrupa as opções de transporte";
            // 
            // cbCarro
            // 
            cbCarro.AutoSize = true;
            cbCarro.Location = new Point(11, 26);
            cbCarro.Name = "cbCarro";
            cbCarro.Size = new Size(67, 24);
            cbCarro.TabIndex = 0;
            cbCarro.Text = "Carro";
            cbCarro.UseVisualStyleBackColor = true;
            // 
            // cbAviao
            // 
            cbAviao.AutoSize = true;
            cbAviao.Location = new Point(11, 56);
            cbAviao.Name = "cbAviao";
            cbAviao.Size = new Size(69, 24);
            cbAviao.TabIndex = 2;
            cbAviao.Text = "Avião";
            cbAviao.UseVisualStyleBackColor = true;
            // 
            // cbTrem
            // 
            cbTrem.AutoSize = true;
            cbTrem.Location = new Point(11, 86);
            cbTrem.Name = "cbTrem";
            cbTrem.Size = new Size(64, 24);
            cbTrem.TabIndex = 3;
            cbTrem.Text = "Trem";
            cbTrem.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarTransporte
            // 
            btnConfirmarTransporte.Location = new Point(254, 109);
            btnConfirmarTransporte.Name = "btnConfirmarTransporte";
            btnConfirmarTransporte.Size = new Size(128, 48);
            btnConfirmarTransporte.TabIndex = 4;
            btnConfirmarTransporte.Text = "Confirmar";
            btnConfirmarTransporte.UseVisualStyleBackColor = true;
            // 
            // txtTransporteResultado
            // 
            txtTransporteResultado.Location = new Point(104, 220);
            txtTransporteResultado.Name = "txtTransporteResultado";
            txtTransporteResultado.Size = new Size(229, 27);
            txtTransporteResultado.TabIndex = 5;
            txtTransporteResultado.Text = "Exibe os transportes selecionados";
            // 
            // FormTransporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 276);
            Controls.Add(txtTransporteResultado);
            Controls.Add(btnConfirmarTransporte);
            Controls.Add(gbTransporte);
            Controls.Add(lblTransporte);
            Name = "FormTransporte";
            Text = "Form3";
            Load += this.FormTransporte_Load;
            gbTransporte.ResumeLayout(false);
            gbTransporte.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransporte;
        private GroupBox gbTransporte;
        private CheckBox cbCarro;
        private CheckBox cbAviao;
        private CheckBox cbTrem;
        private Button btnConfirmarTransporte;
        private TextBox txtTransporteResultado;
    }
}