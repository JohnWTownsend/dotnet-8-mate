var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging((loggingBuilder) => 
    loggingBuilder
        .SetMinimumLevel(LogLevel.Trace)
        .AddConsole()
);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    app.Logger.LogTrace("John Was Here");
    app.Logger.WeatherForecastReceived(forecast);
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();



app.MapGet("/jowtow", () =>
{
    
    return "jowtow power!";
})
.WithOpenApi();
app.Run();

public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

public static partial class Log
{
    [LoggerMessage(Level = LogLevel.Information,
        Message = "Received call for Forecast: {weatherForecast}")]
    public static partial void WeatherForecastReceived(this Microsoft.Extensions.Logging.ILogger logger, [LogProperties] IEnumerable<WeatherForecast> weatherForecast);
}
