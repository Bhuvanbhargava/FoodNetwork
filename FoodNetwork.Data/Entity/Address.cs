using System;

namespace FoodNetwork.Data.Entity
{
    public class Address : BaseEntity
    {
        public Guid AddressId { get; set; }
        public string Apartment { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public virtual Country Country { get; set; }
        public string EmailId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public Guid RestaurantId { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
    }
}