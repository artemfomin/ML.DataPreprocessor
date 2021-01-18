using Microsoft.Xaml.Behaviors;
using ML.ImagePreprocessor.Desktop.Infrastructure.Behaviors.Exstensions;
using System.Windows;
using System.Windows.Controls;

namespace ML.ImagePreprocessor.Desktop.Infrastructure.Behaviors
{
    class MinimizeWindow : Behavior<Button>
    {
        protected override void OnAttached() => AssociatedObject.Click += OnButtonClick;

        protected override void OnDetaching() => AssociatedObject.Click -= OnButtonClick;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if (AssociatedObject.FindVisualRoot() is not Window window) return;

            window.WindowState = WindowState.Minimized;
        }
    }
}
