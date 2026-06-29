using Microsoft.EntityFrameworkCore;
using SRMPay.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SRMPayContext>(optionsBuilder =>
    optionsBuilder.UseSqlite(connectionString)
);

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Hello World";
});

app.Run();
