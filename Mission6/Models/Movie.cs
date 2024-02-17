using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        
        [Required]
        public required string Category {  get; set; }
        
        [Required]
        public required string Title { get; set; }
        
        [Required]
        public int Year { get; set; }
        
        [Required]
        public required string Director {  get; set; }
        
        [Required]
        public required string Rating { get; set; }
        
        public string? Edited { get; set; }
        
        public string? LentTo { get; set; }
        
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
