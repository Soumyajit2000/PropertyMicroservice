using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyMicroservice.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        public string PropertyType { get; set; }

        public double Budget { get; set; }

        public string Locality { get; set; }
    }
}
