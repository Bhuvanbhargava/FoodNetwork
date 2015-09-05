using FoodNetwork.Data.DBContext;
using FoodNetwork.FeatureContext;
using FoodNetwork.Repository;
using Microsoft.Practices.Unity;
using System.Configuration;
using System.Web.Http;
using Unity.WebApi;

namespace FoodNetwork.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            string connectionString = ConfigurationManager.ConnectionStrings["FoodNetworkConnection"].ConnectionString;
            container.RegisterType<IFoodNetworkDatabaseContext, FoodNetworkDatabaseContext>(new PerResolveLifetimeManager(), new InjectionConstructor(connectionString));
          
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<ITestEntityRepository, TestEnityRepository>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<ITestEntityFeatureContext, TestEntityFeatureContext>();
            //container.RegisterType<IUnitOfWork, UnitOfWork>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}