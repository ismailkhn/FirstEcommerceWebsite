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
	public class BlogServices
	{
		private readonly ApplicationDbContext _context;

		public BlogServices(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<Blog> GetAll()
		{
			return _context.Blogs.Where(c => !c.IsDeleted)
				.Include(c => c.BlogCategory)
				.Include(c => c.TagToBlogs)
				.ThenInclude(c => c.Tag)
				.Include(c => c.Author).ToList();
		}

		public Blog? GetById(int id)
		{
			return _context.Blogs.Include(c=>c.Author).FirstOrDefault(c => c.Id == id && !c.IsDeleted);
		}

		public List<Blog> GetLatestBlogs(int id)
		{
			return _context.Blogs.Where(b => !b.IsDeleted && b.Id != id).OrderByDescending(c => c.PublishedTime).
				Include(b => b.BlogCategory)
				.ToList();
		}

		public void Add(Blog blog)
		{
			_context.Add(blog);
			_context.SaveChanges();
		}

		public void Uptade(Blog blog)
		{
			_context.Update(blog);
			_context.SaveChanges();
		}

		public void Delete(Blog blog)
		{
			blog.IsDeleted = true;
			_context.SaveChanges();
		}
	}
}
