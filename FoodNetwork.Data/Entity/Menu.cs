using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Entity
{
    public class Menu : BaseEntity
    {
        //dish catagory breakfast Lunch dinner Entry apptiser sides
        public MenuCategory Category { get; set; }

        public virtual List<Dish> Dish { get; set; }

        //menu category  Drinks  Wine Beer MainFood
        public Guid DishId { get; set; }

        public Guid MenuId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public Guid RestaurantId { get; set; }
    }
}