using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Repository
{
    public class RestaurantDomain
    {
        public RestaurantDomain(Restaurant restaurant )
        {
            Name = restaurant.Name;
        }

        public string Name { get; set; }
        public string foodType { get; set; }
    }
}
