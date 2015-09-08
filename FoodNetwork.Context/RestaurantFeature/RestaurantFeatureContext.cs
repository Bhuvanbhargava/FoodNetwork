using FoodNetwork.Common.Attribute;
using FoodNetwork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.FeatureContext.RestaurantFeature
{
    [DependencyDiscovery(typeof(IRestaurantFeatureContext))]
    public class RestaurantFeatureContext : BaseFeatureContext,IRestaurantFeatureContext
    {
        private IRestaurantRepository _restaurantRepository;
        public RestaurantFeatureContext(IUnitOfWork unitOfWork,IRestaurantRepository restaurantRepository):base(unitOfWork)
        {
            _restaurantRepository = restaurantRepository;
        }
        public IEnumerable<RestaurantDataTransferObject> GetRestaurant()
        {
            var restaurants=_restaurantRepository.RetrieveRestaurant();
            return restaurants.Select(a=> new RestaurantDataTransferObject(a));
        }
    }
}
