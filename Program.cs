using Coursera_BlazorFinalProject.Components.Shared.Services;
using Blazored.LocalStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(); // Add Razor Pages support
builder.Services.AddBlazoredLocalStorage(); // Add Blazored.LocalStorage for local storage support
// builder.Services.AddServerSideBlazor(); // Add Blazor Server support
builder.Services.AddScoped<EventService>(); // Register the EventService as a singleton
builder.Services.AddScoped<UserSessionState>(); // Register the UserSessionState as a singleton
builder.Services.AddRouting(options => // Configure routing option
{
    options.LowercaseUrls = true; // Use lowercase URLs
    options.LowercaseQueryStrings = true; // Use lowercase query strings
    options.AppendTrailingSlash = true; // Append trailing slashes to URLs
});
builder.Services.AddServerSideBlazor(options => // Add Blazor Server support with options
{
    options.DetailedErrors = true; // Enable detailed error messages for debugging
});
builder.Services.AddHttpClient(); // Add HttpClient support for making HTTP requests


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles(); // Serve static files from wwwroot
app.UseRouting(); // Enable routing

// Map Blazor-specific endpoints
app.MapBlazorHub(); // Map the SignalR hub for Blazor Server
app.MapFallbackToPage("/_Host"); // Map fallback to the _Host page

app.Run();
