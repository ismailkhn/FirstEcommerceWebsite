using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BlogBlogCategoryServices
    {
        private readonly ApplicationDbContext _context;
        
        public BlogBlogCategoryServices(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public int GetBlogCategoryCount()
        {
            return _context.BlogCategories.Count();
        }
        public List<BlogCategory> GetAll() 
        {
            return _context.BlogCategories.Where(c => !c.IsDeleted).ToList();
        }
        
        public BlogCategory? GetById(int id)
        {
            return _context.BlogCategories.FirstOrDefault(c => c.Id == id);
        }
        
        public void Add(BlogCategory blogCategory)
        {
            _context.Add(blogCategory);
            _context.SaveChanges();
        }
        
        public void Uptade(BlogCategory blogCategory)
        {
            _context.Update(blogCategory);
            _context.SaveChanges();
        }
        
        public void Delete(BlogCategory blogCategory)
        {
            blogCategory.IsDeleted=true;
            _context.SaveChanges();
        }
    }
}
