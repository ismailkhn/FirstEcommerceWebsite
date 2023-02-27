using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.StaticModels
{
    public class CategoryWithChildren
    {
        public Category Parent { get; set; } = null!;
        public List<Category>? Children { get; set; }
    }
}
