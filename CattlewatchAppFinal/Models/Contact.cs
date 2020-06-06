using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CattlewatchAppFinal.Models
{
    public class Contact
    {
          
            public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Supject { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string Message { get; set; }
            [Required]
            public int Telephone { get; set; }


    }
}