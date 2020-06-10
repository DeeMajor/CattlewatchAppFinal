using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CattlewatchAppFinal.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ClientName { get; set; }
        public string ClientId { get; set; }
        public string Orderstatus { get; set; }
        public List<string> SelectedLivestock { get; set; }
    }
}