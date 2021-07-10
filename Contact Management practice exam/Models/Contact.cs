using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Contact_Management_practice_exam.Models
{
    public class Contact
    {

        public int ContactId { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public int PhoneNumber { get; set; }






    }
}
