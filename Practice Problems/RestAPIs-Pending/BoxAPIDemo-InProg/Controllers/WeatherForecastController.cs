using Box.V2.Config;
using Box.V2.JWTAuth;
using Box.V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoxAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public async Task<List<BoxItem>> Get()
        //{
        //    string clientID = "pkz1o3e3ikq1yk3muddd5r2w87eqs0rh";
        //    string clientSecret = "SmMkAs3aZuN5iDN7jjT21c5m4fy9gauh";
        //    string developerToken = "xNO5JhTROHugpdSn4Z6OdD48NF9hs7yj";

        //    var boxConfig = new BoxConfig(clientID, clientSecret, new Uri("http://localhost"));
        //    var boxJWTAuth = new BoxJWTAuth(boxConfig);

        //    var boxClient = boxJWTAuth.AdminClient(developerToken);
        //    var user = await boxClient.UsersManager.GetCurrentUserInformationAsync();

        //    var items = await boxClient.FoldersManager.GetFolderItemsAsync("0", 100);

        //    return items.Entries;
        //}

        [HttpPost(Name = "uploadImage")]
        public async Task<string> Post()
        {
            string clientID = "pkz1o3e3ikq1yk3muddd5r2w87eqs0rh";
            string clientSecret = "SmMkAs3aZuN5iDN7jjT21c5m4fy9gauh";
            string developerToken = "lLkCivuT7w9UPFYlmuUfxkUOtGelvD3y";

            var boxConfig = new BoxConfig(clientID, clientSecret, new Uri("http://localhost"));
            var boxJWTAuth = new BoxJWTAuth(boxConfig);
            var boxClient = boxJWTAuth.AdminClient(developerToken);
            using (var stream = new FileStream("Dummy.txt", FileMode.Open))
            {
                var fileRequest = new BoxFileRequest
                {
                    Name = Path.GetFileName("Dummy.txt"),
                    Parent = new BoxRequestEntity { Id = "0", Type = BoxType.file },
                };

                var uplaodedFile = await boxClient.FilesManager.UploadAsync(fileRequest, stream);
            }
            return "file uploaded";
        }
    }
}