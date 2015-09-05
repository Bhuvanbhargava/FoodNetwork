using FoodNetwork.Data.DBContext;
using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private IFoodNetworkDatabaseContext _dbContext;


        public BaseRepository(IFoodNetworkDatabaseContext context)
        {
            _dbContext = context;
        
        }       

        public virtual void Save()
        {
            _dbContext.SaveChanges();
        }

        protected IFoodNetworkDatabaseContext FoodDbContext
        {
            get { return _dbContext; }
        }

  
    }
}