using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using XTestAvalonia.UI.ViewModels;
using XTestAvalonia.UI.Views;

namespace XTestAvalonia.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>(() => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
