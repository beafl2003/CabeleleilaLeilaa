namespace CabeleleilaLeilaa
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pbHeartUser = new PictureBox();
            btnPerfil = new Button();
            pbHeart = new PictureBox();
            btnAdministrativo = new Button();
            btnGerencial = new Button();
            btnClientes = new Button();
            btnServicos = new Button();
            btnAgendar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            Leila = new Label();
            panel2 = new Panel();
            lbBoasVindas = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeartUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbHeartUser);
            panel1.Controls.Add(btnPerfil);
            panel1.Controls.Add(pbHeart);
            panel1.Controls.Add(btnAdministrativo);
            panel1.Controls.Add(btnGerencial);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnServicos);
            panel1.Controls.Add(btnAgendar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 734);
            panel1.TabIndex = 0;
            // 
            // pbHeartUser
            // 
            pbHeartUser.Anchor = AnchorStyles.Bottom;
            pbHeartUser.Image = (Image)resources.GetObject("pbHeartUser.Image");
            pbHeartUser.Location = new Point(106, 587);
            pbHeartUser.Name = "pbHeartUser";
            pbHeartUser.Size = new Size(44, 59);
            pbHeartUser.TabIndex = 8;
            pbHeartUser.TabStop = false;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.FlatAppearance.BorderColor = Color.FromArgb(248, 176, 230);
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerfil.ForeColor = Color.FromArgb(248, 176, 230);
            btnPerfil.Image = (Image)resources.GetObject("btnPerfil.Image");
            btnPerfil.ImageAlign = ContentAlignment.TopCenter;
            btnPerfil.Location = new Point(12, 431);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Padding = new Padding(1);
            btnPerfil.Size = new Size(220, 93);
            btnPerfil.TabIndex = 7;
            btnPerfil.Text = "Meu Perfil";
            btnPerfil.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // pbHeart
            // 
            pbHeart.Anchor = AnchorStyles.Top;
            pbHeart.Image = (Image)resources.GetObject("pbHeart.Image");
            pbHeart.Location = new Point(106, 135);
            pbHeart.Name = "pbHeart";
            pbHeart.Size = new Size(44, 39);
            pbHeart.TabIndex = 0;
            pbHeart.TabStop = false;
            // 
            // btnAdministrativo
            // 
            btnAdministrativo.BackColor = Color.Transparent;
            btnAdministrativo.FlatAppearance.BorderColor = Color.FromArgb(248, 176, 230);
            btnAdministrativo.FlatAppearance.BorderSize = 0;
            btnAdministrativo.FlatStyle = FlatStyle.Flat;
            btnAdministrativo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdministrativo.ForeColor = Color.FromArgb(248, 176, 230);
            btnAdministrativo.Image = (Image)resources.GetObject("btnAdministrativo.Image");
            btnAdministrativo.ImageAlign = ContentAlignment.TopCenter;
            btnAdministrativo.Location = new Point(12, 629);
            btnAdministrativo.Name = "btnAdministrativo";
            btnAdministrativo.Size = new Size(220, 93);
            btnAdministrativo.TabIndex = 6;
            btnAdministrativo.Text = "Usuários";
            btnAdministrativo.TextAlign = ContentAlignment.BottomCenter;
            btnAdministrativo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdministrativo.UseVisualStyleBackColor = false;
            // 
            // btnGerencial
            // 
            btnGerencial.BackColor = Color.Transparent;
            btnGerencial.FlatAppearance.BorderColor = Color.FromArgb(248, 176, 230);
            btnGerencial.FlatAppearance.BorderSize = 0;
            btnGerencial.FlatStyle = FlatStyle.Flat;
            btnGerencial.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerencial.ForeColor = Color.FromArgb(255, 102, 196);
            btnGerencial.Image = (Image)resources.GetObject("btnGerencial.Image");
            btnGerencial.ImageAlign = ContentAlignment.TopCenter;
            btnGerencial.Location = new Point(12, 530);
            btnGerencial.Name = "btnGerencial";
            btnGerencial.Size = new Size(220, 93);
            btnGerencial.TabIndex = 5;
            btnGerencial.Text = "Gerencial";
            btnGerencial.TextAlign = ContentAlignment.BottomCenter;
            btnGerencial.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGerencial.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.FlatAppearance.BorderColor = Color.FromArgb(248, 176, 230);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.FromArgb(248, 176, 230);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.TopCenter;
            btnClientes.Location = new Point(15, 431);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(1);
            btnClientes.Size = new Size(220, 93);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnServicos
            // 
            btnServicos.BackColor = Color.Transparent;
            btnServicos.FlatAppearance.BorderColor = Color.FromArgb(248, 176, 230);
            btnServicos.FlatAppearance.BorderSize = 0;
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServicos.ForeColor = Color.FromArgb(255, 102, 196);
            btnServicos.Image = (Image)resources.GetObject("btnServicos.Image");
            btnServicos.ImageAlign = ContentAlignment.TopCenter;
            btnServicos.Location = new Point(15, 302);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(220, 93);
            btnServicos.TabIndex = 3;
            btnServicos.Text = "Serviços";
            btnServicos.TextAlign = ContentAlignment.BottomCenter;
            btnServicos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnServicos.UseVisualStyleBackColor = false;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.Transparent;
            btnAgendar.FlatAppearance.BorderColor = Color.FromArgb(248, 176, 230);
            btnAgendar.FlatAppearance.BorderSize = 0;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = Color.FromArgb(248, 176, 230);
            btnAgendar.Image = (Image)resources.GetObject("btnAgendar.Image");
            btnAgendar.ImageAlign = ContentAlignment.TopCenter;
            btnAgendar.Location = new Point(12, 190);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Padding = new Padding(1);
            btnAgendar.Size = new Size(220, 93);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar";
            btnAgendar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgendar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 102, 196);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(Leila);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 107);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Handwriting", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 64);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 3;
            label1.Text = "Cabeleleia";
            // 
            // Leila
            // 
            Leila.AutoSize = true;
            Leila.BackColor = Color.Transparent;
            Leila.Font = new Font("Bell MT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Leila.ForeColor = Color.White;
            Leila.Location = new Point(12, 9);
            Leila.Name = "Leila";
            Leila.Size = new Size(152, 69);
            Leila.TabIndex = 2;
            Leila.Text = "Leila";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(lbBoasVindas);
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 48);
            panel2.TabIndex = 2;
            // 
            // lbBoasVindas
            // 
            lbBoasVindas.AutoSize = true;
            lbBoasVindas.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lbBoasVindas.ForeColor = Color.White;
            lbBoasVindas.Location = new Point(19, 14);
            lbBoasVindas.Name = "lbBoasVindas";
            lbBoasVindas.Size = new Size(115, 23);
            lbBoasVindas.TabIndex = 0;
            lbBoasVindas.Text = "Olá Anna! ";
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1202, 734);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "Cabeleleia Leia";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHeartUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripMenuItem minhaContaToolStripMenuItem;
        private ToolStripMenuItem minhaContaToolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem históricoAgendamentosToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem gerencialToolStripMenuItem;
        private Panel panel1;
        private Panel panel3;
        private Label Leila;
        private Label label1;
        private Button btnAgendar;
        private Button btnServicos;
        private Button btnAdministrativo;
        private Button btnGerencial;
        private Button btnClientes;
        private PictureBox pbHeart;
        private Panel panel2;
        private Label lbBoasVindas;
        private Button btnPerfil;
        private PictureBox pbHeartUser;
    }
}
