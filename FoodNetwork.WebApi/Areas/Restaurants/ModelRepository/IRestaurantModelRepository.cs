using FoodNetwork.WebApi.Areas.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodNetwork.WebApi.Areas.Restaurants.ModelRepository
{
    public interface IRestaurantModelRepository
    {
        IEnumerable<RestaurantResponse> GetRestaurants();
        IEnumerable<string> GetAll();
    }
}
