using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Configuration
{
    public class MenuConfiguration : BaseEntityConfiguration<Menu>
    {
        public MenuConfiguration()
        {
            HasKey(m => m.MenuId)
               .Property(m => m.MenuId)
               .IsRequired()
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.DishId).IsRequired();
            Property(m => m.RestaurantId).IsRequired();
            HasRequired(m => m.Category);
            HasRequired(m => m.Restaurant);
            HasMany(m => m.Dish).WithRequired();
        }
    }
}