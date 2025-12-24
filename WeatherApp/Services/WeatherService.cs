using System.Net.Http;
using System.Text.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly string _baseUrl;
        private readonly string _apiKey;

        public WeatherService(string baseUrl, string apiKey)
        {
            _baseUrl = baseUrl;
            _apiKey = apiKey;
        }

        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {
            using HttpClient client = new HttpClient();
            string url = $"{_baseUrl}?q={city}&appid={_apiKey}&units=metric";

            HttpResponseMessage response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to fetch weather data.");
            }

            string json = await response.Content.ReadAsStringAsync();
            //return JsonSerializer.Deserialize<WeatherResponse>(json);     //case sensitive 
            return JsonSerializer.Deserialize<WeatherResponse>(json, new JsonSerializerOptions {PropertyNameCaseInsensitive = true});   //JSON to C# object conversion.
        }
    }
}