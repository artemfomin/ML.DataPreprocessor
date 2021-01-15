using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ML.ImagePreprocessor.Desktop.Infrastructure.Services;
using ML.ImagePreprocessor.Desktop.ViewModels;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ML.ImagePreprocessor.Desktop
{
    public partial class App : Application
    {
        public static IHost __Host;
        public static IHost Host => __Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
        public static bool IsDesignMode { get; private set; } = true;
        protected override async void OnStartup(StartupEventArgs e)
        {
            IsDesignMode = false;

            var host = Host;
            base.OnStartup(e);

            await host.StartAsync().ConfigureAwait(false);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            var host = Host;
            await host.StopAsync().ConfigureAwait(false);
            host.Dispose();
            __Host = null;
        }

        public static void ConfigureServies(HostBuilderContext host, IServiceCollection services) => services
            .ViewModelRegistrate()
            .ServicesRegistrator();

        public static string CurrentDirectory => IsDesignMode ? Path.GetDirectoryName(GetSourceCodePath()) : Environment.CurrentDirectory;

        private static string GetSourceCodePath([CallerFilePath] string Path = null) => Path;
    }
}
