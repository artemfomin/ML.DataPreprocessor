using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

namespace ML.ImagePreprocessor.Desktop
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] Args) =>
           Host.CreateDefaultBuilder()
            .UseContentRoot(App.CurrentDirectory)
            .ConfigureAppConfiguration((host, cfg) => cfg
                .SetBasePath(App.CurrentDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true))
            .ConfigureServices(App.ConfigureServies);
    }
}
