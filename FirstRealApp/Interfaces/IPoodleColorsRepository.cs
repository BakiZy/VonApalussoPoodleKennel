using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Interfaces
{
    public interface IPoodleColorsRepository
    {

         IQueryable<PoodleColor> GetAllColors();

         void AddColor(PoodleColor color);

         void RemoveColor(PoodleColor color);




    }
}
