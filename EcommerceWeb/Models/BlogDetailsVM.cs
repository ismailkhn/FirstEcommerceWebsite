using Entities;

namespace EcommerceWeb.Models
{
	public class BlogDetailsVM
	{
		public Blog JustBlog { get; set; }

		public List<BlogCategory>? BlogCategories { get; set; }
		public List<BlogTag> BlogTags { get; set; }
		public List<BlogTag> Tags { get; set; }
		public List<Blog>? LatestBlogs { get; set; }

	}
}
