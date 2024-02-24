using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category {  get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Year field is required")]
        public int? Year { get; set; }
        
        public string? Director {  get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "The Edited field is required")]
        public int? Edited { get; set; }
        
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "The Copied to Plex? field is required")]
        public int? CopiedToPlex { get; set; }

        public string? Notes { get; set; }


    }
}
