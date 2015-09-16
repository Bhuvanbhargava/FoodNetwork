using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodNetwork.Common.Attribute
{

    /// <summary>
    /// DependencyDiscovery attribut applied on class and struct to register them with Unity
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class DependencyDiscovery :  System.Attribute 
    {

        public readonly Type InterfaceType;

       /// <summary>
       /// Topic is a named parameter which is not required 
       /// </summary>
       /// <value>
       /// The topic.
       /// </value>
       public string Topic              
       {
          get 
          { 
             return topic; 
          }
          set 
          { 

            topic = value; 
          }
       }

       /// <summary>
       /// Initializes a new instance of the <see cref="DependencyDiscovery"/> class.
       /// </summary>
       /// <param name="interfaceType">Type of the interface.</param>
       public DependencyDiscovery(Type interfaceType)  // url is a positional parameter 
       {
           this.InterfaceType = interfaceType;
       }

        private string topic;
    }
}