using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class UtilisateurModel
    {
        [Key]
        public int IdUser { get; set; }
        public string? FirstNameUser { get; set; }
        public string? LastNameUser { get; set; }
        public string? EmailUser { get; set; }
        public string? PhoneUser { get; set; }
        public string? CitizenshipUser { get; set;}
        public DateFormat? BirthDateUser { get; set; }
        public string? BirthPlaceUser { get; set; }
        public string? StreetUser { get; set; }
        public string? CityUser { get; set;}
        public string? StateUser { get; set; }
        public string? ZipcodeUser { get; set; }
        public string? SocialStatusUser { get; set; }
        public string? MaritalStatusUser { get; set; }
    }
}
