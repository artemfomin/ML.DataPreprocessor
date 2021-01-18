using Microsoft.Xaml.Behaviors;
using ML.ImagePreprocessor.Desktop.WPF.Styles.Infrastructure.Behaviors.Exstensions;
using System.Windows;
using System.Windows.Controls;

namespace ML.ImagePreprocessor.Desktop.WPF.Styles.Infrastructure.Behaviors
{
    class WindowStateChange : Behavior<Button>
    {
        protected override void OnAttached() => AssociatedObject.Click += OnButtonClick;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if (!(AssociatedObject.FindVisualRoot() is Window window)) return;

            window.WindowState = window.WindowState switch
            {
                WindowState.Normal => WindowState.Maximized,
                WindowState.Maximized => WindowState.Normal,
                _ => window.WindowState
            };
        }
    }
}
