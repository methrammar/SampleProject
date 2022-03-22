using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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
    public class CustomerService : BaseService<Customer>
    {
        public CustomerService() : base("https://northwind.vercel.app/api/Customers/")
        {

        }
    }
}
