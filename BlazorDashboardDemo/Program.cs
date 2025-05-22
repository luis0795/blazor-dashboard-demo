var builder = WebApplication.CreateBuilder(args);

// Add services to the container (e.g., APIs)
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles(); // Serve WASM static files
app.UseStaticFiles();
app.UseRouting();

app.MapControllers(); // If you have APIs
app.MapFallbackToFile("index.html"); // SPA fallback

app.Run();
