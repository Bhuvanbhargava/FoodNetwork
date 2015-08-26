using FoodNetwork.Data.Configuration;
using FoodNetwork.Data.DBContext;
using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FoodNetwork.Data.DBContext
{
    public class FoodNetworkDatabaseContext : DbContext, IFoodNetworkDatabaseContext
    {
        static FoodNetworkDatabaseContext()
        {
            System.Data.Entity.Database.SetInitializer<FoodNetworkDatabaseContext>(null);
        }

        public FoodNetworkDatabaseContext(string connectionString) :
            base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new RestaurantConfiguration());
            //modelBuilder.Configurations.Add(new AddressConfiguration());
            //modelBuilder.Configurations.Add(new ReviewConfiguration());
            //modelBuilder.Configurations.Add(new MenuConfiguration());
            //modelBuilder.Configurations.Add(new DishConfiguration());
            //modelBuilder.Configurations.Add(new CodeLookupConfiguration());
            modelBuilder.Configurations.Add(new TestEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        //public IDbSet<Menu> Menus
        //{
        //    get;
        //    set;
        //}

        //public IDbSet<Restaurant> Restaurants
        //{
        //    get;
        //    set;
        //}

        //public IDbSet<CodeLookup> CodeLookups
        //{
        //    get;
        //    set;
        //}

        //public IDbSet<Address> Addresses
        //{
        //    get;
        //    set;
        //}

        //public IDbSet<Review> Reviews
        //{
        //    get;
        //    set;
        //}

        //public IDbSet<Dish> Dishes
        //{
        //    get;
        //    set;
        //}
        public IDbSet<TestEntity> TestEntitys
        {
            get;
            set;
        }
    }
}