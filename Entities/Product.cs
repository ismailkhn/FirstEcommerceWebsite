using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }
 
        [MaxLength(1500)]

        public int? CoverPhotoId { get; set; }
        public virtual Picture? CoverPhoto { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int InStock { get; set; }
        public bool IsHot { get; set; }
        public bool IsFeatured { get; set; }
        public decimal Rating { get; set; }
        public bool IsNew { get; set; }
        public decimal? Cost { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Manifacturer { get; set; }
        public virtual List<ProductToPicture> ProductToPictures { get; set; }
        public virtual Category? Category { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

    }

}
