using SampleServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services
{
    public class CategoryService:BaseService<Category>
    {
        public CategoryService() : base("https://northwind.vercel.app/api/categories/")
        {

        }
    }
}
