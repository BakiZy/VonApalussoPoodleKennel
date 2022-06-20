using FirstRealApp.Interfaces;
using FirstRealApp.Models;
using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Repository
{
    public class PoodleSizesRepository : IPoodleSizesRepository
    {
        private readonly AppDbContext? _context;

        public PoodleSizesRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<PoodleSize> GetAllSizes()
        {
            return _context.PoodleSizes.OrderBy(x => x.Id);
        }

      

    }
}
