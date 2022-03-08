using Blazored.LocalStorage;
using DPBlazorMapLibrary;
using KarooLiveTracking;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text.Json;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient();
builder.Services.AddMapService();
builder.Services.AddAntDesign();

builder.Services.AddBlazoredLocalStorage(config =>
{
	config.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
	config.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
	config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
	config.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
	config.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
	config.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
	config.JsonSerializerOptions.WriteIndented = false;
});

await builder.Build().RunAsync();