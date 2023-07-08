using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class AideSoignanteModel
    {
        [Key]
        public int IdAS { get; set; }
        [Required]
        public string? FirstNameAs { get; set; }
        [Required]
        public string? LastNameAs { get; set; }
        [Required]
        public string? CityAS { get; set; }
        [Required]
        public string? CountryAS { get; set;}
        [Required]
        public string? EmailAs { get; set; }
        [Required]
        public string? PhoneAs { get; set; }
        [Required]
        public DateFormat? BirthDateAs { get; set; }
        [Required]
        public string? BirthPlaceAs { get; set; }
        [Required]
        public string? ZipcodeAS { get; set; }
        [Required]
        public string? WorkplaceAS { get; set; }
        [Required]
        public string? DiplomaTitleAS { get; set; }
        [Required]
        public string? SocialStatusAS { get; set; }
        [Required]
        public string? MaritalStatusAS { get; set; }
        [Required]
        [RegularExpression("(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$",
            ErrorMessage = "Password must have 1 Uppercase, 1 Lowercase, 1 number, 1 non alphanumeric and at least 8 characters")]
        public string? PasswordAS { get; set; }
    }
}
