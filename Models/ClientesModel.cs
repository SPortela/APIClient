using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp.Models
{
    public class Clients
    {
        [Key]
        public int Identification{ get; set; }

        [Required]
        public string IdentificationType { get; set; }

        public string CompanyName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string FirstLastName { get; set; }

        public string SecondLastName { get; set; }

        public string Email { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modify { get; set; }
    }
}
