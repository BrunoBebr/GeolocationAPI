using System.Reflection;
using GeolocationApi.Models;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

// Header and description

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Geolocation API",
        Description = "An ASP.NET Core Web API for autocomlete of users input address",
    });
});

builder.Services.AddHttpClient();

builder.Services.Configure<ConfigModel>(
    builder.Configuration.GetSection(
        "APIOptions"
        )
    );

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


    