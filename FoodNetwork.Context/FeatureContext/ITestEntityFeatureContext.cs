using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
namespace FoodNetwork.FeatureContext
{
   public interface ITestEntityFeatureContext
    {
       IEnumerable<TestEntity> GetAll();
     
    }
}
