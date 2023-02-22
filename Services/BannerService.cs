using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class BannerService
	{
		private readonly ApplicationDbContext _context;

		public BannerService(ApplicationDbContext context)
		{
			_context = context;
		}

		public BannerProduct? GetProduct()
		{
			return _context.BannerProducts.FirstOrDefault();
		}
	}
}
