using GeoVibs_Business.Shared.AppStates;
using GeoVibs_Business.Shared.Services;
using GeoVibs_Business.Shared.APIContext;
using GeoVibs_Business.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using GeoVibs_Business.Shared.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var apiBaseUrl = builder.Configuration["ApiSettings:BaseUrl"] ?? string.Empty;
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl) });
// Add device-specific services used by the GeoVibs_Business.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();
builder.Services.AddScoped<ApiClient>();
builder.Services.AddScoped<AppNavigationService>();
builder.Services.AddScoped<CurrentAppStates>();
builder.Services.AddScoped<RoomAPI>();
builder.Services.AddScoped<MovieAPI>();
builder.Services.AddScoped<ILoadingService, LoadingService>();
builder.Services.AddMudServices();
await builder.Build().RunAsync();
