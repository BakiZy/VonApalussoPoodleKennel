using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Interfaces
{
    public interface IPoodlesRepository
    {
        public IQueryable<Poodle> GetAll();

        public IQueryable<PoodleSize> GetAllSizes();

        public Poodle GetById(int id);

        Poodle GetByName(string name);

        void Add(Poodle poodle);

        void Update(Poodle poodle);

        void Delete(Poodle poodle);

        


    }
}
