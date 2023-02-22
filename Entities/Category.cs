using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(100)]    
        public string Name { get; set; }


        [MaxLength(700)]

        public bool IsDeleted { get; set; }

        public int? ParentCategoryId { get; set; }

        
        public virtual Category? ParentCategory{ get; set; }
    }
}
