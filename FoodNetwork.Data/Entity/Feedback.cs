using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.Entity
{
    public class Feedback : BaseEntity
    {
        public Guid FeedbackId { get; set; }
        public string Message { get; set; }
        public int Rating  { get; set; }
        public virtual Restaurant Restaurant { get; set; } 
    }
}
