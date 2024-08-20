﻿using CabeleleilaLeila.Application.Services;
using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Enums;
using CabeleleilaLeilaa.Extensions;
using CabeleleilaLeilaa.Views;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CabeleleilaLeilaa.ChildForms
{
    public partial class AgendamentoViewModel : Form
    {

        private bool _loading;
        private bool _editing;
        private bool _editingServico = false;
        private bool _newItem;
        private bool _newItemServico = false;
        private bool _filling;
        private long _currentId;
        private decimal _valorTotal = 0;
        private readonly IConfiguration _config;
        private readonly AgendamentoAppService _agendamentoAppService;
        private readonly ServicoAppService _servicoAppService;
        public AgendamentoViewModel(IConfiguration config)
        {
            _config = config;
            InitializeComponent();
            FormConfigurations();

            _agendamentoAppService = new AgendamentoAppService();
            _servicoAppService = new ServicoAppService();

            this.Shown += AgendamentoViewModel_Shown;
            this.tbData.KeyPress += TbData_KeyPress;
            this.tbData.TextChanged += TbData_TextChanged;
            this.dtGridAgendamentos.SelectionChanged += dtGridAgendamentos_SelectionChanged;
            this.tbCodigo.TextChanged += TbCodigo_TextChanged;
            this.tbNome.TextChanged += TbNome_TextChanged; ;
            this.tbData.TextChanged += TbData_TextChanged1; ;
            this.tbCdServico.TextChanged += TbCdServico_TextChanged;
            this.tbServicoDescricao.TextChanged += TbServicoDescricao_TextChanged;
            this.tbVlTotal.TextChanged += TbVlTotal_TextChanged;
            this.btnSave.Click += BtnSave_Click;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.tbCdServico.Leave += TbCdServico_Leave;
            this.tbCodigo.KeyDown += TbCodigo_KeyDown;
            this.btnAddServico.Click += BtnAddServico_Click;
            this.btnSalvarServico.Click += BtnSalvarServico_Click;
            tbCodigo.SelectionLength = 0;

        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            LoadData();
            _newItem = false;
            _editing = false;
            HabilitaDesabilitaBotoes();
        }

        private void BtnSalvarServico_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCdServico.Text.Trim()) || string.IsNullOrEmpty(tbServicoDescricao.Text.Trim()) || string.IsNullOrEmpty(tbVlTotal.Text.Trim()))
            {
                this.NotifyError(Result.Factory.False("Valores inválidos"));
                return;

            }
            else
            {


                if (_newItem)
                {
                    var r = _agendamentoAppService.NovoAgendamentoServico(_config, _currentId, tbCdServico.Text, decimal.Parse(tbVlTotal.Text));
                    if (!r.Success)
                    {
                        this.NotifyError(r);
                        return;
                    }

                }

            }

            _editingServico = false;
            _newItemServico = false;
            LoadData();
            HabilitaDesabilitaBotoes();
        }

        private void BtnAddServico_Click(object? sender, EventArgs e)
        {

            ClearServico();
            _editingServico = true;
            _newItemServico = true;
            HabilitaDesabilitaBotoes();



        }

        private void TbCodigo_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SelecionaAgendamentosForm agendamentosDialog = new SelecionaAgendamentosForm(_config);

                var resultado = "";
                agendamentosDialog.OnSelect += result =>
                {
                    resultado = result;

                };

                if (agendamentosDialog.ShowDialog() == DialogResult.OK)
                {
                    this._currentId = long.Parse(resultado);
                    FillFields(_currentId);
                    LoadData();

                }

            }
        }

        private void TbCdServico_Leave(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCdServico.Text.Trim()))
            {
                var servico = _servicoAppService.GetServicoByCodigo(_config, tbCdServico.Text.Trim());
                if (servico != null)
                {
                    tbServicoDescricao.Text = servico.Descricao.ToString();
                    _valorTotal = _valorTotal + servico.Preco;
                }
            }

            tbVlTotal.Text = _valorTotal.ToString();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            Clear();
            _editing = true;
            _newItem = true;
            dtGridAgendamentos.ClearSelection();
            HabilitaDesabilitaBotoes();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (_newItem)
            {
                /// por enquanto não temos cliente então vai um novo Guid
                var newGuid = Guid.NewGuid();
                decimal valorTemp = 0;
                if (string.IsNullOrEmpty(tbNome.Text.Trim()) || string.IsNullOrEmpty(tbData.Text.Trim()) || string.IsNullOrEmpty(cbStatus.SelectedItem?.ToString()))
                {
                    this.NotifyError(Result.Factory.False("Valores inválidos"));
                    return;

                }
                var r = _agendamentoAppService.NovoAgendamento(_config, newGuid, (TipoAgendamentoEnum)Enum.Parse(typeof(TipoAgendamentoEnum), cbStatus.SelectedItem.ToString()), DateTime.Parse(tbData.Text), valorTemp);

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
            }
            _newItem = false;
            _editing = false;
            LoadData();
            HabilitaDesabilitaBotoes();
        }

        private void TbVlTotal_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editingServico = true;
            HabilitaDesabilitaBotoes();
        }

        private void TbServicoDescricao_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editingServico = true;
            HabilitaDesabilitaBotoes();
        }

        private void TbCdServico_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editingServico = true;
            HabilitaDesabilitaBotoes();
        }

        private void TbCdCliente_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
            HabilitaDesabilitaBotoes();
        }

        private void TbData_TextChanged1(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
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

        private void dtGridAgendamentos_SelectionChanged(object? sender, EventArgs e)
        {
            if (dtGridAgendamentos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dtGridAgendamentos.SelectedRows)
                {
                    var currentRow = selectedRow as DataGridViewRow;
                    _currentId = long.Parse(selectedRow.Cells["NumAgendamento"]?.Value?.ToString());
                    FillFields(_currentId);
                }
            }
        }

        private void FillFields(long currentId)
        {
            var agendamentoSelecionado = _agendamentoAppService.GetAgendamentoById(_config, currentId);
            var agendamentoServicos = _agendamentoAppService.GetAgendamentoServicoEById(_config, _currentId);

            if (agendamentoSelecionado == null)
            {
                tbCodigo.Text = string.Empty;
                tbNome.Text = string.Empty;
                tbData.Text = string.Empty;
                tbCdServico.Text = string.Empty;
                tbServicoDescricao.Text = string.Empty;
                tbVlTotal.Text = string.Empty;
                return;
            }
            else
            {
                tbCodigo.Text = agendamentoSelecionado.NumAgendamento.ToString().Trim();
                tbNome.Text = agendamentoSelecionado.ClienteId.ToString().Trim();
                tbData.Text = DateTime.Parse(agendamentoSelecionado.DtAgendamento.ToString()).ToString("dd/MM/yyyy").Trim();
                tbCdServico.Text = agendamentoServicos.CdServico;
                tbServicoDescricao.Text = agendamentoServicos.Descricao;
                tbVlTotal.Text = agendamentoSelecionado.PrecoTotal.ToString().Trim();
                var status = Enum.Parse(typeof(TipoAgendamentoEnum), agendamentoSelecionado.Status.ToString());
                cbStatus.SelectedItem = status;





            }
        }

        private void TbData_TextChanged(object? sender, EventArgs e)
        {
            string text = tbData.Text;
            if (text.Length == 2 || text.Length == 5)
            {
                if (!text.EndsWith("/"))
                {
                    tbData.Text = text + "/";
                    tbData.SelectionStart = tbData.Text.Length;
                }
            }
        }

        private void TbData_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AgendamentoViewModel_Shown(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _loading = true;

            var dtTable = _agendamentoAppService.GetAgendamentoServicoById(_config, _currentId);
            dtGridAgendamentos.DataSource = dtTable;





            ConfigureGrid();
            _loading = false;
            HabilitaDesabilitaBotoes();
        }

        private void HabilitaDesabilitaBotoes()
        {
           if (_editing)
            {

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
                tbNome.Enabled = true;
                tbData.Enabled = true;
                cbStatus.Enabled = true;
                tbCodigo.Enabled = false;
                btnAddServico.Enabled = false;

            }
            else
            {
                btnAddServico.Enabled = true;
                tbCodigo.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                tbNome.Enabled = false;
                tbData.Enabled = false;
                cbStatus.Enabled = false;
                tbCodigo.Enabled = true;
            };

            if (!_editing)
            {
                if (_editingServico)
                {

                    btnAddServico.Enabled = false;
                    btnDeleteServico.Enabled = true;
                    btnCancelServico.Enabled = true;
                    btnSalvarServico.Enabled = true;
                    tbCdServico.Enabled = true;
                    tbServicoDescricao.Enabled = true;
                    tbVlTotal.Enabled = true;
                    tbCodigo.Enabled = true;
                }
                else
                {

                    btnAddServico.Enabled = true;
                    btnDeleteServico.Enabled = false;
                    btnCancelServico.Enabled = false;
                    btnSalvarServico.Enabled = false;
                    tbCdServico.Enabled = false;
                    tbServicoDescricao.Enabled = false;
                    tbVlTotal.Enabled = false;
                    tbCodigo.Enabled = true;
                };
            }



            if (_currentId == 0 && !_newItem)
            {
                btnAddServico.Enabled = false;
                btnDeleteServico.Enabled = false;
                btnCancelServico.Enabled = false;
                btnSalvarServico.Enabled = false;
                tbCdServico.Enabled = false;
                tbServicoDescricao.Enabled = false;
                tbVlTotal.Enabled = false;
                btnAddServico.BackColor = Color.LightGray;
                btnDeleteServico.BackColor = Color.LightGray;
                btnCancelServico.BackColor = Color.LightGray;
                btnSalvarServico.BackColor = Color.LightGray;
                tbData.Enabled = false;
                cbStatus.Enabled = false;
                tbNome.Enabled = false;
                btnDelete.Enabled = false; 
                btnCancel.Enabled = false;
                btnSave.Enabled = false;


            }
            else { 

                btnAddServico.BackColor = Color.White;
                btnDeleteServico.BackColor = Color.White;
                btnCancelServico.BackColor = Color.White;
                btnSalvarServico.BackColor = Color.White;



            }



        }

        private void Clear()
        {
            tbNome.Text = string.Empty;
            tbCodigo.Text = string.Empty;
            tbData.Text = string.Empty;
            cbStatus.SelectedItem = TipoAgendamentoEnum.Pendente;
            tbCdServico.Text = string.Empty;
            tbServicoDescricao.Text = string.Empty;
            tbVlTotal.Text = string.Empty;
            tbNome.Focus();
        }

        private void ClearServico()
        {

            tbCdServico.Text = string.Empty;
            tbServicoDescricao.Text = string.Empty;
            tbVlTotal.Text = string.Empty;

            tbCdServico.Enabled = true;
            tbServicoDescricao.Enabled = true;
            tbVlTotal.Enabled = true;
            tbCdServico.Focus();
        }

        private void ConfigureGrid()
        {
            dtGridAgendamentos.DefaultCellStyle.BackColor = Color.White;
            dtGridAgendamentos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dtGridAgendamentos.DefaultCellStyle.ForeColor = Color.Black;
            dtGridAgendamentos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dtGridAgendamentos.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dtGridAgendamentos.DefaultCellStyle.SelectionForeColor = Color.Black;

            if(dtGridAgendamentos.Rows.Count == 0)
            {
                dtGridAgendamentos.Columns.Add("NumAgendamento","Número");
                dtGridAgendamentos.Columns.Add("CdServico", "Cd.Serviço");
                dtGridAgendamentos.Columns.Add("Descricao", "Descrição");
                dtGridAgendamentos.Columns.Add("Preco", "Preço");

            }

            foreach (DataGridViewColumn col in dtGridAgendamentos.Columns)
            {
                col.ReadOnly = true;
                col.Resizable = DataGridViewTriState.False;


                if (col.Name == "NumAgendamento")
                {
                    col.HeaderText = "Número";
                }
                if (col.Name == "CdServico")
                {
                    col.HeaderText = "Cd.Servico";
                }
                if (col.Name == "Preco")
                {
                    col.HeaderText = "Preço";
                }
              


            }

        }

        private void FormConfigurations()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.dtGridAgendamentos.MultiSelect = false;
            tbNome.Enabled = false;
            tbData.MaxLength = 10;
            tbCdServico.PasswordChar = '\0';
            tbVlTotal.PasswordChar = '\0';

            this.cbStatus.DataSource = Enum.GetValues(typeof(TipoAgendamentoEnum));
            cbStatus.SelectedItem = null;
            tbCodigo.SelectionLength = 0;

        }

        private void TestaCampoData()
        {
            DateTime dateValue;
            if (DateTime.TryParse(tbData.Text, out dateValue))
            {
                tbData.Text = dateValue.ToString("dd/MM/yyyy"); // or "MM/dd/yyyy" for another format
            }
            else
            {
                MessageBox.Show("Please enter a valid date.");
                tbData.Focus();
            }
        }
    }
}
