using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryServices
    {
        private readonly ApplicationDbContext _context;
        
        public CategoryServices(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public int GetCategoryCount()
        {
            return _context.Categories.Count();
        }


        public List<Category> GetParentCategories() 
        {
            return _context.Categories.Where(c => !c.IsDeleted && c.ParentCategoryId==null).ToList();
        }
        public List<Category> GetCategories()
        {
            return _context.Categories.Where(c => !c.IsDeleted).ToList();
        }
        
        public Category? GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }
        
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        
        public void Uptade(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
        
        public void Delete(Category category)
        {
            category.IsDeleted=true;
            _context.SaveChanges();
        }
    }
}
