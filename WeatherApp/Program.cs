using WeatherApp.Services;
using Microsoft.Extensions.Configuration;


Console.WriteLine("Welcome to WeatherApp");
Console.WriteLine("---------------------");
Console.Write("Enter city name: ");
string city = Console.ReadLine();
if (string.IsNullOrEmpty(city))
{
    Console.WriteLine("City cannot be empty");
    return;
}


var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional:false)
            .Build();

var baseUrl = config["WeatherApi:BaseUrl"];
var apiKey = config["WeatherApi:ApiKey"];
var service = new WeatherService(baseUrl, apiKey);

try
{
    var weather = await service.GetWeatherAsync(city);
    Console.WriteLine($"\nCity: {weather.Name}");
    Console.WriteLine($"Temperature: {weather.Main.Temp}°C");
    Console.WriteLine($"Humidity: {weather.Main.Humidity}%");
    Console.WriteLine($"Condition: {weather.Weather[0].Description}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}