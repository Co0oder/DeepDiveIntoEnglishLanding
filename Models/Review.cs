using System.ComponentModel.DataAnnotations;

namespace DeepDiveIntoEnglishLanding.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Reviewer { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string ImageSource { get; set; }
    }
}