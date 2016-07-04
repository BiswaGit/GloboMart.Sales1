using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GloboMart.Sales.Service.ProductAPI.Models;

namespace GloboMart.Sales.Service.ProductAPI.Controllers
{
    public class PriceAPIController : ApiController
    {
        private List<Price> PriceList = new List<Price>();
            public PriceAPIController()
            {
                PriceList.Add(new Price { ProductId = 1, PriceId = 1, ProductPrice = 200 });
                PriceList.Add(new Price { ProductId = 2, PriceId = 2, ProductPrice = 300 });
                PriceList.Add(new Price { ProductId = 3, PriceId = 3, ProductPrice = 400 });

            }
            // GET api/PriceListAPI
            
            public IEnumerable<Price> GetPriceList()
            {
                return PriceList;
            }

            // GET api/ProductAPI/5
            public Price GetPrice(int id)
            {
                return PriceList.Find(e => e.ProductId == id);

            }            
        }
    }

