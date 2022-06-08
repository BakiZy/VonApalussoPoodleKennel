namespace FirstRealApp.Models.DTO_models
{
    public class TokenDTO
    {
        public string? Username { get; set; }
        public string? Token { get; set; }

        public string?  Email { get; set; }
        public DateTime Expiration { get; set; }
    }
}
