using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.Common;

namespace FoodNetwork.Data.DBContext
{
    public class WindowsAuthenticationConnectionStringBuilder : IConnectionStringBuilder
    {
        private readonly object _syncLock;
        private string _foodNetworkConnectionString;

        public WindowsAuthenticationConnectionStringBuilder()
        {
            _syncLock = new object();
        }

        public string FoodNetworkConnectionString
        {
            get
            {
                lock (_syncLock)
                {
                    return _foodNetworkConnectionString ?? (_foodNetworkConnectionString = BuidConnectionString());
                }
            }
        }

        public const string FoodNetworkContextSetting = "FoodNetworkContextSettings";

        private string BuidConnectionString()
        {
            var setting = ConfigurationManager.GetSection(FoodNetworkContextSetting) as NameValueCollection;
            var builder = new DbConnectionStringBuilder
            {
                {
                    "Data Source",setting["server"]
                },
                {
                    "Initial Catalog",setting["dbName"]
                },
                {
                    "Integrated Security",true
                },
                 {
                    "MultipleActiveResultSets",true
                }                
                // {
                //    "user Id",setting["user"]
                //},
                //{
                //    "pwd",setting["pwd"]
                //},
            };
            return builder.ConnectionString;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}