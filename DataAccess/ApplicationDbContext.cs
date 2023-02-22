using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }  
        public DbSet<BannerProduct> BannerProducts { get; set; }  
        public DbSet<Collection> Collections { get; set; }  
        public DbSet<HomeSlider> HomeSliders { get; set; }  
        public DbSet<Picture> Pictures { get; set; }  
        public DbSet<ProductToCollection> ProductToCollections { get; set; }  
        public DbSet<ProductToPicture> ProductToPictures { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<TagToBlog> tagToBlogs { get; set; }
		public DbSet<Author> Authors { get; set; }
    }
}