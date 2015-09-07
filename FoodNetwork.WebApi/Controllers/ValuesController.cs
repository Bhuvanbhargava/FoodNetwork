using FoodNetwork.Data.Entity;
using FoodNetwork.FeatureContext;
using FoodNetwork.WebApi.Areas.Restaurants.ModelRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodNetwork.WebApi.Controllers
{
    //[Authorize]
    [RoutePrefix("api/v1/value")]
    public class ValuesController : ApiController
    {
        private IRestaurantModelRepository _testEntityFeatureContext;

        //public ValuesController()
        //{
        //    var test = "Test";
        //}

        public ValuesController(IRestaurantModelRepository testEntityFeatureContext)
         {
             _testEntityFeatureContext = testEntityFeatureContext;
         }
         // GET api/values
            [Route("")]
         public IEnumerable<string> Get()
         {             
             return _testEntityFeatureContext.GetAll();
             //return new string[] { "value1", "value2" };
         }
         [Route("Id")]
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
        [Route("")]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }
          [Route("")]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
          [Route("")]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
