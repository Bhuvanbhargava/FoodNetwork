using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Entity
{
    public class Dish : BaseEntity
    {
        public FoodCategory Category { get; set; }
        public string Description { get; set; }
        public Guid DishId { get; set; }
        public virtual List<Menu> Menu { get; set; }
        public Guid MenuId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public SpiceLevel SpiceLavel { get; set; }
    }
}