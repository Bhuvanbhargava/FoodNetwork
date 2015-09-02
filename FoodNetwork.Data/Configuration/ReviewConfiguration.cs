using FoodNetwork.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodNetwork.Data.Configuration
{
    public class ReviewConfiguration : BaseEntityConfiguration<Review>
    {
        public ReviewConfiguration()
        {
            HasKey(f => f.ReviewId)
                .Property(f => f.ReviewId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.Message).IsRequired();
            //Property(f => f.RestaurantId).IsRequired();
            //HasRequired(f => f.Rating);
            //HasRequired(f => f.Restaurant);
        }
    }
}