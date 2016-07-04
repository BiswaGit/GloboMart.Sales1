using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using ProductWebAPI.Models;

namespace GloboMart.Sales.Service.ProductAPI.Controllers
{   
    public class ProductAPIController : ApiController
    {   
            private List<Product> ProductList = new List<Product>();
            public ProductAPIController()
            {
                ProductList.Add(new Product { ProductId = 1, Name = "Product1", ProductType = "Type1" });
                ProductList.Add(new Product { ProductId = 2, Name = "Product2", ProductType = "Type2" });
                ProductList.Add(new Product { ProductId = 3, Name = "Product3", ProductType = "Type3" });

            }
            // GET api/ProductAPI
            
            public IEnumerable<Product> GetProducts()
            {
                return ProductList;
            }

            // GET api/ProductAPI/5
            public Product GetProduct(int id)
            {
                return ProductList.Find(e => e.ProductId == id);

            }

            // POST api/ProductAPI
            public IEnumerable<Product> Post(Product value)
            {
                ProductList.Add(value);

                return ProductList;
            }

            // PUT api/ProductAPI/5
            public void Put(int id, string value)
            {

            }

            // DELETE api/ProductAPI/5
            public IEnumerable<Product> Delete(int id)
            {
                ProductList.Remove(ProductList.Find(P => P.ProductId == id));
                return ProductList;
            }
        }
}
