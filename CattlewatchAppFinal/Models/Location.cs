﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CattlewatchAppFinal.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Description { get; set; }
    }
}