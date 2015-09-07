using System.Collections.Generic;
namespace FoodNetwork.FeatureContext.RestaurantFeature
{
    public interface IRestaurantFeatureContext
    {
        IEnumerable<RestaurantDataTransferObject> GetRestaurant();

    }
}