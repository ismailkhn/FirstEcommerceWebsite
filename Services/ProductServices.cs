using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductServices
    {
        private readonly ApplicationDbContext _context;

        public ProductServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public int GetProductCount()
        {
            return _context.Products.Count();
        }

        public List<Product> GetProductIsNew()
        {
            return _context.Products.Where(p=> p.IsNew && !p.IsDeleted).ToList();
        }

        public List<Product> GetDiscountProducts()
        {
            return _context.Products.Where(c =>!c.IsDeleted && c.Discount>0).ToList();
        }

        public List<Product> GetAll(string? search,int?catId)
        {
            var prod=_context.Products
                .Include(c => c.CoverPhoto)
                .Where(c => !c.IsDeleted).AsQueryable();
            if (catId.HasValue)
            {
                prod = prod.Where(c => c.CategoryId == catId);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                prod=prod.Where(c=>c.Name.Contains(search));
            }


            return prod.ToList();
                
		}
		public List<Product> GetAllFeaturedForHome()
		{
			return _context.Products.OrderByDescending(c=>c.ModifiedAt)
                .Include(c => c.CoverPhoto)
                .Where(c => !c.IsDeleted && c.IsFeatured).Take(15).ToList();
		}
		public List<Product> GetAllHotForHome()
		{
			return _context.Products.OrderByDescending(c => c.ModifiedAt)
                .Include(c => c.CoverPhoto)
                .Include(c=>c.ProductToPictures)
                .Where(c => !c.IsDeleted && c.IsHot).Take(15).ToList();
		}



		public Product? GetById(int id)
        {
            return _context.Products.
                Include(c => c.CoverPhoto)
                .Include(c=>c.ProductToPictures)
                .ThenInclude(c=>c.Picture)
                .FirstOrDefault(c => c.Id == id);
        }

        public void Add(Product Product)
        {
            _context.Add(Product);
            _context.SaveChanges();
        }

        public void Uptade(Product Product)
        {
            _context.Update(Product);
            _context.SaveChanges();
        }

        public void Delete(Product Product)
        {
            Product.IsDeleted = true;
            _context.SaveChanges();
        }
    }
}
