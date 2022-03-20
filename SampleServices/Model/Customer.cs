using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SampleServices.Model
{

    public class Customer
    {
        [Browsable(false)]
        public string id { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        [Browsable(false)]
        public Address address { get; set; }

    }
    public class Shipper:IBaseModel
    {
        [Browsable(false)]
        public int? id { get; set; }
        public string CompanyName { get; set; }
        public string phone { get; set; }
    }
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string? phone { get; set; } = "";
    }
}
