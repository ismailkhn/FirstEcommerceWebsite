using EcommerceWeb.Models;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace EcommerceWeb.Controllers
{
	public class BlogController : Controller
	{
		private readonly BlogServices _blogServices;
		private readonly TagServices _tagServices;
		private readonly BlogBlogCategoryServices _blogBlogCategoryServices;
		public BlogController(BlogServices blogServices, TagServices tagServices, BlogBlogCategoryServices blogBlogCategoryServices)
		{
			_blogServices = blogServices;
			_tagServices = tagServices;
			_blogBlogCategoryServices = blogBlogCategoryServices;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Details(int? id)
		{

			if (id == null) NotFound();

			Blog findBlog= _blogServices.GetById(id.Value);

			if(findBlog == null) return NotFound();

			BlogDetailsVM vm = new()
			{
				JustBlog = findBlog,
				LatestBlogs=_blogServices.GetLatestBlogs(id.Value),
				Tags=_tagServices.GetAll(),
				BlogCategories=_blogBlogCategoryServices.GetAll(),
				
			};
			return View(vm);
		}
	}
}
