using Avalonia;
using Avalonia.Markup.Xaml;

namespace XTestAvalonia.UI
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
