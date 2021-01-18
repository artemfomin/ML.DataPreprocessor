using System.Windows;
using System.Windows.Media;

namespace ML.ImagePreprocessor.Desktop.WPF.Styles.Infrastructure.Behaviors.Exstensions
{
    static class DependencyObjectExstensions
    {
        public static DependencyObject FindVisualRoot(this DependencyObject obj)
        {
            do
            {
                var parent = VisualTreeHelper.GetParent(obj);
                if (parent is null) return obj;
                obj = parent;
            }
            while (true);
        }

        public static DependencyObject FindLogicalRoot(this DependencyObject obj)
        {
            do
            {
                var parent = LogicalTreeHelper.GetParent(obj);
                if (parent is null) return obj;
                obj = parent;
            }
            while (true);
        }
    }
}
