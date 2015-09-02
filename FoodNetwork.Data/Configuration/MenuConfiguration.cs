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
            //Property(m => m.DishId).IsRequired();
            //Property(m => m.RestaurantId).IsRequired();
            //HasRequired(m => m.Category);
            //HasRequired(m => m.Restaurant);
            //HasRequired(a => a.Restaurant).WithMany(a => a.Menus).HasForeignKey(a => a.RestaurantId).WillCascadeOnDelete(false);
            //HasMany(m => m.Dish); //.WithMany(a => a.Menu).Map(m =>
            //{
            //    m.ToTable("MenuDish");
            //    m.MapLeftKey("MenuId");
            //    m.MapRightKey("Dish");
            //}); ;
        }
    }
}