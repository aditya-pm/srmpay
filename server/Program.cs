var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();


app.MapGet("/", () =>
{
    return "Hello World";
});

app.Run();
