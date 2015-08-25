using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Entity
{
   
    public class Dish : BaseEntity
    {
        public Guid DishId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public SpiceLevel SpiceLavel { get; set; }
        public decimal Price { get; set; }
        public virtual Menu Menu { get; set; }

    }
}
