﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCore.Entity
{
    public class Shipper
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
        public string Contact_Person { get; set; }
        public IEnumerable<ShipperRegion> Region { get; set; }
    }
}
