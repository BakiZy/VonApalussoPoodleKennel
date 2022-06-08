namespace FirstRealApp.Repository
{
    public class JWTManagerRepository
    {
        private readonly IConfiguration configuration;

        public JWTManagerRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


    }
}
