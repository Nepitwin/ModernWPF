using System.Windows;
using MahApps.Metro.Skeleton.Views;
using Prism.Ioc;

namespace MahApps.PrismLibrary.Metro;

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
