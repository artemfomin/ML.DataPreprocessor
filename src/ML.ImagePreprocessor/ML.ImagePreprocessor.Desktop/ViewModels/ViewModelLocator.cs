using Microsoft.Extensions.DependencyInjection;

namespace ML.ImagePreprocessor.Desktop.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Host.Services.GetRequiredService<MainWindowViewModel>();
    }
}
