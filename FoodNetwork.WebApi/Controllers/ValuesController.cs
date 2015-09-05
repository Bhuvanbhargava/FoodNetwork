using FoodNetwork.Data.Entity;
using FoodNetwork.FeatureContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodNetwork.WebApi.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private ITestEntityFeatureContext _testEntityFeatureContext;

         public ValuesController(){
             var test = "Test";
         }
         public ValuesController(ITestEntityFeatureContext testEntityFeatureContext)
         {
             _testEntityFeatureContext = testEntityFeatureContext;
         }
         // GET api/values
         public IEnumerable<TestEntity> Get()
         {             
             return _testEntityFeatureContext.GetAll();
             //return new string[] { "value1", "value2" };
         }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
