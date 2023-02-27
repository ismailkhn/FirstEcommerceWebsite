using EcommerceWeb.Models;
using Entities;
using Helpers;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace EcommerceWeb.Controllers
{
	public class ProductController : Controller
	{
		private readonly ProductServices _productService;
		private readonly CategoryServices _categoryService;

        public ProductController(ProductServices productService, CategoryServices categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(string? search,int? categoryId)
		{
			ProductFilterVM vm = new()
			{
				ProductList = _productService.GetAll(search,categoryId),
				CategoryList=_categoryService.GetCategories(),
				SearchText=search
			};

			var a = CategoryHierarchyHelper.GetChildrenCategory(vm.CategoryList);

			return View(vm);
		}


		public IActionResult Details(int? id)
		{
			if (id == null) return NotFound();

			Product? findProduct = _productService.GetById(id.Value);

			if(findProduct == null) return NotFound();

			ProductDetailsVM vm = new()
			{
				ProductSingle = findProduct
			};
			return View(vm);
		}
	}
}
