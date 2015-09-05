using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Repository
{
    public interface ITestEntityRepository : IBaseRepository
    {
        TestEntity GetById(Guid id);
        IEnumerable<TestEntity> GetAll();
    }
}