using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aku_Software_Blog.EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; }
        public string? FeatureName { get; set; }
        public string? FeatureDescription { get; set; }
        public string? FeatureImage { get; set; }
    }
}
