using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Models
{
    public partial class Email
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Not valid email")]
        public string EmailAddress { get; set; }
        
    }
}
