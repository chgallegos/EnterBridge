using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using EnterBridgeApp.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("OrdersDb"));
builder.Services.AddHttpClient();

var app = builder.Build();

// Enable Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Redirect HTTP to HTTPS (optional, comment out if causing issues locally)
// app.UseHttpsRedirection();

// Serve static files (make sure index.html loads at root)
app.UseDefaultFiles();     // Looks for index.html by default
app.UseStaticFiles();      // Enables CSS, JS, images, etc.

app.UseAuthorization();

// Map API routes
app.MapControllers();

// Cross-platform browser opener
void OpenBrowser(string url)
{
    try
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Process.Start("open", url);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("xdg-open", url);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unable to open browser: {ex.Message}");
    }
}

// Open the app in browser (adjust URL to HTTP if HTTPS redirect fails)
OpenBrowser("http://localhost:5000");

app.Run();
