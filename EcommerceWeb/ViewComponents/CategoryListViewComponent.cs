using Helpers;
using Helpers.StaticModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Services;

namespace EcommerceWeb.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly CategoryServices _categoryServices;

        public CategoryListViewComponent(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public ViewViewComponentResult Invoke()
        {
            var categoryList = _categoryServices.GetCategories();
            List<CategoryWithChildren>? categoryWithChildren = CategoryHierarchyHelper.GetChildrenCategory(categoryList);

            return View(categoryWithChildren);  
        }
    }
}
