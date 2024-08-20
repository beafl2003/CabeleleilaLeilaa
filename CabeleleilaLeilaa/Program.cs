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
            var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Ensures the path is correct for Windows Forms
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = builder.Build();

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