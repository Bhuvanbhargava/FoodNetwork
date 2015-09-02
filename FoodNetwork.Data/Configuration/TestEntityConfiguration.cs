using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Configuration
{
    internal class TestEntityConfiguration : BaseEntityConfiguration<TestEntity>
    {
        public TestEntityConfiguration()
        {
            HasKey(a => a.TestEntityId)
                .Property(a => a.TestEntityId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Name).IsRequired();
            Property(a => a.LastName).IsRequired();
        }
    }
}