using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CattlewatchAppFinal.Models
{
    public class LivestockOrder
    {
        [Key]
        public int LivestoOrderckId { get; set; }
        public int numberOfLivestock { get; set; }
        [DisplayName("Livestock type")]
        [ForeignKey("LivestockId")]
        public Livestock Livestock { get; set; }
        public int LivestockId { get; set; }

        [DisplayName("Order Owner")]
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int OrderId { get; set; }

        [DisplayName("Location")]
        [ForeignKey("LocationId")]
        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}