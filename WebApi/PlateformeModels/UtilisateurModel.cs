using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class UtilisateurModel
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string? FirstNameUser { get; set; }
        [Required]
        public string? LastNameUser { get; set; }
        [Required]
        public string? EmailUser { get; set; }
        [Required]
        public string? PhoneUser { get; set; }
        [Required]
        public string? CitizenshipUser { get; set;}
        [Required]
        public DateFormat? BirthDateUser { get; set; }
        [Required]
        public string? BirthPlaceUser { get; set; }
        [Required]
        public string? StreetUser { get; set; }
        [Required]
        public string? CityUser { get; set; }
        [Required]
        public string? StateUser { get; set; }
        [Required]
        public string? ZipcodeUser { get; set; }
        [Required]
        public string? SocialStatusUser { get; set; }
        [Required]
        public string? MaritalStatusUser { get; set; }
    }
}
