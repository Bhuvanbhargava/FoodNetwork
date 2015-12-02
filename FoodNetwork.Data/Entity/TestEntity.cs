using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Entity
{
    public class TestEntity : BaseEntity
    {
        public Guid TestEntityId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}