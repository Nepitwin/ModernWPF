using System.Windows;
using MahApps.PrismLibrary.WebView2.Views;
using Prism.Ioc;

namespace MahApps.PrismLibrary.WebView2;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override Window CreateShell()
    {
        return Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {

    }
}
