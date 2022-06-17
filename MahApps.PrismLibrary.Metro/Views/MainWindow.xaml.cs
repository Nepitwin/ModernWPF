using System;
using System.Linq;
using System.Windows;
using System.Windows.Navigation;
using ControlzEx.Theming;
using MahApps.PrismLibrary.Metro.Views.Pages;
using ModernWpf.Controls;
using ModernWpf.Navigation;

namespace MahApps.Metro.Skeleton.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.SyncWithAppMode;
        ThemeManager.Current.SyncTheme();
        Navigate(typeof(ControlsPage));
    }

    private void ContentFrameNavigated(object sender, NavigationEventArgs e)
    {
        if (e.SourcePageType() == typeof(SettingsPage))
        {
            NavView.SelectedItem = NavView.SettingsItem;
        }
        else
        {
            NavView.SelectedItem = NavView.MenuItems.OfType<NavigationViewItem>().FirstOrDefault(x => GetPageType(x) == e.SourcePageType());
        }
    }

    private void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
        if (args.IsSettingsInvoked)
        {
            Navigate(typeof(SettingsPage));
        }
        else
        {
            Navigate(args.InvokedItemContainer);
        }
    }

    private void Navigate(object item)
    {
        if (item is NavigationViewItem menuItem)
        {
            Type pageType = GetPageType(menuItem);
            if (ContentFrame.CurrentSourcePageType != pageType)
            {
                ContentFrame.Navigate(pageType);
            }
        }
    }

    private void Navigate(Type sourcePageType)
    {
        if (ContentFrame.CurrentSourcePageType != sourcePageType)
        {
            ContentFrame.Navigate(sourcePageType);
        }
    }

    private static Type GetPageType(NavigationViewItem item)
    {
        return item.Tag as Type;
    }
}
