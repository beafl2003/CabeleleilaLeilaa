namespace CabeleleilaLeilaa.ChildForms
{
    partial class ServicoViewModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicoViewModel));
            tbCodigo = new TextBox();
            tbNome = new TextBox();
            label1 = new Label();
            lbNome = new Label();
            lbPreco = new Label();
            tbPanel = new TableLayoutPanel();
            lbCodigo = new Label();
            tbPreco = new TextBox();
            panel1 = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            dtGridServicos = new DataGridView();
            tbPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridServicos).BeginInit();
            SuspendLayout();
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = Color.White;
            tbCodigo.BorderStyle = BorderStyle.None;
            tbCodigo.Location = new Point(3, 410);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(201, 20);
            tbCodigo.TabIndex = 0;
            // 
            // tbNome
            // 
            tbNome.BorderStyle = BorderStyle.None;
            tbPanel.SetColumnSpan(tbNome, 5);
            tbNome.Location = new Point(210, 410);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(634, 20);
            tbNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 155);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(210, 385);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(74, 20);
            lbNome.TabIndex = 3;
            lbNome.Text = "Descrição";
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Location = new Point(503, 456);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(46, 20);
            lbPreco.TabIndex = 8;
            lbPreco.Text = "Preço";
            // 
            // tbPanel
            // 
            tbPanel.BackColor = SystemColors.Control;
            tbPanel.ColumnCount = 6;
            tbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tbPanel.Controls.Add(tbCodigo, 0, 2);
            tbPanel.Controls.Add(tbNome, 1, 2);
            tbPanel.Controls.Add(lbCodigo, 0, 1);
            tbPanel.Controls.Add(lbNome, 1, 1);
            tbPanel.Controls.Add(tbPreco, 5, 4);
            tbPanel.Controls.Add(lbPreco, 4, 4);
            tbPanel.Controls.Add(panel1, 0, 0);
            tbPanel.Location = new Point(0, 0);
            tbPanel.Name = "tbPanel";
            tbPanel.RowCount = 6;
            tbPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tbPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tbPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tbPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tbPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tbPanel.Size = new Size(892, 522);
            tbPanel.TabIndex = 9;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Location = new Point(3, 385);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(58, 20);
            lbCodigo.TabIndex = 9;
            lbCodigo.Text = "Código";
            // 
            // tbPreco
            // 
            tbPreco.BorderStyle = BorderStyle.None;
            tbPreco.Location = new Point(595, 459);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(249, 20);
            tbPreco.TabIndex = 7;
            // 
            // panel1
            // 
            tbPanel.SetColumnSpan(panel1, 6);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(dtGridServicos);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 379);
            panel1.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Location = new Point(477, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Location = new Point(28, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Novo";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Location = new Point(606, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Location = new Point(735, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dtGridServicos
            // 
            dtGridServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridServicos.Location = new Point(-12, 59);
            dtGridServicos.Name = "dtGridServicos";
            dtGridServicos.RowHeadersWidth = 51;
            dtGridServicos.Size = new Size(895, 320);
            dtGridServicos.TabIndex = 13;
            // 
            // ServicoViewModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(892, 522);
            Controls.Add(tbPanel);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServicoViewModel";
            Text = "Serviços";
            tbPanel.ResumeLayout(false);
            tbPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridServicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCodigo;
        private TextBox tbNome;
        private Label label1;
        private Label lbNome;
        private Label lbPreco;
        private TableLayoutPanel tbPanel;
        private Label lbCodigo;
        private TextBox tbPreco;
        private Panel panel1;
        private DataGridView dtGridServicos;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnSave;
    }
}