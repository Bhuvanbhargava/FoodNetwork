using FoodNetwork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.FeatureContext.RestaurantFeature
{
    public class RestaurantDataTransferObject 
    {
        public RestaurantDataTransferObject(RestaurantDomain domain)
        {
            Name = domain.Name;
        }
        public string Name { get; set; }
    }
}
