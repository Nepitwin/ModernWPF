using Prism.Mvvm;

namespace MahApps.Metro.Skelleton.ViewModels
{
    internal class MainWindowViewModel : BindableBase
    {
        public static string Title
        {
            get => Resources.strings.Title;
        }
    }
}
