using FirstRealApp.Interfaces;
using FirstRealApp.Models;
using FirstRealApp.Models.DTO_models.FilterDTOS;
using FirstRealApp.Models.DTO_models.PoodleDTos;
using FirstRealApp.Models.PoodleEntity;
using System.Data.SqlClient;
using System.Linq;                      

namespace FirstRealApp.Repository
{
    public class FilterRepository : IFilterRepository
    {
        private readonly AppDbContext _context;

        public FilterRepository(AppDbContext context)
        {
            _context = context;
        }


        public IQueryable<Poodle> FilterPoodleByColor(string color)
        {
            return _context.Poodles.Where(x => x.PoodleColor.Name == color).OrderByDescending(x => x.DateOfBirth);

        }

        public IQueryable<Poodle> FilterPoodleByName(string name)
        {

            return _context.Poodles.Where(x => x.Name.Contains(name)).OrderByDescending(x => x.DateOfBirth);
        }

        public IQueryable<Poodle> FilterPoodleBySize(string size)
        {


            return _context.Poodles.Where(x => x.PoodleSize.Name == size).OrderByDescending(x => x.DateOfBirth);

        }

        public IQueryable<Poodle> FilterSizeAndColor(string size, string color)
        {
            return _context.Poodles.Where(x => x.PoodleSize.Name == size && x.PoodleColor.Name == color).OrderByDescending(x => x.DateOfBirth);
        }
        
        public IQueryable<Poodle> FilterAll(string size, string color, string name)
        {
            return _context.Poodles.Where(x => x.Name.Contains(name) && x.PoodleSize.Name == size && x.PoodleColor.Name == color).OrderByDescending(x => x.DateOfBirth);
        }

        public IQueryable<Poodle> FilterNameAndSize(string name, string size)
        {
            return _context.Poodles.Where(x => x.Name.Contains(name) && x.PoodleSize.Name == size).OrderByDescending(x => x.DateOfBirth);
        }

        public IQueryable<Poodle> FilterNameAndColor(string name, string color)
        {

            return _context.Poodles.Where(x => x.Name.Contains(name) && x.PoodleColor.Name == color).OrderByDescending(x => x.DateOfBirth);
        }

        public IQueryable<Poodle> GetAll()
        {
            return _context.Poodles.OrderBy(x => x.DateOfBirth);
        }


    }
}

