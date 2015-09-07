using System;
using System.Collections.Generic;
namespace FoodNetwork.Repository
{
    public interface IRestaurantRepository
    {
        IEnumerable<RestaurantDomain> RetrieveRestaurant();
    }
}
