using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Entity
{
    public class Restaurant : BaseEntity
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public virtual Address Locations { get; set; }
        public string Type { get; set; }
        public virtual Feedback Feedback { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
