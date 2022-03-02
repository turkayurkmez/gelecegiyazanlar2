using System;
using System.Collections.Generic;

#nullable disable

namespace EFReverseEngineering.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
        public float Discount { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Category Category { get; set; }
    }
}
