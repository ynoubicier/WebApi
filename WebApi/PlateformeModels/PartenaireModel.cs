using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PartenaireModel
    {
        [Key]
        public int idPart { get; set; }
        [Required]
        public string? NamePart { get; set; }
        [Required]
        public string? TypePart { get; set; }
    }
}
