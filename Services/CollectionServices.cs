using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CollectionServices
    {
        private readonly ApplicationDbContext _context;

        public CollectionServices(ApplicationDbContext context)
        {
            _context = context;
        }
   

        public List<Collection> GetAll()
        {
            return _context.Collections.OrderByDescending(c=>c.Id).Where(c=>c.IsFeatured).Take(4).ToList();
        }

        public Collection? GetById(int id)
        {
            return _context.Collections.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Collection Collection)
        {
            _context.Add(Collection);
            _context.SaveChanges();
        }

        public void Uptade(Collection Collection)
        {
            _context.Update(Collection);
            _context.SaveChanges();
        }

     
    }
}
