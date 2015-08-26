using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Configuration
{
    public class BaseEntityConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseEntityConfiguration()
        {
            Property(be => be.CreatedBy).IsRequired();
            Property(be => be.CreatedDate).IsRequired();
            Property(be => be.ModifiedBy).IsRequired();
            Property(be => be.ModifiedDate).IsRequired();
        }
    }
}