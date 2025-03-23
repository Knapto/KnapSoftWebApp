using System.ComponentModel.DataAnnotations;

namespace KnapSoft.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; } // HTML obsah

        public string? Author { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Krátké shrnutí")]
        public string? Summary { get; set; }

        [Display(Name = "Obrázek (URL)")]
        public string? CoverImageUrl { get; set; }
    }
}
