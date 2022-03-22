using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Model
{
    public class Employee : IBaseModel
    {
        public Employee()
        {
            address = new();
        }
        [Browsable(false)]
        public int? id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string title { get; set; }
        public string titleOfCourtesy { get; set; }
        public string birthDate { get; set; }
        public string hireDate { get; set; }
        [Browsable(false)]
        public Address address { get; set; }
        public string notes { get; set; }
        [Browsable(false)]
        public int reportsTo { get; set; }
        public int HigherUp { get; set; }
        [Browsable(false)]
        public int[] territoryIds { get; set; }
    }

}
