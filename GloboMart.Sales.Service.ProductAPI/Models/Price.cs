using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GloboMart.Sales.Service.ProductAPI.Models
{
    public class Price
    {
        public int PriceId { get; set; }

        public int ProductId { get; set; }

        public decimal ProductPrice { get; set; }
    }
}