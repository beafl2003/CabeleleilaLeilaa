using CabeleleilaLeila.Application.Services;
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
        private bool _newItem;
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
            this.tbCdServico.Leave += TbCdServico_Leave;
            this.tbCodigo.KeyDown += TbCodigo_KeyDown;
            tbCodigo.SelectionLength = 0;

        }

        private void TbCodigo_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
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
                var r = _agendamentoAppService.NovoAgendamento(_config, newGuid, (TipoAgendamentoEnum)Enum.Parse(typeof(TipoAgendamentoEnum), cbStatus.SelectedItem.ToString()), DateTime.Parse(tbData.Text), decimal.Parse(tbVlTotal.Text));

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
            }

            LoadData();
        }

        private void TbVlTotal_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
            HabilitaDesabilitaBotoes();
        }

        private void TbServicoDescricao_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
            HabilitaDesabilitaBotoes();
        }

        private void TbCdServico_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
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
            if (agendamentoSelecionado == null)
            {
                tbCodigo.Text = string.Empty;
                tbNome.Text = string.Empty;
                tbData.Text = string.Empty ;
                tbCdServico.Text = string.Empty;
                tbServicoDescricao.Text = string.Empty;
                tbVlTotal.Text = string.Empty;
                return;
            }
            else
            {
                tbCodigo.Text = agendamentoSelecionado.NumAgendamento.ToString().Trim();
                tbNome.Text = agendamentoSelecionado.ClienteId.ToString().Trim();
                tbData.Text =   DateTime.Parse(agendamentoSelecionado.DtAgendamento.ToString()).ToString("dd/MM/yyyy").Trim();
                tbCdServico.Text = string.Empty;
                tbServicoDescricao.Text = string.Empty;
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
            if (dtTable == null)
            { 
                dtGridAgendamentos.DataSource = _agendamentoAppService.LoadAgendaServFromDatabase(_config);

            }
            else
            {
                dtGridAgendamentos.DataSource = dtTable;
            }
            

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
            }
            else
            {

                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
            };

        }

        private void Clear()
        {
           
        }

        private void ConfigureGrid()
        {
            dtGridAgendamentos.DefaultCellStyle.BackColor = Color.White;
            dtGridAgendamentos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dtGridAgendamentos.DefaultCellStyle.ForeColor = Color.Black;
            dtGridAgendamentos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dtGridAgendamentos.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dtGridAgendamentos.DefaultCellStyle.SelectionForeColor = Color.Black;

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
