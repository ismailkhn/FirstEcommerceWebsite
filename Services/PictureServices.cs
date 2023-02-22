using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PictureServices
    {
        private readonly ApplicationDbContext _context;

        public PictureServices(ApplicationDbContext context)
        {
            _context = context;
        }  
        public Picture? GetPictureForId(int id)
        {
            return _context.Pictures.FirstOrDefault(c => c.Id == id);
        }
    }
}
