using MetaHealthMaui.BleDev;
using Microsoft.Extensions.Logging;
using MetaHealthMaui.ViewModel;

namespace MetaHealthMaui
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();

#if ANDROID
            builder.Services.AddSingleton<IBleDevService, Platforms.Android.BleDev.BleDevService>();
//#elif IOS
//          builder.Services.AddSingleton<IBleDevService, MetaHealthMaui.Platforms.iOS.BleDev.BleDevService>();
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}