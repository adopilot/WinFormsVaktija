using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Microsoft.Maui;
using Plugin.Maui.Audio;
using System.Diagnostics;
using System.Xml.Linq;


namespace AndroidMujezin
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });


#if ANDROID
        builder.Services.AddTransient<IServicesTest, DemoServices>();
        builder.Services.AddTransient<IMessage, MessageTest>();
#endif

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddSingleton(AudioManager.Current);
            builder.Services.AddSingleton<Servisi.ConfigServis>();
            

            return builder.Build();
        }
    }

  
}