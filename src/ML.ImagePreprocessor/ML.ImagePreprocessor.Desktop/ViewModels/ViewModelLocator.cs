using ML.ImagePreprocessor.Desktop.ViewModels.Base;

namespace ML.ImagePreprocessor.Desktop.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Host.Services.GetRequiredService<MainWindowViewModel>();
    }
}
