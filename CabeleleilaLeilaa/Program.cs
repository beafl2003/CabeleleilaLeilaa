using CabeleleilaLeilaa.Views;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace CabeleleilaLeilaa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            ApplicationConfiguration.Initialize();

            var usuario = string.Empty;

            using (LoginView _loginView = new LoginView(configuration))
            {
                _loginView.OnLogin += result =>
                {

                    usuario = result;
                };
                if (_loginView.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm(configuration, usuario));
                }
            }
        }
    }
}