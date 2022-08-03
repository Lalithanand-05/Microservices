using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    
        public class Orders
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public System.DateTime OrderDate { get; set; }
            public double OrderAmount { get; set; }
        }
    }
