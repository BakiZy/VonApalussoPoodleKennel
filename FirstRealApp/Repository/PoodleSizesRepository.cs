using FirstRealApp.Interfaces;
using FirstRealApp.Models;
using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Repository
{
    public class PoodleSizesRepository
    {
        private readonly AppDbContext? _context;

        public PoodleSizesRepository(AppDbContext context)
        {
            _context = context;
        }

      

      

    }
}
