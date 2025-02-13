using AirPortApi.Services;
using AirPortApi.Repositories;
using AirlineApi.Services;
using AirlineApi.Repositories;
using DestinysApi.Services;
using DestinysApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null; // Evita problemas con JSON
    });

builder.Services.AddScoped<AirportServices>();
builder.Services.AddScoped<AirPortRepositories>();
builder.Services.AddScoped<AirlinesServices>();
builder.Services.AddScoped<AirlinesRepositories>();
builder.Services.AddScoped<DestinyServices>();
builder.Services.AddScoped<DestinyRepositories>();

var app = builder.Build();
app.UseCors("AllowAll");

app.MapControllers(); 

app.Run();