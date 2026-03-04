using GeoVibs_Business.Services;
using GeoVibs_Business.Shared.APIContext;
using GeoVibs_Business.Shared.AppStates;
using GeoVibs_Business.Shared.Interfaces;
using GeoVibs_Business.Shared.Services;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace GeoVibs_Business
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

            // Add device-specific services used by the GeoVibs_Business.Shared project
            var apiBaseUrl = builder.Configuration["ApiSettings:BaseUrl"] ?? string.Empty;
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl) });
            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            builder.Services.AddScoped<ApiClient>();
            builder.Services.AddScoped<AppNavigationService>();
            builder.Services.AddScoped<CurrentAppStates>();
            builder.Services.AddScoped<RoomAPI>();
            builder.Services.AddScoped<MovieAPI>();
            builder.Services.AddScoped<UserAPI>();
            builder.Services.AddScoped<UserLevelAPI>();
            builder.Services.AddScoped<ILoadingService, LoadingService>();
            builder.Services.AddMudServices();
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
