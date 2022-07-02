using FirstRealApp.Models.DTO_models.FilterDTOS;
using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Interfaces
{
    public interface IFilterRepository
    {

        public IQueryable<Poodle> FilterPoodleByColor(string color);

        public IQueryable<Poodle> FilterPoodleBySize(string size);

        public IQueryable<Poodle> FilterPoodleByName(string name);

        public IQueryable<Poodle> FilterSizeAndColor(string size, string color);

        public IQueryable<Poodle> FilterNameAndColor(string name, string color);

        public IQueryable<Poodle> FilterNameAndSize(string name, string size);

        public IQueryable<Poodle> FilterAll(string size, string color, string name);




        public IQueryable<Poodle> GetAll();


    }
}
