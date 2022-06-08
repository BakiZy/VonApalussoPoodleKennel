using FirstRealApp.Models;
using FirstRealApp.Models.DTO_models;

namespace FirstRealApp.Interfaces
{
    public interface IJWTManagerRepository
    {
        TokenDTO Authenticate(ApplicationUser user);
    }
}
