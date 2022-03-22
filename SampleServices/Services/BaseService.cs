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
using SampleDataAccess.Model;

namespace SampleServices.Services
{
    public class BaseService<T> :IDisposable where T : class , IBaseModel, new() 
    {
        string _connectionString;
        internal BaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<T> GetList()
        {
            List<T> list = new();
            Log log = new Log()
            {
                METHOD = "GetList",
                OBJECT = typeof(T).ToString(),
            };
            try 
            {             
                using (var client = new RestClient(_connectionString))
                {
                    RestRequest request = new RestRequest("", Method.Get);
                    RestResponse response = client.GetAsync(request).Result;
                    log.STATUSCODE = response.StatusCode.ToString();
                    log.STATUSDESCRIPTION = response.StatusDescription;
                    string responseString = response.Content;
                    var settings = new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented,
                        NullValueHandling = NullValueHandling.Ignore,
                        DateParseHandling = DateParseHandling.DateTime
                    };
                    settings.Error += HandleDeserializationError;
                    list = JsonConvert.DeserializeObject<List<T>>(responseString, settings);
                    settings.Error -= HandleDeserializationError;

                }
                return list;
            }
            catch (Exception ex)
            {
                log.EXCEPTION = ex.Message;
                return null;
            }
            finally
            {
                log.Post();
            }
        }

        public T GetSingle(T item)
        {
            Log log = new Log()
            {
                METHOD = "GetSingle",
                OBJECT = typeof(T).ToString(),
            };
            T result = new();
            try 
            {
                string id;
                if (typeof(T) == typeof(Customer)) 
                { 
                    id = (item as Customer).code;
                    
                }
                else
                    id = Convert.ToString(item.id);
                
                using (var client = new RestClient(_connectionString + id))
                {
                    RestRequest request = new RestRequest("", Method.Get);
                    RestResponse response = client.GetAsync(request).Result;
                    log.STATUSCODE = response.StatusCode.ToString();
                    log.STATUSDESCRIPTION = response.StatusDescription;
                    string responseString = response.Content;
                    var settings = new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented,
                        NullValueHandling = NullValueHandling.Ignore,
                        DateParseHandling = DateParseHandling.DateTime
                    };
                    settings.Error += HandleDeserializationError;
                    result = JsonConvert.DeserializeObject<T>(responseString, settings);
                    settings.Error -= HandleDeserializationError;


                }
                return result;
            }
            catch(Exception ex)
            {
                log.EXCEPTION = ex.Message;
                return null;
            }
            finally
            {
                log.Post();
            }
        }

        public void Update(T item)
        {
            Log log = new Log()
            {
                METHOD = "Update",
                OBJECT = typeof(T).ToString(),
            };
            try 
            {
                PropertyRenameAndIgnoreSerializerContractResolver jsonResolver = new PropertyRenameAndIgnoreSerializerContractResolver();
                string id;
                if (typeof(T) == typeof(Customer))
                {
                    id = (item as Customer).code;
                    
                }
                else
                    id = Convert.ToString(item.id);
                
                if(typeof(T) == typeof(Order))
                    jsonResolver.IgnoreProperty(typeof(Address), "phone");

                JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                serializerSettings.ContractResolver = jsonResolver;
                string jsonString = JsonConvert.SerializeObject(item, serializerSettings);

                using (var client = new RestClient(_connectionString+id))
                {
                    
                    RestRequest request = new RestRequest();
                    request.Method = Method.Put;
                    request.AddStringBody(jsonString,DataFormat.Json);
                    RestResponse response = client.PutAsync(request).Result;
                    log.STATUSCODE = response.StatusCode.ToString();
                    log.STATUSDESCRIPTION = response.StatusDescription;
                }
            }
            catch(Exception ex)
            {
                log.EXCEPTION=ex.Message;
            }
            finally
            {
                log.Post();
            }
        }

        public void Add(T item)       
        {
            Log log = new Log()
            {
                METHOD = "Add",
                OBJECT = typeof(T).ToString(),
            };
            try 
            {
                PropertyRenameAndIgnoreSerializerContractResolver jsonResolver = new PropertyRenameAndIgnoreSerializerContractResolver();

                jsonResolver.IgnoreProperty(typeof(T), "id");

                if (typeof(T) == typeof(Order))
                    jsonResolver.IgnoreProperty(typeof(Address), "phone");

                JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                serializerSettings.ContractResolver = jsonResolver;
                string jsonString = JsonConvert.SerializeObject(item, serializerSettings);


                using (var client = new RestClient(_connectionString))
                {
                    RestRequest request = new RestRequest();
                    request.Method = Method.Post;
                    request.AddStringBody(jsonString,DataFormat.Json);
                    RestResponse response = client.PostAsync(request).Result;
                    log.STATUSCODE = response.StatusCode.ToString();
                    log.STATUSDESCRIPTION = response.StatusDescription;
                }
            }
            catch(Exception ex)
            {
                log.EXCEPTION = ex.Message;
            }
            finally
            {
                log.Post();
            }
        }

        public void Delete(T item)
        {
            Log log = new Log()
            {
                METHOD = "Add",
                OBJECT = typeof(T).ToString(),
            };
            try
            {
                string id;
                if (typeof(T) == typeof(Customer))
                {
                    id = (item as Customer).code;

                }
                else
                    id = Convert.ToString(item.id);


                using (var client = new RestClient(_connectionString+id))
                {
                    RestRequest request = new RestRequest("", Method.Delete);
                    RestResponse response = client.DeleteAsync(request).Result;
                    log.STATUSCODE = response.StatusCode.ToString();
                    log.STATUSDESCRIPTION = response.StatusDescription;
                }
            }
            catch (Exception ex)
            {
                log.EXCEPTION=ex.Message;
            }
            finally
            {
                log.Post();
            }
        }
        internal void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {            
            errorArgs.ErrorContext.Handled = true;
        }

        public void Dispose()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
