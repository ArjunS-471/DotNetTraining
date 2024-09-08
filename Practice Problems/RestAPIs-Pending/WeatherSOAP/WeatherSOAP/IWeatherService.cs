using System.ServiceModel;
using System.Threading.Tasks;

namespace WeatherSOAP
{
    public interface IWeatherService
    {
        [OperationContract]
        Task<WeatherResponse> GetWeather(string cityName);
    }
    public class WeatherResponse
    {
        public string Temperature { get; set; }
        public string Condition { get; set; }
    }
}
