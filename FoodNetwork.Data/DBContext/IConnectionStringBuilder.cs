using System;

namespace FoodNetwork.Data.DBContext
{
    public interface IConnectionStringBuilder : IDisposable
    {
        string FoodNetworkConnectionString { get; }
    }
}