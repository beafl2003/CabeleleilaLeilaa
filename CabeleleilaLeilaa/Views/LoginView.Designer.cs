namespace CabeleleilaLeilaa.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            Leila = new Label();
            label1 = new Label();
            lbNome = new Label();
            tbUsuario = new TextBox();
            lbSenha = new Label();
            tbSenha = new TextBox();
            btnLogin = new Button();
            btnSair = new Button();
            btnOlho = new Button();
            pbTesoura = new PictureBox();
            pbPente = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbTesoura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPente).BeginInit();
            SuspendLayout();
            // 
            // Leila
            // 
            Leila.AutoSize = true;
            Leila.BackColor = Color.Transparent;
            Leila.Font = new Font("Bell MT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Leila.ForeColor = Color.FromArgb(255, 102, 196);
            Leila.Location = new Point(69, 73);
            Leila.Margin = new Padding(4, 0, 4, 0);
            Leila.Name = "Leila";
            Leila.Size = new Size(200, 90);
            Leila.TabIndex = 3;
            Leila.Text = "Leila";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Handwriting", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(248, 176, 230);
            label1.Location = new Point(165, 163);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 40);
            label1.TabIndex = 4;
            label1.Text = "Cabeleleia";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Century Gothic", 10.2F);
            lbNome.Location = new Point(69, 261);
            lbNome.Margin = new Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(75, 21);
            lbNome.TabIndex = 5;
            lbNome.Text = "Usuário:";
            // 
            // tbUsuario
            // 
            tbUsuario.BorderStyle = BorderStyle.FixedSingle;
            tbUsuario.Location = new Point(69, 296);
            tbUsuario.Margin = new Padding(4, 3, 4, 3);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(344, 28);
            tbUsuario.TabIndex = 6;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(69, 345);
            lbSenha.Margin = new Padding(4, 0, 4, 0);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(66, 21);
            lbSenha.TabIndex = 7;
            lbSenha.Text = "Senha:";
            // 
            // tbSenha
            // 
            tbSenha.BorderStyle = BorderStyle.FixedSingle;
            tbSenha.Location = new Point(69, 370);
            tbSenha.Margin = new Padding(4, 3, 4, 3);
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(344, 28);
            tbSenha.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(248, 176, 230);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(69, 429);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(344, 46);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 102, 196);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(69, 482);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(344, 46);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // btnOlho
            // 
            btnOlho.BackColor = Color.Transparent;
            btnOlho.FlatAppearance.BorderSize = 0;
            btnOlho.FlatStyle = FlatStyle.Flat;
            btnOlho.Image = Properties.Resources.olinhoaberto;
            btnOlho.Location = new Point(372, 375);
            btnOlho.Name = "btnOlho";
            btnOlho.Size = new Size(37, 17);
            btnOlho.TabIndex = 11;
            btnOlho.UseVisualStyleBackColor = false;
            // 
            // pbTesoura
            // 
            pbTesoura.BackColor = Color.Transparent;
            pbTesoura.Image = Properties.Resources.tesoura;
            pbTesoura.Location = new Point(276, 73);
            pbTesoura.Name = "pbTesoura";
            pbTesoura.Size = new Size(125, 90);
            pbTesoura.TabIndex = 12;
            pbTesoura.TabStop = false;
            // 
            // pbPente
            // 
            pbPente.BackColor = Color.Transparent;
            pbPente.Image = Properties.Resources.pente;
            pbPente.Location = new Point(69, 151);
            pbPente.Name = "pbPente";
            pbPente.Size = new Size(99, 90);
            pbPente.TabIndex = 13;
            pbPente.TabStop = false;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(497, 634);
            Controls.Add(pbPente);
            Controls.Add(pbTesoura);
            Controls.Add(btnOlho);
            Controls.Add(btnSair);
            Controls.Add(btnLogin);
            Controls.Add(tbSenha);
            Controls.Add(lbSenha);
            Controls.Add(tbUsuario);
            Controls.Add(lbNome);
            Controls.Add(label1);
            Controls.Add(Leila);
            Font = new Font("Century Gothic", 10.2F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginView";
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)pbTesoura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Leila;
        private Label label1;
        private Label lbNome;
        private TextBox textBox1;
        private Label lbSenha;
        private TextBox textBox2;
        private Button button2;
        private TextBox tbUsuario;
        private TextBox tbSenha;
        private Button btnLogin;
        private Button btnSair;
        private Button btnOlho;
        private PictureBox pbTesoura;
        private PictureBox pbPente;
    }
}