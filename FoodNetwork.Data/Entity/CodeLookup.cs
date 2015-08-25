namespace FoodNetwork.Data.Entity
{
    public class CodeLookup : BaseEntity
    {
        public string CatagoryId { get; set; }
        public string SourceCode { get; set; }
        private string CategoryName { get; set; }
        public string Ethnicity { get; set; }
    }
}