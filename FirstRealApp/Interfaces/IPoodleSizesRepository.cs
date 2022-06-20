using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Interfaces
{
    public interface IPoodleSizesRepository
    {

        public IQueryable<PoodleSize> GetAllSizes();
    }
}
