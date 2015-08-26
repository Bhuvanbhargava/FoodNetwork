using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Configuration
{
    public class AddressConfiguration : BaseEntityConfiguration<Address>
    {
        public AddressConfiguration()
        {
            HasKey(a => a.AddressId)
                .Property(a => a.AddressId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Apartment).IsOptional();
            Property(a => a.City).IsRequired();
            Property(a => a.ContactNumber).IsOptional();
            Property(a => a.EmailId).IsRequired();
            Property(a => a.RestaurantId).IsRequired();
            Property(a => a.State).IsRequired();
            Property(a => a.Street).IsRequired();
            Property(a => a.Zip).IsRequired();
            HasRequired(a => a.Restaurant);
            HasRequired(a => a.Country);
        }
    }
}