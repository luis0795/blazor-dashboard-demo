using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorDashboardDemo.Client;
using BlazorDashboardDemo.Client.Services;
using BlazorDashboardDemo.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IUserDashboardService, UserDashboardService>();

await builder.Build().RunAsync();
