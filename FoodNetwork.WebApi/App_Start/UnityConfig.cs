using FoodNetwork.Data.DBContext;
using FoodNetwork.FeatureContext;
using FoodNetwork.FeatureContext.RestaurantFeature;
using FoodNetwork.Repository;
using FoodNetwork.WebApi.Areas.Restaurants.ModelRepository;
using FoodNetwork.WebApi.Common;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;
using System.Reflection;
using System.Web.Http;
using Unity.WebApi;
using System.Linq;
using FoodNetwork.Common.Attribute;

namespace FoodNetwork.WebApi
{
    public static class UnityConfig
    {
        /// <summary>
        /// Registers the components.
        /// </summary>
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            string connectionString = ConfigurationManager.ConnectionStrings["FoodNetworkConnection"].ConnectionString;
            container.RegisterType<IFoodNetworkDatabaseContext, FoodNetworkDatabaseContext>(new PerResolveLifetimeManager(), new InjectionConstructor(connectionString));
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.Contains("FoodNetwork"));            
            foreach (Assembly assembly in assemblies)
            {
                var types =  from type in assembly.GetTypes()
                             where Attribute.IsDefined(type, typeof(DependencyDiscovery))
                             select type;
                foreach (Type type in types)
                {           
                    if (type.GetCustomAttributes(typeof(DependencyDiscovery),true).Length > 0)
                    {
                        DependencyDiscovery DependencyAttribute = (DependencyDiscovery)Attribute.GetCustomAttribute(type, typeof(DependencyDiscovery));
                        var fromType = DependencyAttribute.InterfaceType;
                        var toType = type;                        
                        container.RegisterType(fromType, toType,new ContainerControlledLifetimeManager());
                    }
                    
                }
            }
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            #region RunTime Cofiguration
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            //var container = new UnityContainer();
            //string connectionString = ConfigurationManager.ConnectionStrings["FoodNetworkConnection"].ConnectionString;
            //container.RegisterType<IFoodNetworkDatabaseContext, FoodNetworkDatabaseContext>(new PerResolveLifetimeManager(), new InjectionConstructor(connectionString));

            //container.RegisterType<IUnitOfWork, UnitOfWork>(new ContainerControlledLifetimeManager());
            //container.RegisterType<ITestEntityRepository, TestEntityRepository>(new ContainerControlledLifetimeManager());
            //container.RegisterType<ITestEntityFeatureContext, TestEntityFeatureContext>(new ContainerControlledLifetimeManager());
            //container.RegisterType<IRestaurantModelRepository, RestaurantModelRepository>(new ContainerControlledLifetimeManager());
            //container.RegisterType<IRestaurantFeatureContext, RestaurantFeatureContext>(new ContainerControlledLifetimeManager());
            //container.RegisterType<IRestaurantRepository, RestaurantRepository>(new ContainerControlledLifetimeManager());
            //GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            #endregion          
            #region DesignTime Cofiguration using WebConfig
            //var container = new UnityContainer().LoadConfiguration();
            //GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            #endregion
        }
    }
}