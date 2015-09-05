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
    public class TestEnityRepository : BaseRepository, ITestEntityRepository
    {
        public TestEnityRepository(IFoodNetworkDatabaseContext context)
            : base(context)
        {
        }

        public IEnumerable<TestEntity> GetAll()
        {
            return FoodDbContext.TestEntitys.AsEnumerable();
            //return _dbContext;
        }

        public TestEntity GetById(Guid id)
        {
            return FoodDbContext.TestEntitys.Where(x => x.TestEntityId == id).FirstOrDefault();
        }

        


   
    }
}