﻿using FoodNetwork.Common.Attribute;
using FoodNetwork.FeatureContext.RestaurantFeature;
using FoodNetwork.WebApi.Areas.Restaurants;
using FoodNetwork.WebApi.Common;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodNetwork.WebApi.Areas.Restaurants.ModelRepository
{
    [DependencyDiscovery(typeof(IRestaurantModelRepository))]
    public class RestaurantModelRepository : IRestaurantModelRepository
    {
        private IRestaurantFeatureContext _restaurantFeatureContext;
        public RestaurantModelRepository(IRestaurantFeatureContext restaurantFeatureContext)
         {
             _restaurantFeatureContext = restaurantFeatureContext;

        }
        public IEnumerable<RestaurantResponse> GetRestaurants() 
        {
            var restaurantsDto= _restaurantFeatureContext.GetRestaurant();
            if (restaurantsDto.Count() == 0)
            {
                throw new CustomArgumentException(409,"erro");
            }
             return restaurantsDto.Select(a => new RestaurantResponse(a));
            //if (restaurants.Count() == 0) 
            //{

            //}
          
            

        }
        public IEnumerable<string> GetAll()
        {

            return new List<string> { "string", "test" };



        }



        
    }
}