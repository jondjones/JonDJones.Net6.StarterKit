using JonDJones.Net6.StarterKit.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureAppSettings();

builder.Services.RegisterApplicationServices();
var app = builder.Build();
app.ConfigureMiddleware();

var settings = builder.Configuration.GetRequiredSection("Settings").Get<Settings>();
var connectionString = settings?.ConnectionString;

app.Run();