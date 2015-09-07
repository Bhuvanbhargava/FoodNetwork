using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodNetwork.WebApi.Common
{
    /// <summary>
    /// A base class for relation links
    /// </summary>
    public abstract class Link
    {
        public string Rel { get; private set; }
        public string Href { get; private set; }
        public string Title { get; private set; }

        public Link(string relation, string href, string title = null)
        {
            if (string.IsNullOrEmpty(relation)) 
            {
                relation = "relation";
            }
            if (string.IsNullOrEmpty(href))
            {
                relation = "href";
            }
            //Ensure.Argument.NotNullOrEmpty(relation, "relation");
            //Ensure.Argument.NotNullOrEmpty(href, "href");

            Rel = relation;
            Href = href;
            Title = title;
        }
    }

    /// <summary>
    /// Refers to a resource that can be used to edit the link's context.
    /// </summary>
    public class EditLink : Link
    {
        public const string Relation = "edit";

        public EditLink(string href, string title = null)
            : base(Relation, href, title)
        {
        }
    }
}