using FoodNetwork.Data.Entity;
using System;
using System.Data.Entity;

namespace FoodNetwork.Data.DBContext
{
    public interface IFoodNetworkDatabaseContext : IDisposable 
    {
        IDbSet<CodeLookup> CodeLookups { get; }
        IDbSet<Address> Addresses { get; }
        IDbSet<Review> Reviews { get; }
        IDbSet<Dish> Dishes { get; }
        IDbSet<Menu> Menus { get; }
        IDbSet<Restaurant> Restaurants { get; }
        IDbSet<TestEntity> TestEntitys { get; }

        int SaveChanges();
    }
}