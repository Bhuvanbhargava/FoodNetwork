using FoodNetwork.Data.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Repository
{
    public class RestaurantRepository : BaseRepository, IRestaurantRepository 
    {
        public RestaurantRepository(IFoodNetworkDatabaseContext dbcontext)
            :base(dbcontext)
        {
            
        }
        public IEnumerable<RestaurantDomain> RetrieveRestaurant()
        {
            var restaurants=FoodDbContext.Restaurants.Select(a=>a).ToList();
            return restaurants.Select(a => new RestaurantDomain(a));
        }
    }
}
