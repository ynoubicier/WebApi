using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PersonneAgeModel
    {
        [Key]
        public int IdPA { get; set; }
        public string? FirstNamePA { get; set; }
        public string? LastNamePA { get; set; }
        public string? BirthdatePA { get; set; }
        public string? BirthplacePA { get; set; }
        public string? CityPA { get; set; }
        public string? CountryPA { get; set;}
        public string? SocialStatus { get; set; }
        public string? MaritalStatusAS { get; set; }
        public string? HousingTypePA { get; set; }
        public string? PropertyTypePA { get; set; }
    }
}
