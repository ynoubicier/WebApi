using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class AideSoignanteModel
    {
        [Key]
        public int IdAS { get; set; }
        public string? FirstNameAs { get; set; }
        public string? LastNameAs { get; set; }
        public string? CityAS { get; set; }
        public string? CountryAS { get; set;}
        public string? EmailAs { get; set; }
        public string? PhoneAs { get; set; }
        public DateFormat? BirthDateAs { get; set; }
        public string? BirthPlaceAs { get; set; }
        public string? ZipcodeAS { get; set; }
        public string? WorkplaceAS { get; set; }
        public string? DiplomaTitleAS { get; set; }
        public string? SocialStatusAS { get; set; }
        public string? MaritalStatusAS { get; set; }
        [Required]
        [RegularExpression("(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$",
            ErrorMessage = "Password must have 1 Uppercase, 1 Lowercase, 1 number, 1 non alphanumeric and at least 8 characters")]
        public string? PasswordAS { get; set; }
    }
}
