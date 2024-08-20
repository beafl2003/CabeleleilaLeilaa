using CabeleleilaLeila.Application.Services;
using CabeleleilaLeila.Domain;
using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Infra.Helpers;
using CabeleleilaLeilaa.Extensions;
using CabeleleilaLeilaa.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabeleleilaLeilaa.Views
{
    public partial class LoginView : Form
    {
        #region fields 
        private readonly System.ComponentModel.ComponentResourceManager _resources = new System.ComponentModel.ComponentResourceManager(typeof(CabeleleilaLeilaa.Properties.Resources));
        private bool _olhinhoEstaAberto = true;
        private readonly Bitmap _OlinhoAberto;
        private readonly Bitmap _OlinhoFechado;
        private readonly UsuarioAppService _usuarioAppService;
        private readonly IConfiguration _config;
        public event Action<string> OnLogin;

        #endregion
        public LoginView(IConfiguration configuration)
        {

            InitializeComponent();
            InitializeInputs();

            _config = configuration;

            _OlinhoAberto = ImageHelper.ResizeImage((System.Drawing.Image)_resources.GetObject("olinhoaberto"), 20);
            _OlinhoFechado = ImageHelper.ResizeImage((System.Drawing.Image)_resources.GetObject("olinhoofechado"), 20);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnSair.Click += BtnSair_Click;
            this.btnOlho.Click += BtnOlho_Click;
            this.btnLogin.Click += BtnLogin_Click;

            _usuarioAppService = new UsuarioAppService();


        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            List<string> resultado = ValidaUsuario();
            if(resultado.Any())
            {
                MessageBox.Show(string.Join(Environment.NewLine, resultado), "Aviso", MessageBoxButtons.OK);


            }
            else
            
            {
                var usuario = _usuarioAppService.GetUsuario(_config, tbUsuario.Text.Trim(), tbSenha.Text.Trim());
                if (usuario != null && usuario.Ativo == CabeleleilaLeila.Domain.Enums.UsuarioStatusEnum.Ativo)
                {
                    OnLogin?.Invoke(tbUsuario.Text.Trim());
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    var r = Result.Factory.False("Usuário ou senha incorretos!");
                    this.NotifyError(r);
                }

            }

            
        }

        private List<string> ValidaUsuario()
        {
            var messages = new List<string>();

            if (string.IsNullOrEmpty(tbUsuario.Text.Trim()))
                messages.Add("Código do usuário está vazio");
            if (tbUsuario.Text.Trim().Length < 2)
                messages.Add("Código de usuário não deverá ter menos que dois caracteres");
            if (tbUsuario.Text.Trim().Length > 10)
                messages.Add("Código de usuário não pode ultrapassar 10 caracteres");
            if (string.IsNullOrEmpty(tbSenha.Text.Trim()))
                messages.Add("A senha não poderá estar em branco");
            if (tbSenha.Text.Trim().Length < 4)
                messages.Add("A senha deve ter no mínimo 4 caracteres");
            if (tbSenha.Text.Trim().Length > 10)
                messages.Add("A senha não pode ultrapassar 10 caracteres");


            return messages;
        }

        private void BtnOlho_Click(object? sender, EventArgs e)
        {

                _olhinhoEstaAberto = !_olhinhoEstaAberto;



            if (_olhinhoEstaAberto)
            {
                btnOlho.Image = _OlinhoAberto;

            }
            else
            {
                btnOlho.Image = _OlinhoFechado;
            }

            InitializeInputs();
        }

            private void InitializeInputs()
            {

                tbSenha.MaxLength = 10;
                tbUsuario.MaxLength = 10;


                if (_olhinhoEstaAberto)
                {

                    tbSenha.PasswordChar = '*';
                }
                else
                {
                    tbSenha.PasswordChar = '\0';

                }

            }

            private void BtnSair_Click(object? sender, EventArgs e)
            {
                this.Close();
            }

        }
    }

