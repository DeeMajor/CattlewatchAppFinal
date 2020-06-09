using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CattlewatchAppFinal.Models
{
    public class Livestock
    {
        public int LivestockId { get; set; }
        [Required]
        public string livestockName { get; set; }
        
    }
}