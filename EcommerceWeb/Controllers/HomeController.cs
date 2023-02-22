using EcommerceWeb.Models;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics;

namespace EcommerceWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeSliderServices _slider;
        private readonly CollectionServices _collection;
        private readonly ProductServices _product;
        private readonly BannerService _bannerSer;
        private readonly BlogServices _blog;
		public HomeController(ILogger<HomeController> logger, HomeSliderServices slider, CollectionServices collection, ProductServices product, BannerService bannerSer, BlogServices blog)
		{
			_logger = logger;
			_slider = slider;
			_collection = collection;
			_product = product;
			_bannerSer = bannerSer;
			_blog = blog;
		}

		public IActionResult Index()
        {
            HomeVM vm = new()
            {
                homeSliders = _slider.GetAll(),
                Collections= _collection.GetAll(),
                TopSellingProducts=_product.GetAllHotForHome(),
                FeaturedProducts=_product.GetAllFeaturedForHome(),
                BannerProducts= _bannerSer.GetProduct(),
                Blogs=_blog.GetAll()
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}