using Microsoft.EntityFrameworkCore;
using SRMPay.Data;

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

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Hello World";
});

app.Run();
