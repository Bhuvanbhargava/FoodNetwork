using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Entity
{
    public class Review : BaseEntity
    {
        public Guid ReviewId { get; set; }
        public string Message { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        //public Guid RestaurantId { get; set; }
    }
}