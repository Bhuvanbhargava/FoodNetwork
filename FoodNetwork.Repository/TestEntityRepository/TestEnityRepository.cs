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
    public class TestEnityRepository : GenericRepository<TestEntity>, ITestEntityRepository
    {
        public TestEnityRepository(FoodNetworkDatabaseContext context)
            : base(context)
        {
        }

        public override IEnumerable<TestEntity> GetAll()
        {
            return _dbContext.TestEntitys.Include(x => x.Name).AsEnumerable();
            //return _dbContext;
        }

        public TestEntity GetById(Guid id)
        {
            //return _dbset.Include(x => x.).Where(x => x.Id == id).FirstOrDefault();
            //return _dbset.Where(x => x.Id == id).FirstOrDefault();
            return FindBy(x=>x.TestEntityId==id).FirstOrDefault();
        }

   
    }
}