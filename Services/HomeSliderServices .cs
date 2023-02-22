using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HomeSliderServices
    {
        private readonly ApplicationDbContext _context;

        public HomeSliderServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public int GetHomeSliderCount()
        {
            return _context.HomeSliders.Count();
        }


        public List<HomeSlider> GetAll()
        {
            return _context.HomeSliders.Where(c => !c.IsDeleted).ToList();
        }

        public HomeSlider? GetById(int id)
        {
            return _context.HomeSliders.FirstOrDefault(c => c.Id == id);
        }

        public void Add(HomeSlider HomeSlider)
        {
            _context.Add(HomeSlider);
            _context.SaveChanges();
        }

        public void Uptade(HomeSlider HomeSlider)
        {
            _context.Update(HomeSlider);
            _context.SaveChanges();
        }

        public void Delete(HomeSlider HomeSlider)
        {
            HomeSlider.IsDeleted = true;
            _context.SaveChanges();
        }
    }
}
