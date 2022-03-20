using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using SampleServices.Model;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SampleServices.Controller;

namespace SampleServices.Services
{
    public class OrderService : BaseService<Order>
    {
        public OrderService() : base("https://northwind.vercel.app/api/orders/")
        {

        }
    }
}
