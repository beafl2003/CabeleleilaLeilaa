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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnDeletar = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            dtGridClientes = new DataGridView();
            panel1 = new Panel();
            tbCell = new TextBox();
            lbEmail = new Label();
            lbAtivo = new Label();
            cbAtivo = new ComboBox();
            tbNome = new TextBox();
            lbCode = new Label();
            tbCodigo = new TextBox();
            lbNasc = new Label();
            dtNasc = new DateTimePicker();
            tbEmail = new TextBox();
            lbCell = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridClientes).BeginInit();
            panel1.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(panel1, 0, 14);
            tableLayoutPanel1.Controls.Add(dtGridClientes, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(821, 545);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(panel2, 7);
            panel2.Controls.Add(btnDeletar);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 48);
            panel2.TabIndex = 15;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Location = new Point(1073, 9);
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
            btnCancel.Location = new Point(1202, 9);
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
            btnSave.Location = new Point(1331, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.Location = new Point(417, 8);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(123, 29);
            btnDeletar.TabIndex = 4;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(546, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Location = new Point(675, 8);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(123, 29);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dtGridClientes
            // 
            dtGridClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dtGridClientes, 7);
            dtGridClientes.Location = new Point(3, 57);
            dtGridClientes.Name = "dtGridClientes";
            dtGridClientes.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dtGridClientes, 13);
            dtGridClientes.Size = new Size(815, 345);
            dtGridClientes.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            tableLayoutPanel1.SetColumnSpan(panel1, 7);
            panel1.Controls.Add(lbCell);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lbNasc);
            panel1.Controls.Add(dtNasc);
            panel1.Controls.Add(tbCell);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(lbAtivo);
            panel1.Controls.Add(cbAtivo);
            panel1.Controls.Add(tbNome);
            panel1.Controls.Add(lbCode);
            panel1.Controls.Add(tbCodigo);
            panel1.Location = new Point(3, 408);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 7);
            panel1.Size = new Size(815, 134);
            panel1.TabIndex = 17;
            // 
            // tbCell
            // 
            tbCell.BackColor = Color.White;
            tbCell.BorderStyle = BorderStyle.None;
            tbCell.Location = new Point(86, 59);
            tbCell.Name = "tbCell";
            tbCell.Size = new Size(161, 20);
            tbCell.TabIndex = 6;
            tbCell.UseSystemPasswordChar = true;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(9, 94);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(52, 20);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "E-mail";
            // 
            // lbAtivo
            // 
            lbAtivo.AutoSize = true;
            lbAtivo.Location = new Point(634, 58);
            lbAtivo.Name = "lbAtivo";
            lbAtivo.Size = new Size(44, 20);
            lbAtivo.TabIndex = 8;
            lbAtivo.Text = "Ativo";
            // 
            // cbAtivo
            // 
            cbAtivo.FormattingEnabled = true;
            cbAtivo.Location = new Point(678, 55);
            cbAtivo.Name = "cbAtivo";
            cbAtivo.Size = new Size(108, 28);
            cbAtivo.TabIndex = 8;
            // 
            // tbNome
            // 
            tbNome.BackColor = Color.White;
            tbNome.BorderStyle = BorderStyle.None;
            tbNome.Location = new Point(264, 22);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(534, 20);
            tbNome.TabIndex = 5;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(6, 22);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(58, 20);
            lbCode.TabIndex = 5;
            lbCode.Text = "Código";
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = Color.White;
            tbCodigo.BorderStyle = BorderStyle.None;
            tbCodigo.Location = new Point(86, 22);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(161, 20);
            tbCodigo.TabIndex = 4;
            // 
            // lbNasc
            // 
            lbNasc.AutoSize = true;
            lbNasc.Location = new Point(253, 53);
            lbNasc.Name = "lbNasc";
            lbNasc.Size = new Size(111, 20);
            lbNasc.TabIndex = 14;
            lbNasc.Text = "Dt. Nascimento";
            // 
            // dtNasc
            // 
            dtNasc.Location = new Point(383, 56);
            dtNasc.Name = "dtNasc";
            dtNasc.Size = new Size(227, 27);
            dtNasc.TabIndex = 15;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Location = new Point(86, 94);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(161, 20);
            tbEmail.TabIndex = 16;
            // 
            // lbCell
            // 
            lbCell.AutoSize = true;
            lbCell.Location = new Point(9, 59);
            lbCell.Name = "lbCell";
            lbCell.Size = new Size(55, 20);
            lbCell.TabIndex = 17;
            lbCell.Text = "Celular";
            // 
            // ClienteViewModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 545);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClienteViewModel";
            Text = "Clientes";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDeletar;
        private Button btnCancelar;
        private Button btnSalvar;
        private DataGridView dtGridClientes;
        private Panel panel1;
        private Label lbCell;
        private TextBox tbEmail;
        private Label lbNasc;
        private DateTimePicker dtNasc;
        private TextBox tbCell;
        private Label lbEmail;
        private Label lbAtivo;
        private ComboBox cbAtivo;
        private TextBox tbNome;
        private Label lbCode;
        private TextBox tbCodigo;
    }
}