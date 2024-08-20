namespace CabeleleilaLeilaa.Views
{
    partial class SelecionaAgendamentosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionaAgendamentosForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            lbNumero = new Label();
            panel2 = new Panel();
            btnConsultar = new Button();
            label1 = new Label();
            tbAgendamentoNum = new TextBox();
            lbNome = new Label();
            dtGridAgendamentos = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridAgendamentos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 278F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel1.Controls.Add(lbNumero, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(lbNome, 0, 6);
            tableLayoutPanel1.Controls.Add(dtGridAgendamentos, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 155F));
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
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(3, 451);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(1, 20);
            lbNumero.TabIndex = 9;
            lbNumero.Text = "Número";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(panel2, 7);
            panel2.Controls.Add(btnConsultar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbAgendamentoNum);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            tableLayoutPanel1.SetRowSpan(panel2, 5);
            panel2.Size = new Size(794, 117);
            panel2.TabIndex = 15;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.Location = new Point(641, 76);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(123, 29);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Selecionar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(391, 20);
            label1.TabIndex = 14;
            label1.Text = "Digite o número do Agendamento ou selecione pelo grid";
            // 
            // tbAgendamentoNum
            // 
            tbAgendamentoNum.BackColor = Color.MistyRose;
            tbAgendamentoNum.BorderStyle = BorderStyle.None;
            tbAgendamentoNum.Location = new Point(10, 61);
            tbAgendamentoNum.Name = "tbAgendamentoNum";
            tbAgendamentoNum.Size = new Size(251, 20);
            tbAgendamentoNum.TabIndex = 1;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(-75, 451);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(55, 20);
            lbNome.TabIndex = 3;
            lbNome.Text = "Cliente";
            // 
            // dtGridAgendamentos
            // 
            dtGridAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dtGridAgendamentos, 7);
            dtGridAgendamentos.Location = new Point(3, 126);
            dtGridAgendamentos.Name = "dtGridAgendamentos";
            dtGridAgendamentos.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dtGridAgendamentos, 3);
            dtGridAgendamentos.Size = new Size(794, 312);
            dtGridAgendamentos.TabIndex = 12;
            // 
            // SelecionaAgendamentosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelecionaAgendamentosForm";
            Text = "Agendamentos";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridAgendamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dtGridAgendamentos;
        private TextBox tbAgendamentoNum;
        private Label lbNumero;
        private Label lbNome;
        private Panel panel2;
        private Label label1;
        private Button btnConsultar;
    }
}