using FirstRealApp.Interfaces;
using FirstRealApp.Models;
using FirstRealApp.Models.DTO_models.FilterDTOS;
using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Repository
{
    public class FilterRepository : IFilterRepository
    {
        private readonly AppDbContext _context;

        public FilterRepository(AppDbContext context)
        {
            _context = context;
        }


        public IQueryable<Poodle> SearchPoodleByColor(string color)
        {
            return _context.Poodles.Where(x => x.PoodleColor.Name == color).OrderByDescending(x => x.DateOfBirth);

        }

        public IQueryable<Poodle> SearchPoodleByName(string name)
        {

            return _context.Poodles.Where(x => x.Name.Contains(name)).OrderByDescending(x => x.DateOfBirth);
        }

        public IQueryable<Poodle> SearchPoodleBySize(string size)
        {


            return _context.Poodles.Where(x => x.PoodleSize.Name == size).OrderByDescending(x => x.DateOfBirth);

        }

        public IQueryable<Poodle> Filter(string size, string color)
        {
            return _context.Poodles.Where(x => x.PoodleSize.Name == size && x.PoodleColor.Name == color).OrderByDescending(x => x.DateOfBirth);
        }

        public IQueryable<Poodle> GetAll()
        {
            return _context.Poodles.OrderBy(x => x.DateOfBirth);
        }

  /*      public IQueryable<Poodle> FilterColorAndSize(string size, st)
        {
            if (filter.PoodleColor == null && filter.PoodleSize == null)
            {
                return GetAll();
            }

            return _context.Poodles.Where(x => x.Name == filter.PoodleColor.Name);

        }*/


    }
}

