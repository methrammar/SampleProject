using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Model
{
    public class Order : IBaseModel
    {
        public Order()
        {
            this.details = new List<Detail>();
            this.shipAddress = new Address();
        }
        [Editable(false)]
        [Browsable(false)]
        public int? id { get; set; }
        [Browsable(false)]
        public string customerId { get; set; }
        [JsonIgnore]
        public string customer { get; set; }
        [Browsable(false)]
        public int employeeId { get; set; }
        [JsonIgnore]
        public string employee { get; set; }
        public DateTime? orderDate { get; set; } = DateTime.Today;
        public DateTime? requiredDate { get; set; }
        public DateTime? shippedDate { get; set; }
        [Browsable(false)]
        public int shipVia { get; set; }
        [JsonIgnore]
        public string shippingCompany { get; set; }
        public double freight { get; set; }
        public string shipName { get; set; }
        [Browsable(false)]
        public Address shipAddress { get; set; }
        [Browsable(false)]
        public List<Detail> details { get; set; }
        [JsonIgnore]
        public double total { get => this.details.Sum(p => p.discountedTotal); }
    }
    public class Detail
    {
        [Editable(false)]
        [Browsable(false)]
        public int productId { get; set; }
        [JsonIgnore]
        public string productName { get; set; }
        public double unitPrice { get; set; }
        public double quantity { get; set; }
        public double discount { get; set; }
        [JsonIgnore]
        public double discountedPricePerItem { get => this.unitPrice * (1 + (discount / 100)); }
        [JsonIgnore]
        public double discountedTotal { get => discountedPricePerItem * quantity; }

    }
}
