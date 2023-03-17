using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Microsoft.Maui;
using Plugin.Maui.Audio;
using System.Diagnostics;
using System.Xml.Linq;
using AndroidMujezin.Data;
using AndroidMujezin.Servisi;

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
#elif WINDOWS
        builder.Services.AddTransient<IMessage, AndroidMujezin.Platforms.Windows.MessageTest>();
        builder.Services.AddTransient<IServicesTest, AndroidMujezin.Platforms.Windows.MujezinWinService>();
#endif


            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            builder.Services.AddSingleton<Servisi.VakatServis>();
            builder.Services.AddSingleton(AudioManager.Current);
            builder.Services.AddSingleton<Servisi.ConfigServis>();
            builder.Services.AddSingleton<WeatherForecastService>();
            //            builder.Services.AddSingleton<IFileSaver>();
            builder.Services.AddScoped<VaktijaApiServis>();
            builder.Services.AddSingleton<BazaServis>();
            return builder.Build();
        }
    }

  
}