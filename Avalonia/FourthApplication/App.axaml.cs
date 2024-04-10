using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using FourthApplication.Services;
using FourthApplication.ViewModels;
using FourthApplication.Views;

namespace FourthApplication;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var db = new Database();
            desktop.MainWindow = new MainWindow(db);
        }

        base.OnFrameworkInitializationCompleted();
    }
}