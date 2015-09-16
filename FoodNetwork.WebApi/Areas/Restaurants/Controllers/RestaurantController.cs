using FoodNetwork.WebApi.Areas.Restaurants.ModelRepository;
using FoodNetwork.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace FoodNetwork.WebApi.Areas.Restaurants.Controllers
{
    [RoutePrefix("api/v1/restaurant")]
   // [RestfulApiException]
    public class RestaurantController : WebApiController
    {
        private IRestaurantModelRepository _restaurantModelRepository;
        public RestaurantController(IRestaurantModelRepository restaurantModelRepository)
        {
            _restaurantModelRepository = restaurantModelRepository;
        }
        [Route("")]
        [ResponseType(typeof(List<RestaurantResponse>))]
        public IHttpActionResult GetAll() 
        {
            var restaurants = _restaurantModelRepository.GetRestaurants();
                if (restaurants == null || restaurants.Count() == 0)
                {
                    return NotFound("Resource is not found"); // Returns a NotFoundResult
                }
                return Ok(restaurants);
        }
    }
}
