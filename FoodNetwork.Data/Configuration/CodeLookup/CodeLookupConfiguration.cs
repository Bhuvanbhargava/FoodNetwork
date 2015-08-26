using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Configuration
{
    public class CodeLookupConfiguration : BaseEntityConfiguration<CodeLookup>
    {
        public CodeLookupConfiguration()
        {
            HasKey(cl => cl.CodeLookupId)
                  .Property(cl => cl.CodeLookupId)
                  .IsRequired()
                  .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(cl => cl.Code).IsRequired();
            Map<Country>(m => m.Requires("Seperator").HasValue("Country"));
            Map<FoodCategory>(m => m.Requires("Seperator").HasValue("FoodCategory"));
            Map<FoodType>(m => m.Requires("Seperator").HasValue("FoodType"));
            Map<MenuCategory>(m => m.Requires("Seperator").HasValue("MenuCategory"));
            Map<Rating>(m => m.Requires("Seperator").HasValue("Rating"));
        }
    }
}