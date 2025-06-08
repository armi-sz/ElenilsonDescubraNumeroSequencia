namespace ElenilsonDescubraNumeroSequencia
{
    partial class Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            btnAzul = new Button();
            btnVermelho = new Button();
            btnLaranja = new Button();
            btnVerde = new Button();
            btnRoxo = new Button();
            lblPergunta = new Label();
            lblAcertos = new Label();
            lblErros = new Label();
            lblNumerosAcertos = new Label();
            lblNumerosErros = new Label();
            btnVerificar = new Button();
            txtNumeroSugerido = new TextBox();
            SuspendLayout();
            // 
            // btnAzul
            // 
            btnAzul.BackColor = Color.Blue;
            btnAzul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAzul.ForeColor = Color.White;
            btnAzul.Location = new Point(154, 109);
            btnAzul.Name = "btnAzul";
            btnAzul.Size = new Size(75, 63);
            btnAzul.TabIndex = 0;
            btnAzul.UseVisualStyleBackColor = false;
            // 
            // btnVermelho
            // 
            btnVermelho.BackColor = Color.Red;
            btnVermelho.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnVermelho.ForeColor = Color.White;
            btnVermelho.Location = new Point(261, 109);
            btnVermelho.Name = "btnVermelho";
            btnVermelho.Size = new Size(75, 63);
            btnVermelho.TabIndex = 1;
            btnVermelho.UseVisualStyleBackColor = false;
            // 
            // btnLaranja
            // 
            btnLaranja.BackColor = Color.FromArgb(255, 128, 0);
            btnLaranja.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLaranja.ForeColor = Color.White;
            btnLaranja.Location = new Point(368, 109);
            btnLaranja.Name = "btnLaranja";
            btnLaranja.Size = new Size(75, 63);
            btnLaranja.TabIndex = 2;
            btnLaranja.UseVisualStyleBackColor = false;
            // 
            // btnVerde
            // 
            btnVerde.BackColor = Color.FromArgb(0, 192, 0);
            btnVerde.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnVerde.ForeColor = Color.White;
            btnVerde.Location = new Point(475, 109);
            btnVerde.Name = "btnVerde";
            btnVerde.Size = new Size(75, 63);
            btnVerde.TabIndex = 3;
            btnVerde.UseVisualStyleBackColor = false;
            // 
            // btnRoxo
            // 
            btnRoxo.BackColor = Color.FromArgb(192, 0, 192);
            btnRoxo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRoxo.ForeColor = Color.White;
            btnRoxo.Location = new Point(582, 109);
            btnRoxo.Name = "btnRoxo";
            btnRoxo.Size = new Size(75, 63);
            btnRoxo.TabIndex = 4;
            btnRoxo.UseVisualStyleBackColor = false;
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.BackColor = Color.Transparent;
            lblPergunta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(353, 231);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(304, 19);
            lblPergunta.TabIndex = 5;
            lblPergunta.Text = "Qual o próximo número da sequência?";
            // 
            // lblAcertos
            // 
            lblAcertos.AutoSize = true;
            lblAcertos.BackColor = Color.Transparent;
            lblAcertos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcertos.ForeColor = Color.Red;
            lblAcertos.Location = new Point(342, 326);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(74, 19);
            lblAcertos.TabIndex = 6;
            lblAcertos.Text = "Acertos:";
            // 
            // lblErros
            // 
            lblErros.AutoSize = true;
            lblErros.BackColor = Color.Transparent;
            lblErros.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErros.ForeColor = Color.Red;
            lblErros.Location = new Point(359, 361);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(57, 19);
            lblErros.TabIndex = 7;
            lblErros.Text = "Erros:";
            // 
            // lblNumerosAcertos
            // 
            lblNumerosAcertos.AutoSize = true;
            lblNumerosAcertos.BackColor = Color.Transparent;
            lblNumerosAcertos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumerosAcertos.ForeColor = Color.Blue;
            lblNumerosAcertos.Location = new Point(422, 326);
            lblNumerosAcertos.Name = "lblNumerosAcertos";
            lblNumerosAcertos.Size = new Size(18, 19);
            lblNumerosAcertos.TabIndex = 8;
            lblNumerosAcertos.Text = "0";
            // 
            // lblNumerosErros
            // 
            lblNumerosErros.AutoSize = true;
            lblNumerosErros.BackColor = Color.Transparent;
            lblNumerosErros.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumerosErros.ForeColor = Color.Blue;
            lblNumerosErros.Location = new Point(422, 361);
            lblNumerosErros.Name = "lblNumerosErros";
            lblNumerosErros.Size = new Size(18, 19);
            lblNumerosErros.TabIndex = 9;
            lblNumerosErros.Text = "0";
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(255, 128, 0);
            btnVerificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(524, 267);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(87, 30);
            btnVerificar.TabIndex = 10;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtNumeroSugerido
            // 
            txtNumeroSugerido.Location = new Point(439, 271);
            txtNumeroSugerido.Name = "txtNumeroSugerido";
            txtNumeroSugerido.Size = new Size(57, 23);
            txtNumeroSugerido.TabIndex = 11;
            // 
            // Jogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 561);
            Controls.Add(txtNumeroSugerido);
            Controls.Add(btnVerificar);
            Controls.Add(lblNumerosErros);
            Controls.Add(lblNumerosAcertos);
            Controls.Add(lblErros);
            Controls.Add(lblAcertos);
            Controls.Add(lblPergunta);
            Controls.Add(btnRoxo);
            Controls.Add(btnVerde);
            Controls.Add(btnLaranja);
            Controls.Add(btnVermelho);
            Controls.Add(btnAzul);
            Name = "Jogo";
            Text = "Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAzul;
        private Button btnVermelho;
        private Button btnLaranja;
        private Button btnVerde;
        private Button btnRoxo;
        private Label lblPergunta;
        private Label lblAcertos;
        private Label lblErros;
        private Label lblNumerosAcertos;
        private Label lblNumerosErros;
        private Button btnVerificar;
        private TextBox txtNumeroSugerido;
    }
}