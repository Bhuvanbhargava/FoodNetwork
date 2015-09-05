namespace FoodNetwork.Data.DBContext
{
    public class FoodNetworkDataBaseConnectionFactory 
    {
        public FoodNetworkDataBaseConnectionFactory(IConnectionStringBuilder connectionStringBuilder)
        {
            _connectionBuilder = connectionStringBuilder;
        }

        public IFoodNetworkDatabaseContext GetDbContext()
        {
            var context = new FoodNetworkDatabaseContext(_connectionBuilder.FoodNetworkConnectionString);          
            context.Configuration.LazyLoadingEnabled = false;
            return context;
        }

        private IConnectionStringBuilder _connectionBuilder;
    }
}