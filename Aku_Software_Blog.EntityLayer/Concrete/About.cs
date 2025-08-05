using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aku_Software_Blog.EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TeamHeader { get; set; }
        public string TeamDescription { get; set; }
        public string TeamImage { get; set; }
        public string TeamRol { get; set; }
        public string Name { get; set; }
    }
}
