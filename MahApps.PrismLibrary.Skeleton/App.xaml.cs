using System.Windows;
using MahApps.PrismLibrary.Skeleton.Views;
using Prism.Ioc;

namespace MahApps.PrismLibrary.Skeleton;

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
