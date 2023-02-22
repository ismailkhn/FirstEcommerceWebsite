using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class TagServices
	{
		private readonly ApplicationDbContext _context;

		public TagServices(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<BlogTag> GetAll()
		{
			return _context.BlogTags.Where(b=>!b.IsDeleted).ToList();
		} 

	}
}
