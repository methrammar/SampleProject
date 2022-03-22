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
    public class Product : IBaseModel
    {
        public Product()
        {
            this.supplier = new Supplier();
        }
        [Browsable(false)]
        public int? id { get; set; }
        [Browsable(false)]
        public int supplierId { get; set; }
        [Browsable(false)]
        public int categoryId { get; set; }
        public string name { get; set; }
        public string quantityPerUnit { get; set; }
        public double unitPrice { get; set; }
        public double unitsInStock { get; set; }
        public double unitsOnOrder { get; set; }
        public double reorderLevel { get; set; }
        public bool discontinued { get; set; } = true;
        [Browsable(false)]
        public Supplier supplier { get; set; }
        [JsonIgnore]
        public string supplierName { get => this.supplier.companyName==null?"":this.supplier.companyName; } 
    }

    public class Supplier: IBaseModel
    {
        public Supplier()
        {
            this.address = new Address();
        }
        [Browsable(false)]
        public  int? id { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        [Browsable(false)]
        public Address address { get; set; }
        [JsonIgnore]
        public string city { get => this.address.city; }
    }

    public class Category : IBaseModel
    {
        [Browsable(false)]
        public int? id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

}
