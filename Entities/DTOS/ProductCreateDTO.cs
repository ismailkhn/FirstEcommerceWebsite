using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOS
{
    public class ProductCreateDTO
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int InStock { get; set; }
        public bool IsHot { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public decimal Cost { get; set; }
        public int? CategoryId { get; set; }
        public List<string>? Pictures { get; set; }
        public List<IFormFile>? PictureFiles { get; set; } 
        public string? CoverPhoto { get; set; }

        public IFormFile? CoverFile { get; set; }
    }
}
