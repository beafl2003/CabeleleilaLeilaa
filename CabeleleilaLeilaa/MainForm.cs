using CabeleleilaLeila.Application.Services;
using CabeleleilaLeila.Domain;
using CabeleleilaLeilaa.ChildForms;
using CabeleleilaLeilaa.Views;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace CabeleleilaLeilaa
{
    public partial class MainForm : Form
    {

        #region fields

        private readonly UsuarioAppService _usuarioAppService;
        private readonly IConfiguration _config;

        #endregion
        public MainForm(IConfiguration configuration, string usuarioLogado)
        {
            InitializeComponent();
            _config = configuration;
            _usuarioAppService = new UsuarioAppService();
            InitializeBoasVindas(usuarioLogado);


            this.StartPosition = FormStartPosition.CenterScreen;

            this.btnAgendar.Click += (object sender, EventArgs e) =>
            {
                btnAgendar_Click();

            };
            this.btnServicos.Click += (object sender, EventArgs e) =>
            {
                btnServicos_Click();

            };
            this.btnClientes.Click += (object sender, EventArgs e) =>
            {
                btnClientes_Click();
            };
            this.btnGerencial.Click += (object sender, EventArgs e) =>
            {
                btnGerencial_Click();
            };

            this.btnAdministrativo.Click += (object sender, EventArgs e) =>
            {
                btnAdministrativo_Click();

            };

        }

        private void btnAdministrativo_Click()
        {
            var usuariosForm = new UsuariosViewModel(_config);
            usuariosForm.MdiParent = this;
            usuariosForm.StartPosition = FormStartPosition.CenterScreen;

            usuariosForm.Show();
        }

        private void InitializeBoasVindas(string usuarioLogado)
        {
            var usuario = _usuarioAppService.GetUsuarioPorCodigo(_config, usuarioLogado);
            var agendamentos = 0;
            if (usuario.TipoUsuario == CabeleleilaLeila.Domain.Enums.TipoUsuarioEnum.Comum)
            {
                lbBoasVindas.Text = $@"Olá {usuario.NomeUsuario}!";
            }
            else
            {
                lbBoasVindas.Text = $@"Olá {usuario.NomeUsuario}!";
            }

            ConfigureButtons(usuario);
        }

        private void ConfigureButtons(Usuario usuario)
        {
            if (usuario.TipoUsuario == CabeleleilaLeila.Domain.Enums.TipoUsuarioEnum.Comum)
            {
                btnAdministrativo.Visible = false;
                btnGerencial.Visible = false;
                btnClientes.Visible = false;
                pbHeartUser.Visible = true;
                pbHeart.Visible = false;
            }
            else
            {
                btnPerfil.Visible = false;
                pbHeart.Visible = true;
                pbHeartUser.Visible = false;
            }
        }

        private void btnClientes_Click()
        {
            var clientesForm = new ClienteViewModel();
            clientesForm.MdiParent = this;
            clientesForm.StartPosition = FormStartPosition.CenterScreen;

            clientesForm.Show();
        }

        private void btnGerencial_Click()
        {


        }

        private void btnServicos_Click()
        {
            var servicosForm = new ServicoViewModel(_config);
            servicosForm.MdiParent = this;
            servicosForm.StartPosition = FormStartPosition.CenterScreen;

            servicosForm.Show();
        }

        private void btnAgendar_Click()
        {
            var agendarForm = new AgendamentoViewModel(_config);
            agendarForm.MdiParent = this;
            agendarForm.StartPosition = FormStartPosition.CenterScreen;

            agendarForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
