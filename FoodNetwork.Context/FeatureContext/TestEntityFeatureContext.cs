using FoodNetwork.Data.Entity;
using FoodNetwork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.FeatureContext
{
    public class TestEntityFeatureContext : BaseFeatureContext, ITestEntityFeatureContext
    {
        private ITestEntityRepository _testEntityRepository;
        public TestEntityFeatureContext(IUnitOfWork uow, ITestEntityRepository testEntityRepository)
            : base(uow) 
        {
            _testEntityRepository = testEntityRepository;
        }

        public IEnumerable<TestEntity> GetAll() 
        {
            return _testEntityRepository.GetAll();
        }

        

    }
}
