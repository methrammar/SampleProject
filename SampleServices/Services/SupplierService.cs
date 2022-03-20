using SampleServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services
{
    public class SupplierService:BaseService<Supplier>
    {
        public SupplierService() : base("https://northwind.vercel.app/api/Suppliers/")
        {

        }
    }
}
