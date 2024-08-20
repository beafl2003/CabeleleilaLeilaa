namespace CabeleleilaLeilaa.Views
{
    partial class UsuariosViewModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosViewModel));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tbSenha = new TextBox();
            lbSenha = new Label();
            lbAtivo = new Label();
            cbAtivo = new ComboBox();
            tbNome = new TextBox();
            lbUSer = new Label();
            blTipo = new Label();
            cbTipo = new ComboBox();
            tbCodigo = new TextBox();
            panel2 = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            dtGridUsuarios = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 6);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dtGridUsuarios, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(875, 549);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            tableLayoutPanel1.SetColumnSpan(panel1, 7);
            panel1.Controls.Add(tbSenha);
            panel1.Controls.Add(lbSenha);
            panel1.Controls.Add(lbAtivo);
            panel1.Controls.Add(cbAtivo);
            panel1.Controls.Add(tbNome);
            panel1.Controls.Add(lbUSer);
            panel1.Controls.Add(blTipo);
            panel1.Controls.Add(cbTipo);
            panel1.Controls.Add(tbCodigo);
            panel1.Location = new Point(3, 374);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 5);
            panel1.Size = new Size(869, 172);
            panel1.TabIndex = 13;
            // 
            // tbSenha
            // 
            tbSenha.BackColor = Color.White;
            tbSenha.BorderStyle = BorderStyle.None;
            tbSenha.Location = new Point(86, 74);
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(161, 20);
            tbSenha.TabIndex = 6;
            tbSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(11, 73);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(49, 20);
            lbSenha.TabIndex = 9;
            lbSenha.Text = "Senha";
            // 
            // lbAtivo
            // 
            lbAtivo.AutoSize = true;
            lbAtivo.Location = new Point(615, 73);
            lbAtivo.Name = "lbAtivo";
            lbAtivo.Size = new Size(44, 20);
            lbAtivo.TabIndex = 8;
            lbAtivo.Text = "Ativo";
            // 
            // cbAtivo
            // 
            cbAtivo.FormattingEnabled = true;
            cbAtivo.Location = new Point(678, 70);
            cbAtivo.Name = "cbAtivo";
            cbAtivo.Size = new Size(161, 28);
            cbAtivo.TabIndex = 8;
            // 
            // tbNome
            // 
            tbNome.BackColor = Color.White;
            tbNome.BorderStyle = BorderStyle.None;
            tbNome.Location = new Point(264, 22);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(588, 20);
            tbNome.TabIndex = 5;
            // 
            // lbUSer
            // 
            lbUSer.AutoSize = true;
            lbUSer.Location = new Point(6, 22);
            lbUSer.Name = "lbUSer";
            lbUSer.Size = new Size(59, 20);
            lbUSer.TabIndex = 5;
            lbUSer.Text = "Usuário";
            // 
            // blTipo
            // 
            blTipo.AutoSize = true;
            blTipo.Location = new Point(375, 73);
            blTipo.Name = "blTipo";
            blTipo.Size = new Size(39, 20);
            blTipo.TabIndex = 3;
            blTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(429, 70);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(161, 28);
            cbTipo.TabIndex = 7;
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = Color.White;
            tbCodigo.BorderStyle = BorderStyle.None;
            tbCodigo.Location = new Point(86, 22);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(161, 20);
            tbCodigo.TabIndex = 4;
            tbCodigo.TextChanged += tbNome_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(panel2, 7);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 44);
            panel2.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Location = new Point(458, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Location = new Point(9, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Novo";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Location = new Point(587, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Location = new Point(716, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dtGridUsuarios
            // 
            dtGridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dtGridUsuarios, 7);
            dtGridUsuarios.Location = new Point(3, 83);
            dtGridUsuarios.Name = "dtGridUsuarios";
            dtGridUsuarios.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dtGridUsuarios, 5);
            dtGridUsuarios.Size = new Size(869, 285);
            dtGridUsuarios.TabIndex = 12;
            // 
            // UsuariosViewModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 549);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UsuariosViewModel";
            Text = "Usuários";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbCodigo;
        private DataGridView dtGridUsuarios;
        private Panel panel1;
        private Panel panel2;
        private Button btnSave;
        private Button btnAdd;
        private Button btnCancel;
        private ComboBox cbTipo;
        private Label blTipo;
        private Button btnDelete;
        private Label lbUSer;
        private TextBox tbSenha;
        private Label lbSenha;
        private Label lbAtivo;
        private ComboBox cbAtivo;
        private TextBox tbNome;
    }
}