using SampleServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services
{
    public class EmployeeService:BaseService<Employee>
    {
        public EmployeeService() : base("https://northwind.vercel.app/api/Employess/")
        {

        }
    }
}
