using Maui.GoogleMaps.Hosting;
using Microsoft.Extensions.Logging;

namespace GoogleMapsPinDemo;

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
                fonts.AddFont("fa_solid_900.ttf", "FASolid");
            });

#if ANDROID
        builder.UseGoogleMaps();
#elif IOS
        builder.UseGoogleMaps(Constants.GoogleMapsApiKey);
#endif

        return builder.Build();
    }
}
