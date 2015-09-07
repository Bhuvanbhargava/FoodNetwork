using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace FoodNetwork.WebApi.Common
{
    public abstract class Resource
    {
        private readonly List<Link> links = new List<Link>();

        [JsonProperty(Order = 100)]
        public IEnumerable<Link> Links { get { return links; } }

        public void AddLink(Link link)
        {
            
            //Ensure.Argument.NotNull(link, "link");
            links.Add(link);
        }

        public void AddLinks(params Link[] links)
        {
            foreach (var link in links)
            {
                AddLink(link);
            }
            //links.ForEach(link => AddLink(link));
            
            
        }
    }
}