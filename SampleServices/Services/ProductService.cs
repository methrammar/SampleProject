using Newtonsoft.Json;
using RestSharp;
using SampleServices.Controller;
using SampleServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services
{
    public class ProductService:BaseService<Product>
    {
        public ProductService():base("https://northwind.vercel.app/api/products/")
        {
            
        }
    }
}
