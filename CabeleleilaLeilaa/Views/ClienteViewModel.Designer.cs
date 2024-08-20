namespace CabeleleilaLeilaa.ChildForms
{
    partial class ClienteViewModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteViewModel));
            tableLayoutPanel1 = new TableLayoutPanel();
            tbCodigo = new TextBox();
            tbNome = new TextBox();
            lbCodigo = new Label();
            lbNome = new Label();
            tbTelefone = new TextBox();
            lbPreco = new Label();
            tbCelular = new TextBox();
            lbCelular = new Label();
            tbEmail = new TextBox();
            lbDuracao = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Sexo = new Label();
            comboBox1 = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 262F));
            tableLayoutPanel1.Controls.Add(tbCodigo, 0, 2);
            tableLayoutPanel1.Controls.Add(tbNome, 1, 2);
            tableLayoutPanel1.Controls.Add(lbCodigo, 0, 1);
            tableLayoutPanel1.Controls.Add(lbNome, 1, 1);
            tableLayoutPanel1.Controls.Add(tbTelefone, 1, 3);
            tableLayoutPanel1.Controls.Add(lbPreco, 2, 3);
            tableLayoutPanel1.Controls.Add(tbCelular, 3, 3);
            tableLayoutPanel1.Controls.Add(lbCelular, 0, 4);
            tableLayoutPanel1.Controls.Add(tbEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(lbDuracao, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 4, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 5, 3);
            tableLayoutPanel1.Controls.Add(Sexo, 2, 4);
            tableLayoutPanel1.Controls.Add(comboBox1, 3, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(800, 225);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = Color.White;
            tbCodigo.BorderStyle = BorderStyle.None;
            tbCodigo.Location = new Point(3, 62);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(84, 20);
            tbCodigo.TabIndex = 0;
            // 
            // tbNome
            // 
            tbNome.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(tbNome, 5);
            tbNome.Location = new Point(93, 62);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(634, 20);
            tbNome.TabIndex = 1;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Location = new Point(3, 29);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(58, 20);
            lbCodigo.TabIndex = 9;
            lbCodigo.Text = "Código";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(93, 29);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(50, 20);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome";
            // 
            // tbTelefone
            // 
            tbTelefone.BorderStyle = BorderStyle.None;
            tbTelefone.Location = new Point(93, 99);
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(124, 20);
            tbTelefone.TabIndex = 4;
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Location = new Point(223, 96);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(55, 20);
            lbPreco.TabIndex = 8;
            lbPreco.Text = "Celular";
            // 
            // tbCelular
            // 
            tbCelular.BorderStyle = BorderStyle.None;
            tbCelular.Location = new Point(286, 99);
            tbCelular.Name = "tbCelular";
            tbCelular.Size = new Size(119, 20);
            tbCelular.TabIndex = 7;
            // 
            // lbCelular
            // 
            lbCelular.AutoSize = true;
            lbCelular.Dock = DockStyle.Right;
            lbCelular.Location = new Point(35, 134);
            lbCelular.Name = "lbCelular";
            lbCelular.Size = new Size(52, 33);
            lbCelular.TabIndex = 10;
            lbCelular.Text = "E-mail";
            lbCelular.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Location = new Point(93, 137);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(124, 20);
            tbEmail.TabIndex = 11;
            // 
            // lbDuracao
            // 
            lbDuracao.AutoSize = true;
            lbDuracao.Dock = DockStyle.Right;
            lbDuracao.Location = new Point(21, 96);
            lbDuracao.Name = "lbDuracao";
            lbDuracao.Size = new Size(66, 38);
            lbDuracao.TabIndex = 5;
            lbDuracao.Text = "Telefone";
            lbDuracao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 96);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 12;
            label1.Text = "Dt. Nascimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(541, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // Sexo
            // 
            Sexo.AutoSize = true;
            Sexo.Location = new Point(223, 134);
            Sexo.Name = "Sexo";
            Sexo.Size = new Size(57, 20);
            Sexo.TabIndex = 15;
            Sexo.Text = "Gënero";
            Sexo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(286, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 28);
            comboBox1.TabIndex = 14;
            // 
            // ClienteViewModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 225);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClienteViewModel";
            Text = "Clientes";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbCodigo;
        private TextBox tbNome;
        private Label lbCodigo;
        private Label lbNome;
        private TextBox tbTelefone;
        private Label lbDuracao;
        private Label lbPreco;
        private TextBox tbCelular;
        private Label lbCelular;
        private TextBox tbEmail;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox1;
        private Label Sexo;
    }
}