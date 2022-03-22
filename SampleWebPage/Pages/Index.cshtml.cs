using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SampleServices.Model;
using SampleServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Order> orders { get; private set; }
        public List<Employee> employees { get; private set; }
        public List<Customer> customers { get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            using(OrderService service = new OrderService()) 
            {
                orders = service.GetList();
            }
            using (EmployeeService service = new EmployeeService())
            {
                employees = service.GetList();
            }
            using (CustomerService service = new())
            {
                customers = service.GetList();
            }

            foreach (var item in orders)
            {
                item.employee = employees.Find(p => p.id == item.employeeId).firstName;
                item.customer = customers.Find(p => p.code == item.customerId).companyName;

            }
        }
    }
}
