using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using Scrinium.ViewModels;
using Scrinium.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Scrinium;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {

        var Services = DependencyInjection.ConfigureService();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = Services.GetRequiredService<MainWindow>();
            {
                DataContext = Services.GetRequiredService<MainWindowViewModel>();
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}