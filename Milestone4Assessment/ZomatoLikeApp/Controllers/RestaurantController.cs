using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using ZomatoLikeApp.ViewModel;

namespace ZomatoLikeApp.Controllers
{
    //[ApiVersion("1.0")]
    //[Route("api/{v:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : Controller
    {
        public static List<Restaurants> restaurantList = new List<Restaurants>();

        [HttpGet("get-restaurants")]
        public IEnumerable<Restaurants> GetRestaurant()
        {
            return restaurantList;
        }

        [HttpGet("get-restaurant")]
        public Restaurants GetRestaurant(string name)
        {

            return restaurantList.Where(x => x.name == name).FirstOrDefault(); ;
        }

        [HttpPost]
        public IActionResult PostRestaurant(Restaurants restaurant)
        {
            restaurantList.Add(restaurant);
            return Ok("Record added successfully");
        }

        [HttpPut]
        public IActionResult PutRestaurant(Restaurants restaurant)
        {
            var restaurantData = restaurantList.Where(x => x.name == restaurant.name).FirstOrDefault();
            restaurantList.Remove(restaurantData);
            restaurantList.Add(restaurant);
            return Ok("Record added successfully");
        }

        [HttpDelete]
        public IActionResult DeleteRestaurant(string name)
        {
            var restaurantData = restaurantList.Where(x => x.name == name).FirstOrDefault();
            restaurantList.Remove(restaurantData);
            return Ok("Record deleted successfully");
        }
    }
}
