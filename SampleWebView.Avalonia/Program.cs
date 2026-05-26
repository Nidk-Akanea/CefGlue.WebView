using Avalonia;
using ReactiveUI.Avalonia;

namespace SampleWebView.Avalonia {

    class Program {
        static void Main(string[] args) {
            AppBuilder.Configure<App>()
                      .UsePlatformDetect()
                      .UseReactiveUI(_ => { })
                      .StartWithClassicDesktopLifetime(args);
        }
    }
}
