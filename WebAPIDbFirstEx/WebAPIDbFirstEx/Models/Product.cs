using System;
using System.Collections.Generic;

namespace WebAPIDbFirstEx.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public double? Price { get; set; }
        public DateTime? MfDate { get; set; }
        public DateTime? ExpDate { get; set; }
    }
}
