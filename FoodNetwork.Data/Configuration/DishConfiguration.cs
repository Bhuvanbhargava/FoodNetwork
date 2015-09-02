using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Configuration
{
    public class DishConfiguration : BaseEntityConfiguration<Dish>
    {
        public DishConfiguration()
        {
            HasKey(a => a.DishId)
                .Property(a => a.DishId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Description).IsOptional();
            //Property(a => a.MenuId).IsRequired();
            Property(a => a.Name).IsRequired().HasMaxLength(100);
            Property(a => a.Price).IsRequired().HasPrecision(7, 2);
            Property(a => a.SpiceLavel).IsOptional();

            //HasRequired(a => a.Category);
            //HasRequired(d => d.Menu);
        }
    }
}