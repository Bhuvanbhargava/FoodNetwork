using FoodNetwork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.FeatureContext
{
    public class BaseFeatureContext 
    {
        protected IUnitOfWork UnitOfWork;
        public BaseFeatureContext(IUnitOfWork uow)
        {
            UnitOfWork = uow;
        }
    }
}
