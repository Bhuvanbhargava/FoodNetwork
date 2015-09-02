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

        //public virtual List<Review> Feedback { get; set; }
        public virtual FoodType FoodType { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual List<Menu> Menus { get; set; }
        public string Name { get; set; }

        public Guid AddressId { get; set; }
        //public Guid CodeLookupId { get; set; }
        //public Guid ReviewId { get; set; }
    }
}