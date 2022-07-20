namespace FirstRealApp.Models.DTO_models.PoodleDTos
{
    public class PoodleDetailDTO
    {
        public int Id { get; set; }


        public string? Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool? GeneticTests { get; set; }

        public string? PedigreeNumber { get; set; }

        public string? SizeName { get; set; }

        public string? ColorName { get; set; }

        public string? Image { get; set; }
    }
}
