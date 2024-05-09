using Microsoft.Extensions.Logging;
using EcoPocket.Data;
using EcoPocket.Services.Interfaces;
using EcoPocket.Services;

namespace EcoPocket
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

            // Add data base context
            builder.Services.AddDbContext<EcoPocketDbContextBase>();

            // Add services within its interfaces
            builder.Services.AddScoped<IIncomeService, IncomeService>();

            builder.Services.AddMauiBlazorWebView();            

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
