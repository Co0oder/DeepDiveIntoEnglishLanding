using System.ComponentModel.DataAnnotations;

namespace DeepDiveIntoEnglishLanding.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Source { get; set; }
    }
}