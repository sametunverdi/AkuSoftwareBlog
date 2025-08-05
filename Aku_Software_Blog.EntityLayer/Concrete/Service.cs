using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aku_Software_Blog.EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
        public string? ServiceCardName { get; set; }
        public string? ServiceCardDescription { get; set; }
        public string? ServiceCardIcon { get; set; }

    }
}
