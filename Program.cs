using AirPortApi.Services;
using AirPortApi.Repositories;

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

var app = builder.Build();
app.UseCors("AllowAll");

app.MapControllers(); 

app.Run();