using ML.ImagePreprocessor.Desktop.Infrastructure.Commands;
using ML.ImagePreprocessor.Desktop.ViewModels.Base;
using System.Windows.Input;

namespace ML.ImagePreprocessor.Desktop.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public string Title => "Finder";

        public ICommand CloseApp => new CloseWindowCommand();
    }
}
