using Microsoft.Extensions.DependencyInjection;

namespace ML.ImagePreprocessor.Desktop.ViewModels
{
    internal static class ViewModelRegistrator
    {
        internal static IServiceCollection ViewModelRegistrate(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            return services;
        }
    }
}
