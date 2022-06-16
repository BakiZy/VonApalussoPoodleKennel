using FirstRealApp.Interfaces;
using FirstRealApp.Models;
using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Repository
{
    public class PoodleColorsRepository : IPoodleColorsRepository
    {

        private readonly AppDbContext? _context;

        public PoodleColorsRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddColor(PoodleColor color)
        {
            _context.PoodleColors.Add(color);
            _context.SaveChanges();
        }

        public IQueryable<PoodleColor> GetAllColors()
        {
            return _context.PoodleColors.OrderBy(x => x.Name);
        }

        public void RemoveColor(PoodleColor color)
        {
            _context.PoodleColors.Remove(color);
            _context.SaveChanges();
        }
    }
}
