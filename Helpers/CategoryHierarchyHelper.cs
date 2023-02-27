using Entities;
using Helpers.StaticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class CategoryHierarchyHelper
    {
        public static List<CategoryWithChildren>? GetChildrenCategory(List<Category> AllCategories)
        {
            if (AllCategories != null && AllCategories.Count > 0)
            {
                var categoryWithChildren = AllCategories.Select(cat => new CategoryWithChildren
                {
                    Parent = cat,
                    Children = AllCategories.Where(c => c.ParentCategoryId == cat.Id).ToList()
                }).ToList();

                return categoryWithChildren.Where(c => !c.Parent.ParentCategoryId.HasValue && !c.Parent.IsDeleted).ToList();
            }

            return null;

        }
    }
}
