﻿using FoodNetwork.Common.Attribute;
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
    [DependencyDiscovery(typeof(ITestEntityRepository))]
    public class TestEntityRepository : BaseRepository, ITestEntityRepository
    {
        public TestEntityRepository(IFoodNetworkDatabaseContext context)
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