using FoodNetwork.FeatureContext.RestaurantFeature;
using FoodNetwork.WebApi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNetwork.WebApi.Areas.Restaurants
{
    public class RestaurantResponse : Resource
    {
        public RestaurantResponse(RestaurantDataTransferObject dto )
        {
            Name = dto.Name;
        }
        [Required]
        public string Name { get; set; }
    }
}