using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Ids
    {
        [Key]
        public string Identification { get; set; }

        [Required]
        public string IdentificationName { get; set; }
    }
}
