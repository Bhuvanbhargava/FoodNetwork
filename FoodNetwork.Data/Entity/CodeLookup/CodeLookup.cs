namespace FoodNetwork.Data.Entity
{
    public abstract class CodeLookup : BaseEntity
    {
        public string CodeLookupId { get; set; }
        public string Code { get; set; }
    }
}