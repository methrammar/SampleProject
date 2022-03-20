using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Model
{
    public interface IBaseModel
    {
        [Editable(false)]
        public abstract int? id { get; set; }
    }
}
