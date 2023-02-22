using Entities;

namespace EcommerceWeb.Models
{
    public class HomeVM
    {
        public List<HomeSlider>? homeSliders { get; set; }
        public List<Product>? FeaturedProducts { get; set; }
        public List<Product>? TopSellingProducts { get; set; }
        public List<Collection>? Collections { get; set; }
        public BannerProduct? BannerProducts { get; set; }
        public List<Blog>? Blogs { get; set; }
    }
}
