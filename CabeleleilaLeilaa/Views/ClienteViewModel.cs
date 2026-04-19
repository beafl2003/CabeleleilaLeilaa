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
        }

        private void LoadData()
        {
            var servicesTable = _clienteAppService.LoadFromDataBase(_config);
            dtGridClientes.DataSource = servicesTable;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
