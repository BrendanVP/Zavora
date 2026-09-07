var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return new
    {
        platform = "Zavora",
        status = "Online",
        version = "0.1"
    };
});

app.Run();