using FoodNetwork.Data.DBContext;
using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Repository
{
    public interface IBaseRepository
    {        
          void Save();
    }
}