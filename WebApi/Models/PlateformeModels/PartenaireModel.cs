using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PartenaireModel
    {
        [Key]
        public int idPart { get; set; }
        public string? NamePart { get; set; }
        public string? TypePart { get; set; }
    }
}
