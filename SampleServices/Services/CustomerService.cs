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
    public class CustomerService:IDisposable
    {
        string _connectionString = ("https://northwind.vercel.app/api/Customers/");
        public CustomerService()
        {
            
        }
        public List<Customer> GetList()
        {
            List<Customer> list = new();
            using (var client = new RestClient(_connectionString))
            {
                RestRequest request = new RestRequest("", Method.Get);
                RestResponse response = client.GetAsync(request).Result;
                string responseString = response.Content;
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore,
                    DateParseHandling = DateParseHandling.DateTime
                };
                settings.Error += HandleDeserializationError;
                list = JsonConvert.DeserializeObject<List<Customer>>(responseString, settings);
                settings.Error -= HandleDeserializationError;
            }
            return list;
        }

        public Customer GetSingle(Customer item)
        {
            Customer result = new();
            using (var client = new RestClient(_connectionString + item.id))
            {
                RestRequest request = new RestRequest("", Method.Get);
                RestResponse response = client.GetAsync(request).Result;
                string responseString = response.Content;
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore,
                    DateParseHandling = DateParseHandling.DateTime
                };
                settings.Error += HandleDeserializationError;
                result = JsonConvert.DeserializeObject<Customer>(responseString, settings);
                settings.Error -= HandleDeserializationError;
            }
            return result;
        }

        public void Update(Customer item)
        {
            using (var client = new RestClient(_connectionString))
            {
                string jsonString = JsonConvert.SerializeObject(item);

                RestRequest request = new RestRequest(jsonString, Method.Put);
                RestResponse response = client.PutAsync(request).Result;
                string responseString = response.Content;
            }
        }

        public void Add(Customer item)
        {
            using (var client = new RestClient(_connectionString))
            {
                PropertyRenameAndIgnoreSerializerContractResolver jsonResolver = new PropertyRenameAndIgnoreSerializerContractResolver();
                jsonResolver.IgnoreProperty(typeof(Customer), "id");
                JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                serializerSettings.ContractResolver = jsonResolver;
                string jsonString = JsonConvert.SerializeObject(item, serializerSettings);

                RestRequest request = new RestRequest(jsonString, Method.Post);
                RestResponse response = client.PostAsync(request).Result;
                string responseString = response.Content;
            }
        }

        public void Delete(Customer Item)
        {
            using (var client = new RestClient(_connectionString + Item.id))
            {
                RestRequest request = new RestRequest("", Method.Delete);
                RestResponse response = client.DeleteAsync(request).Result;
                string responseString = response.Content;
            }
        }
        internal void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }

        public void Dispose()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
