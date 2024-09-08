using System.Threading.Tasks;

namespace WeatherSOAP
{
    public class WeatherService
    {
        public Task<WeatherResponse> GetWeather(string cityName)
        {
            return Task.FromResult(new WeatherResponse
            {
                Temperature = "25",
                Condition = "Sunny"
            }) ;
        }
    }
}
