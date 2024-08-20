using CabeleleilaLeila.Application.Services;
using CabeleleilaLeila.Domain.Enums;
using CabeleleilaLeilaa.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CabeleleilaLeilaa.Views
{
    public partial class UsuariosViewModel : Form
    {

        private bool _loading;
        private bool _editing;
        private bool _newItem;
        private bool _filling;
        private Guid _currentId;
        private readonly IConfiguration _config;
        private readonly UsuarioAppService _usuarioAppService;

        public UsuariosViewModel(IConfiguration config)
        {
            _config = config;
            InitializeComponent();
            FormConfigurations();

            _usuarioAppService = new UsuarioAppService();
            dtGridUsuarios.CellFormatting += dtGridUsuarios_CellFormatting;
            dtGridUsuarios.SelectionChanged += DtGridUsuarios_SelectionChanged;
            this.Shown += UsuariosViewModel_Showm;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnSave.Click += BtnSave_Click;
            this.tbCodigo.TextChanged += TbCodigo_TextChanged;
            this.tbSenha.TextChanged += TbSenha_TextChanged;
            this.tbNome.TextChanged += TbNome_TextChanged;
            this.cbAtivo.TextChanged += CbAtivo_TextChanged;
            this.cbTipo.TextChanged += CbTipo_TextChanged;
            this.btnDelete.Click += BtnDelete_Click;



        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var id = _currentId;
            var r = _usuarioAppService.DeleteUsuario(_config, id);
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

        private void CbTipo_TextChanged(object? sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
            HabilitaDesabilitaBotoes();
        }

        private void CbAtivo_TextChanged(object? sender, EventArgs e)
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

        private void TbSenha_TextChanged(object? sender, EventArgs e)
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

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (_newItem)
            {
                var r = _usuarioAppService.NovoUsuario(_config, tbCodigo.Text.Trim(), tbNome.Text.Trim(), (UsuarioStatusEnum)Enum.Parse(typeof(UsuarioStatusEnum), cbAtivo.SelectedItem.ToString()), (TipoUsuarioEnum)Enum.Parse(typeof(TipoUsuarioEnum), cbTipo.SelectedItem.ToString()), tbSenha.Text);

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
            }
            else
            {
                var id = _currentId;
                var r = _usuarioAppService.UpdateUsuario(_config, tbCodigo.Text, tbNome.Text, (UsuarioStatusEnum)Enum.Parse(typeof(UsuarioStatusEnum), cbAtivo.SelectedItem.ToString()), (TipoUsuarioEnum)Enum.Parse(typeof(TipoUsuarioEnum), cbTipo.SelectedItem.ToString()), tbSenha.Text, id);

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }

            }

            LoadData();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            LoadData();
            _newItem = false;
            _editing = false;
            HabilitaDesabilitaBotoes();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            Clear();
            _editing = true;
            _newItem = true;
            dtGridUsuarios.ClearSelection();
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
            tbCodigo.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbSenha.Text = string.Empty;
            cbAtivo.SelectedItem = UsuarioStatusEnum.Ativo;
            cbTipo.SelectedItem = TipoUsuarioEnum.Comum;
            tbCodigo.Focus();
        }

        private void DtGridUsuarios_SelectionChanged(object? sender, EventArgs e)
        {
            if (dtGridUsuarios.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dtGridUsuarios.SelectedRows)
                {
                    var currentRow = selectedRow as DataGridViewRow;
                    _currentId = Guid.Parse(selectedRow.Cells["Id"]?.Value?.ToString());
                    FillFields(_currentId);
                }
            }
        }

        private void FillFields(Guid currentId)
        {
            var usuarioSelecionado = _usuarioAppService.GetUsuarioById(_config, currentId);
            if (usuarioSelecionado == null)
            {
                tbCodigo.Text = string.Empty;
                tbNome.Text = string.Empty;
                tbSenha.Text = string.Empty;
                cbAtivo.SelectedValue = string.Empty;
                cbTipo.SelectedValue = string.Empty;
                return;
            }
            else
            {
                var cdUsuario = usuarioSelecionado.CdUsuario.ToString().Trim();
                var nome = usuarioSelecionado.NomeUsuario.ToString().Trim();
                var senha = usuarioSelecionado.Senha.ToString().Trim();

                var tipo = Enum.Parse(typeof(TipoUsuarioEnum), usuarioSelecionado.TipoUsuario.ToString());
                var ativo = Enum.Parse(typeof(UsuarioStatusEnum), usuarioSelecionado.Ativo.ToString());

                tbCodigo.Text = cdUsuario;
                tbNome.Text = nome;
                tbSenha.Text = senha;
                cbAtivo.SelectedItem = ativo;
                cbTipo.SelectedItem = tipo;

            }
        }

        private void dtGridUsuarios_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dtGridUsuarios.Rows[e.RowIndex].IsNewRow)
            {
                return; // Ignora a última linha (linha de entrada de novos dados)
            }

            if (dtGridUsuarios.Columns[e.ColumnIndex].Name == "Senha")
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                    e.FormattingApplied = true;
                }
            }
        }

        private void UsuariosViewModel_Showm(object? sender, EventArgs e)
        {
            LoadData();
            _editing = false;
            HabilitaDesabilitaBotoes();
        }

        private void LoadData()
        {
            _loading = true;
            var usuarioTable = _usuarioAppService.LoadFromDatabase(_config);
            dtGridUsuarios.DataSource = usuarioTable;
            ConfigureGrid();
            _loading = false;
            Clear();
            HabilitaDesabilitaBotoes();
        }

        private void ConfigureGrid()
        {
            dtGridUsuarios.DefaultCellStyle.BackColor = Color.White;
            dtGridUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dtGridUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            dtGridUsuarios.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dtGridUsuarios.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dtGridUsuarios.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn col in dtGridUsuarios.Columns)
            {
                col.ReadOnly = true;
                col.Resizable = DataGridViewTriState.False;

                if (col.Name == "Id")
                {
                    col.Visible = false;

                }
                if (col.Name == "CdUsuario")
                {
                    col.HeaderText = "Cd.Usuário";
                }
                if (col.Name == "NomeUsuario")
                {
                    col.HeaderText = "Nome";
                    col.Width = 300;
                }
                if (col.Name == "TipoUsuario")
                {
                    col.HeaderText = "ADM";
                }


            }


        }

        private void FormConfigurations()
        {
            this.MaximumSize = new Size(889, 545);
            this.MaximizeBox = false;
            this.cbTipo.DataSource = Enum.GetValues(typeof(TipoUsuarioEnum));
            this.cbAtivo.DataSource = Enum.GetValues(typeof(UsuarioStatusEnum));

            cbAtivo.SelectedItem = null;
            cbTipo.SelectedItem = null;
            tbSenha.PasswordChar = '*';

            this.dtGridUsuarios.MultiSelect = false;
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
