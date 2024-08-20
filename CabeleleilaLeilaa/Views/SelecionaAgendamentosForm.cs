using CabeleleilaLeila.Application.Services;
using CabeleleilaLeila.Domain;
using CabeleleilaLeila.Domain.Enums;
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
using System.Xml.Linq;

namespace CabeleleilaLeilaa.Views
{
    public partial class SelecionaAgendamentosForm : Form
    {

        public long _currentAgendamentoNum;
        public Agendamento _Agendamento;
        private readonly IConfiguration _config;
        private readonly AgendamentoAppService _agendamentoAppService;
        private readonly ServicoAppService _servicoAppService;
        public event Action<string> OnSelect;

        public SelecionaAgendamentosForm(IConfiguration config)
        {
            _config = config;
            InitializeComponent();
            FormConfigurations();
            this.Shown += Agendamento_Shown;
            this.btnConsultar.Click += BtnConsultar_Click;
            _agendamentoAppService = new AgendamentoAppService();
            _servicoAppService = new ServicoAppService();
            dtGridAgendamentos.SelectionChanged += DtGridAgendamentos_SelectionChanged;
        }

        private void DtGridAgendamentos_SelectionChanged(object? sender, EventArgs e)
        {
            if (dtGridAgendamentos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dtGridAgendamentos.SelectedRows)
                {
                    var currentRow = selectedRow as DataGridViewRow;
                    _currentAgendamentoNum = long.Parse(selectedRow.Cells["NumAgendamento"]?.Value?.ToString());
                    tbAgendamentoNum.Text = _currentAgendamentoNum.ToString();
     

                }
            }
        }

        private void BtnConsultar_Click(object? sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbAgendamentoNum.Text))
            {
                var numero = long.Parse(tbAgendamentoNum.Text);
                var agendamento = _agendamentoAppService.GetAgendamentoById(_config, numero);
                if (numero != null)
                { 
                    DialogResult = DialogResult.OK;
                    OnSelect?.Invoke(tbAgendamentoNum.Text);
                    this.Close();
                }
            }
    
        }


        private void Agendamento_Shown(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var agendamentosTable = _agendamentoAppService.LoadFromDatabase(_config);
            dtGridAgendamentos.DataSource = agendamentosTable;
            ConfigureGrid();

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

                if (col.Name == "ClienteId")
                {
                    col.Visible = false;

                }
                if (col.Name == "NumAgendamento")
                {
                    col.HeaderText = "Número";
                }
                if (col.Name == "Status")
                {
                    col.HeaderText = "Status";
                    col.Width = 200;
                }
                if (col.Name == "CriadoEm")
                {
                    col.HeaderText = "Dt.Criação";
                }
                if (col.Name == "DtAgendamento")
                {
                    col.HeaderText = "Dt.Agendamento";
                    col.Width = 200;
                }
                if (col.Name == "PrecoTotal")
                {
                    col.HeaderText = "Preço Total";
                }


            }
        }

        private void FormConfigurations()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.dtGridAgendamentos.MultiSelect = false;
            tbAgendamentoNum.Enabled = true;


        }

        
    }
}
