using System;
using System.Collections.Generic;

#nullable disable

namespace PraticeDB.Models
{
    public partial class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? ExpDate { get; set; }
        public int Status { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
