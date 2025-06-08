namespace ElenilsonDescubraNumeroSequencia
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnJogar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.FromArgb(255, 128, 0);
            btnJogar.Font = new Font("Segoe UI", 12F);
            btnJogar.Location = new Point(566, 182);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(75, 30);
            btnJogar.TabIndex = 0;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = false;
            btnJogar.Click += btnJogar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 128, 0);
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.Location = new Point(566, 252);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 30);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 561);
            Controls.Add(btnSair);
            Controls.Add(btnJogar);
            Name = "Menu";
            Text = "Menu";
            FormClosing += Menu_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnJogar;
        private Button btnSair;
    }
}
