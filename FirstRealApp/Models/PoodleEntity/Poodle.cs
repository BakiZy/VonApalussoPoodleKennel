using System.ComponentModel.DataAnnotations;

namespace FirstRealApp.Models.PoodleEntity
{
    public class Poodle
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression("[a-zA-ZČĆĐŠŽžšđćč-]")]
        public string? Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public bool? GeneticTests { get; set; }

        [MinLength(5, ErrorMessage = "pedigree must have at least 5 numbers ")]
        [MaxLength(11 , ErrorMessage = "pedigree number cannot be longer than 11 characters")]

        public string? PedigreeNumber { get; set; }

        public int? PoodleSizeId { get; set; }
        public List<PoodleSize>? PoodleSizes { get; set; }

        public int? PoodleColorId { get; set; }
        public List<PoodleColor>? PoodleColors { get; set; }

     








    }
}
