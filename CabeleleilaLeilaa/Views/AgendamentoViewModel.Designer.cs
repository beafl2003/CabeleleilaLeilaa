namespace CabeleleilaLeilaa.ChildForms
{
    partial class AgendamentoViewModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendamentoViewModel));
            tableLayoutPanel1 = new TableLayoutPanel();
            dtGridAgendamentos = new DataGridView();
            cbStatus = new ComboBox();
            tbCodigo = new TextBox();
            tbNome = new TextBox();
            lbNumero = new Label();
            lbNome = new Label();
            panel2 = new Panel();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lbValorTotal = new Label();
            tbVlTotal = new TextBox();
            tbServicoDescricao = new TextBox();
            tbCdServico = new TextBox();
            lbServico = new Label();
            lbDtCriacao = new Label();
            tbData = new TextBox();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridAgendamentos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 236F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel1.Controls.Add(dtGridAgendamentos, 0, 5);
            tableLayoutPanel1.Controls.Add(cbStatus, 6, 4);
            tableLayoutPanel1.Controls.Add(tbCodigo, 0, 4);
            tableLayoutPanel1.Controls.Add(tbNome, 1, 4);
            tableLayoutPanel1.Controls.Add(lbNumero, 0, 3);
            tableLayoutPanel1.Controls.Add(lbNome, 1, 3);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 7);
            tableLayoutPanel1.Controls.Add(lbDtCriacao, 5, 3);
            tableLayoutPanel1.Controls.Add(tbData, 6, 3);
            tableLayoutPanel1.Controls.Add(label2, 5, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
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
            tableLayoutPanel1.Size = new Size(1031, 584);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // dtGridAgendamentos
            // 
            dtGridAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dtGridAgendamentos, 7);
            dtGridAgendamentos.Dock = DockStyle.Fill;
            dtGridAgendamentos.Location = new Point(3, 126);
            dtGridAgendamentos.Name = "dtGridAgendamentos";
            dtGridAgendamentos.RowHeadersWidth = 51;
            dtGridAgendamentos.Size = new Size(1025, 294);
            dtGridAgendamentos.TabIndex = 12;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(847, 89);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(181, 28);
            cbStatus.TabIndex = 14;
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = Color.MistyRose;
            tbCodigo.BorderStyle = BorderStyle.None;
            tbCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCodigo.ForeColor = Color.RosyBrown;
            tbCodigo.Location = new Point(3, 89);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(189, 20);
            tbCodigo.TabIndex = 0;
            tbCodigo.Text = " Enter para buscar";
            // 
            // tbNome
            // 
            tbNome.BackColor = Color.White;
            tbNome.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(tbNome, 4);
            tbNome.Location = new Point(198, 89);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(548, 20);
            tbNome.TabIndex = 1;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(3, 57);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(63, 20);
            lbNumero.TabIndex = 9;
            lbNumero.Text = "Número";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(198, 57);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(55, 20);
            lbNome.TabIndex = 3;
            lbNome.Text = "Cliente";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(panel2, 7);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            tableLayoutPanel1.SetRowSpan(panel2, 3);
            panel2.Size = new Size(1025, 42);
            panel2.TabIndex = 15;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Location = new Point(608, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Location = new Point(872, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Location = new Point(740, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Location = new Point(6, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Novo";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            tableLayoutPanel1.SetColumnSpan(panel1, 7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbValorTotal);
            panel1.Controls.Add(tbVlTotal);
            panel1.Controls.Add(tbServicoDescricao);
            panel1.Controls.Add(tbCdServico);
            panel1.Controls.Add(lbServico);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 434);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 5);
            panel1.Size = new Size(1025, 147);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 57);
            label1.Name = "label1";
            label1.Size = new Size(500, 20);
            label1.TabIndex = 13;
            label1.Text = "Digite o código do serviço, ao sair do campo a descrição será preenchida.";
            // 
            // lbValorTotal
            // 
            lbValorTotal.AutoSize = true;
            lbValorTotal.Location = new Point(777, 112);
            lbValorTotal.Name = "lbValorTotal";
            lbValorTotal.Size = new Size(62, 20);
            lbValorTotal.TabIndex = 12;
            lbValorTotal.Text = "Vl. Total";
            // 
            // tbVlTotal
            // 
            tbVlTotal.BackColor = Color.White;
            tbVlTotal.BorderStyle = BorderStyle.None;
            tbVlTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbVlTotal.ForeColor = Color.RoyalBlue;
            tbVlTotal.Location = new Point(852, 112);
            tbVlTotal.Name = "tbVlTotal";
            tbVlTotal.Size = new Size(161, 20);
            tbVlTotal.TabIndex = 11;
            // 
            // tbServicoDescricao
            // 
            tbServicoDescricao.BackColor = Color.White;
            tbServicoDescricao.BorderStyle = BorderStyle.None;
            tbServicoDescricao.Location = new Point(264, 23);
            tbServicoDescricao.Name = "tbServicoDescricao";
            tbServicoDescricao.Size = new Size(525, 20);
            tbServicoDescricao.TabIndex = 10;
            // 
            // tbCdServico
            // 
            tbCdServico.BackColor = Color.White;
            tbCdServico.BorderStyle = BorderStyle.None;
            tbCdServico.Location = new Point(86, 23);
            tbCdServico.Multiline = true;
            tbCdServico.Name = "tbCdServico";
            tbCdServico.Size = new Size(161, 20);
            tbCdServico.TabIndex = 6;
            // 
            // lbServico
            // 
            lbServico.AutoSize = true;
            lbServico.Location = new Point(11, 23);
            lbServico.Name = "lbServico";
            lbServico.Size = new Size(57, 20);
            lbServico.TabIndex = 9;
            lbServico.Text = "Serviço";
            // 
            // lbDtCriacao
            // 
            lbDtCriacao.AutoSize = true;
            lbDtCriacao.Location = new Point(752, 57);
            lbDtCriacao.Name = "lbDtCriacao";
            lbDtCriacao.Size = new Size(41, 20);
            lbDtCriacao.TabIndex = 10;
            lbDtCriacao.Text = "Data";
            // 
            // tbData
            // 
            tbData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbData.BackColor = Color.White;
            tbData.BorderStyle = BorderStyle.None;
            tbData.Location = new Point(847, 60);
            tbData.Name = "tbData";
            tbData.Size = new Size(181, 20);
            tbData.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(752, 86);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 16;
            label2.Text = "Status";
            // 
            // AgendamentoViewModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 584);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgendamentoViewModel";
            Text = "Agendamento";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridAgendamentos).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lbNumero;
        private Label lbNome;
        private Label lbDtCriacao;
        private TextBox tbNome;
        private TextBox tbCodigo;
        private TextBox tbData;
        private DataGridView dtGridAgendamentos;
        private Panel panel1;
        private TextBox tbCdServico;
        private Label lbServico;
        private Panel panel2;
        private Button btnAdd;
        private Button button6;
        private Button button4;
        private Button button3;
        private Label lbValorTotal;
        private TextBox tbVlTotal;
        private TextBox tbServicoDescricao;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private ComboBox cbStatus;
        private Label label2;
    }
}