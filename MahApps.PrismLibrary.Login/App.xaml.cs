using System.Windows;
using MahApps.PrismLibrary.Login.Views;
using Prism.Ioc;

namespace MahApps.PrismLibrary.Login;

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
