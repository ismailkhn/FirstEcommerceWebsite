using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOS
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int InStock { get; set; }
        public bool IsHot { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public decimal Cost { get; set; }
        public decimal Rating { get; set; }
        public DateTime CreateAt { get; set; }
        public List<string>? Pictures { get; set; }
        public string? CategoryName { get; set; }
        public string? CoverPhoto { get; set; }
    }
}
