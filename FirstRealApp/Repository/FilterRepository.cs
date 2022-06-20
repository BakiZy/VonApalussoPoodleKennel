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
            return _context.Poodles.Where(x => x.PoodleColor.Name == color);

        }

        public IQueryable<Poodle> SearchPoodleByName(string name)
        {
            return _context.Poodles.Where(x => x.Name.Contains(name)).OrderByDescending(x => x.Name);
        }

        public IQueryable<Poodle> SearchPoodleBySize(string size)
        {


            return _context.Poodles.Where(x => x.PoodleSize.Name == size);

        }


    }
}

