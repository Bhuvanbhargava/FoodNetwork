using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Entity
{
    public class Menu : BaseEntity
    {
        public Guid MenuId { get; set; }
         //dish catagory breakfast Lunch dinner Entry apptiser sides
        public virtual Dish Dish { get; set; } 
        public string Category { get; set; }//menu category  Drinks  Wine Beer MainFood

        

    }
}
