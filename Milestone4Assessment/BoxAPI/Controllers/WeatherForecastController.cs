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

        [HttpPost(Name = "uploadFile")]
        public async Task<string> Post()
        {
            string clientID = "pkz1o3e3ikq1yk3muddd5r2w87eqs0rh";
            string clientSecret = "SmMkAs3aZuN5iDN7jjT21c5m4fy9gauh";
            string developerToken = "lLkCivuT7w9UPFYlmuUfxkUOtGelvD3y";

            var boxConfig = new BoxConfig(clientID, clientSecret, new Uri("http://localhost"));
            var boxJWTAuth = new BoxJWTAuth(boxConfig);
            var boxClient = boxJWTAuth.AdminClient(developerToken);
            using (var stream = new FileStream("Menu.pdf", FileMode.Open))
            {
                var fileRequest = new BoxFileRequest
                {
                    Name = Path.GetFileName("Menu.pdf"),
                    Parent = new BoxRequestEntity { Id = "0", Type = BoxType.file },
                };

                var uplaodedFile = await boxClient.FilesManager.UploadAsync(fileRequest, stream);
            }
            return "file uploaded";
        }
    }
}