using CabeleleilaLeila.Application.Services;
using CabeleleilaLeila.Domain.Enums;
using CabeleleilaLeilaa.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CabeleleilaLeilaa.ChildForms
{
    public partial class ServicoViewModel : Form
    {
        private bool _loading;
        private bool _editing;
        private bool _newItem;
        private bool _filling;
        private Guid _currentId;
        private readonly IConfiguration _config;
        private readonly ServicoAppService _servicoAppService;

        public ServicoViewModel(IConfiguration config)
        {
            _config = config;
            InitializeComponent();
            FormConfigurations();

            _servicoAppService = new ServicoAppService();

            dtGridServicos.SelectionChanged += dtGridServicos_SelectionChanged;
            this.Shown += ServicoViewModel_Shown;
            this.tbPreco.TextChanged += TbPreco_TextChanged;
            this.tbCodigo.TextChanged += TbCodigo_TextChanged;
            this.tbNome.TextChanged += TbNome_TextChanged;
            this.btnSave.Click += BtnSave_Click;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
           
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var id = _currentId;
            var r = _servicoAppService.DeleteServico(_config, id);
            if (!r.Success)
            {
                this.NotifyError(r);
                return;
            }

            LoadData();
            Clear();

            _newItem = false;
            _editing = false;
            HabilitaDesabilitaBotoes();
        }

        private void dtGridServicos_SelectionChanged(object? sender, EventArgs e)
        {
            if (dtGridServicos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dtGridServicos.SelectedRows)
                {
                    var currentRow = selectedRow as DataGridViewRow;
                    _currentId = Guid.Parse(selectedRow.Cells["Id"]?.Value?.ToString());
                    FillFields(_currentId);
                }
            }
        }

        private void FillFields(Guid currentId)
        {
            var servicoSelecionado = _servicoAppService.GetServicoById(_config, currentId);
            if (servicoSelecionado == null)
            {
                tbCodigo.Text = string.Empty;
                tbNome.Text = string.Empty;
                tbPreco.Text = string.Empty;
              
                return;
            }
            else
            {
                var cdServico = servicoSelecionado.CdServico.ToString().Trim();
                var descricao = servicoSelecionado.Descricao.ToString().Trim();
                var preco = servicoSelecionado.Preco.ToString().Trim();

    

                tbCodigo.Text = cdServico;
                tbNome.Text = descricao;
                tbPreco.Text = preco;
                

            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            Clear();
            _editing = true;
            _newItem = true;
            dtGridServicos.ClearSelection();
            HabilitaDesabilitaBotoes();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            if (string.IsNullOrEmpty(tbPreco.Text) || string.IsNullOrEmpty(tbCodigo.Text) || string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Serviço Inválido - Existe campo em Branco.", "Aviso", MessageBoxButtons.OK);
           
                return;
            }
            if (_newItem)
            {
               
                var r = _servicoAppService.NovoServico(_config, tbCodigo.Text.Trim(), tbNome.Text.Trim(), decimal.Parse(tbPreco.Text, culture));

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
            }
            else
            {
                var id = _currentId;
                var r = _servicoAppService.UpdateServico(_config, tbCodigo.Text, tbNome.Text, decimal.Parse(tbPreco.Text, culture) , id);

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }

            }
           
            LoadData();
            _editing = false;
            HabilitaDesabilitaBotoes();
        }

        private void TbNome_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
            HabilitaDesabilitaBotoes();
        }

        private void TbCodigo_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

             _editing = true;
            HabilitaDesabilitaBotoes();
        }

        private void ServicoViewModel_Shown(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _loading = true;
            var servicesTable = _servicoAppService.LoadFromDatabase(_config);
            dtGridServicos.DataSource = servicesTable;
            ConfigureGrid();
            _loading = false;
            Clear();
            HabilitaDesabilitaBotoes();
        }

        private void ConfigureGrid()
        {
            dtGridServicos.DefaultCellStyle.BackColor = Color.White;
            dtGridServicos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dtGridServicos.DefaultCellStyle.ForeColor = Color.Black;
            dtGridServicos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dtGridServicos.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dtGridServicos.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn col in dtGridServicos.Columns)
            {
                col.ReadOnly = true;
                col.Resizable = DataGridViewTriState.False;

                if (col.Name == "Id")
                {
                    col.Visible = false;

                }
                if (col.Name == "CdServico")
                {
                    col.HeaderText = "Cd.Serviço";
                }
                if (col.Name == "Descricao")
                {
                    col.HeaderText = "Descrição";
                    col.Width = 300;
                }
                if (col.Name == "Preco")
                {
                    col.HeaderText = "Preço";
                }


            }
        }

        private void HabilitaDesabilitaBotoes()
        {
            if (_editing)
            {

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {

                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
            };
        }


        private void TbPreco_TextChanged(object? sender, EventArgs e)
        {
            // Remove tudo que não for número ou vírgula
            string input = tbPreco.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (input.Length > 0)
            {
                // Converte o texto para um valor decimal
                decimal value = Convert.ToDecimal(input) / 100;

                // Formata o valor como moeda brasileira (R$)
                tbPreco.Text = string.Format("{0:N}", value);

                // Mantém o cursor no final do texto
                tbPreco.SelectionStart = tbPreco.Text.Length;
            }

            if (_filling)
                return;

            _editing = true;
            HabilitaDesabilitaBotoes();
        }
        private void Clear()
        {
            tbCodigo.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbPreco.Text = string.Empty;
            dtGridServicos.ClearSelection();
            tbCodigo.Focus();
            _editing = false;
        }

        private void FormConfigurations()
        {
            this.MaximizeBox = false;
            this.dtGridServicos.MultiSelect = false;
            tbPreco.MaxLength = 12;
            tbCodigo.MaxLength = 10;
            tbNome.MaxLength = 50;
        }
    }
}
