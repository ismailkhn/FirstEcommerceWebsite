using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOS
{
    public class ProductListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public int InStock { get; set; }
        public bool IsHot { get; set; }
        public decimal Rating { get; set; }
        public List<string>? Pictures { get; set; }
        public string? CoverPhoto { get; set; }

    }
}
