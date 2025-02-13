using AirPortApi.Services;
using AirPortApi.Repositories;
using AirlineApi.Services;
using AirlineApi.Repositories;

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

var app = builder.Build();
app.UseCors("AllowAll");

app.MapControllers(); 

app.Run();