using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.DBContext
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        IFoodNetworkDatabaseContext Context { get; }
    }
}