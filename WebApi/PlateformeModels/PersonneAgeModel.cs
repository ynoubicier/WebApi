using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PersonneAgeModel
    {
        [Key]
        public int IdPA { get; set; }
        [Required]
        public string? FirstNamePA { get; set; }
        [Required]
        public string? LastNamePA { get; set; }
        [Required]
        public string? BirthdatePA { get; set; }
        [Required]
        public string? BirthplacePA { get; set; }
        [Required]
        public string? CityPA { get; set; }
        [Required]
        public string? CountryPA { get; set;}
        [Required]
        public string? SocialStatus { get; set; }
        [Required]
        public string? MaritalStatusAS { get; set; }
        [Required]
        public string? HousingTypePA { get; set; }
        [Required]
        public string? PropertyTypePA { get; set; }
    }
}
