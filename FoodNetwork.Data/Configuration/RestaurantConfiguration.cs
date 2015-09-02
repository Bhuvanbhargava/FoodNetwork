using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Configuration
{
    public class RestaurantConfiguration : BaseEntityConfiguration<Restaurant>
    {
        public RestaurantConfiguration()
        {
            HasKey(r => r.RestaurantId)
                .Property(r => r.RestaurantId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(r => r.Name).IsOptional();
            //Property(r => r.AddressId).IsRequired();
            //Property(r => r.CodeLookupId).IsRequired();
            //Property(r => r.FeedbackId).IsRequired();

            //HasRequired(r => r.FoodType);
            ////HasMany(r => r.Feedback).WithRequired();
            ////HasMany(r => r.Menus).WithRequired()
            //HasMany(a => a.Addresses).WithRequired();
        }
    }
}