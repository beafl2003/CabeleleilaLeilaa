using CabeleleilaLeila.Application.Services;
using CabeleleilaLeila.Domain.Enums;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabeleleilaLeilaa.ChildForms
{
    public partial class ClienteViewModel : Form
    {
        private readonly ClienteAppService _clienteAppService;
        private readonly IConfiguration _config;

        public ClienteViewModel(IConfiguration config)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            InitializeComponent();
            _config = config;
            _clienteAppService = new ClienteAppService();
            LoadData();
            FormConfigurations();


        }

        private void FormConfigurations()
        {
            this.MaximumSize = new Size(889, 545);
            this.MaximizeBox = false;
            this.cbAtivo.DataSource = Enum.GetValues(typeof(StatusClienteEnum));
            cbAtivo.SelectedItem = null;

            this.dtGridClientes.MultiSelect = false;
        }

        private void LoadData()
        {
            var servicesTable = _clienteAppService.LoadFromDataBase(_config);
            dtGridClientes.DataSource = servicesTable;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {

            dtGridClientes.DefaultCellStyle.BackColor = Color.White;
            dtGridClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dtGridClientes.DefaultCellStyle.ForeColor = Color.Black;
            dtGridClientes.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dtGridClientes.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dtGridClientes.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn col in dtGridClientes.Columns)
            {
                col.ReadOnly = true;
                col.Resizable = DataGridViewTriState.False;

                if (col.Name == "Id")
                {
                    col.Visible = false;

                }
                if (col.Name == "UsuarioId")
                {
                    col.Visible = false;

                }
                if (col.Name == "Code")
                {
                    col.HeaderText = "Cd. Cliente";
                }
                if (col.Name == "Name")
                {
                    col.HeaderText = "Nome";
                    col.Width = 300;
                }
                if (col.Name == "CPF")
                {
                    col.HeaderText = "CPF";
                }
                if (col.Name == "Active")
                {
                    col.HeaderText = "Ativo";
                }
                if (col.Name == "Cell")
                {
                    col.HeaderText = "Celular";
                }
                if (col.Name == "BirthDate")
                {
                    col.HeaderText = "Dt. Nasc";
                }

            }
            }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
