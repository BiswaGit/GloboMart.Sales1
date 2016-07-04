using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductType { get; set; }

        public string Name { get; set; }
        
    }
}