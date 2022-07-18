using FirstRealApp.Interfaces;
using FirstRealApp.Models;
using FirstRealApp.Models.DTO_models.FilterDTOS;
using FirstRealApp.Models.DTO_models.PoodleDTos;
using FirstRealApp.Models.PoodleEntity;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FirstRealApp.Repository
{
    public class FilterRepository : IFilterRepository
    {
        private readonly AppDbContext _context;


        public FilterRepository(AppDbContext context)
        {
            _context = context;
        }

        private IQueryable<Poodle> Template()
        {
            var poodles = _context.Poodles;
            var colors = _context.PoodleColors;
            IQueryable<Poodle> query;
            return query = from p in poodles join c in colors on p.PoodleColorId equals c.Id select p;
        }


        public IQueryable<Poodle> FilterPoodleByColor(string color)
        {


            return _context.Poodles.Include(x => x.PoodleColor).Where(x => x.PoodleColor.Name.Equals(color)).OrderBy(x => x.Id);
        }

        public IQueryable<Poodle> FilterPoodleByName(string name)
        {

            return _context.Poodles.Where(x => x.Name.Contains(name)).OrderBy(x => x.Id);
        }

        public IQueryable<Poodle> FilterPoodleBySize(string size)
        {


            return _context.Poodles.Where(x => x.PoodleSize.Name == size).OrderBy(x => x.Id);

        }

        public IQueryable<Poodle> FilterSizeAndColor(string size, string color)
        {
            var query = Template();

            if (!string.IsNullOrEmpty(size) && !string.IsNullOrEmpty(color))
            {
                return query.Where(x => x.PoodleSize.Name.Equals(size) && x.PoodleColor.Name.Equals(color)).OrderBy(x => x.Id);
            }

            if (!string.IsNullOrEmpty(size))
            {
                return query.Where(x => x.PoodleSize.Name.Equals(size)).OrderBy(x => x.Id);

            }

            if (!string.IsNullOrEmpty(color))
            {
                return query.Where(x => x.PoodleColor.Name.Equals(color)).OrderBy(x => x.Id);
            }

            else return query;




        }





        public IQueryable<Poodle> GetAll()
        {
            return _context.Poodles.OrderByDescending(x => x.DateOfBirth);
        }


    }
}

