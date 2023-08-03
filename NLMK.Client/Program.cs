using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLMK.Client.Forms;
using NLMK.Client.Models;
using NLMK.Client.Services;
using System.Windows.Forms;

namespace NLMK.Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddXmlFile("app.config", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<ClientForm>();
                    services.AddSingleton<HttpClientService>();

                    var webServiceOptions = context.Configuration
                    .GetSection(nameof(WebServiceOptions))
                    .Get<WebServiceOptions>();
                    services.AddSingleton(webServiceOptions);
                })
                .Build();

            var form = host.Services.GetRequiredService<ClientForm>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(form);
        }
    }
}