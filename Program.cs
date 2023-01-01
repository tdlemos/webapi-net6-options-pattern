using Microsoft.Extensions.Options;
using webapi_net6_options_pattern;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureOptions<ApplicationOptionsSetup>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/mysettings", (IOptions<MySettings> options) =>
{
    var response = new
    {
        options.Value
    };

    return Results.Ok(response);
});

app.Run();
