using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using SRMPay.Data;
using SRMPay.Extensions;
using SRMPay.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<SRMPayContext>(optionsBuilder =>
{
    optionsBuilder.UseSqlite(connectionString)
                  .UseSeeding((context, _) =>
                  {
                      DataSeeder.Seed((SRMPayContext)context);
                  });
});

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.Converters.Add(
        new JsonStringEnumConverter()
    );
});

builder.Services.AddOpenApi();
builder.Services.AddScoped<VendorService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapEndpoints();

app.Run();
