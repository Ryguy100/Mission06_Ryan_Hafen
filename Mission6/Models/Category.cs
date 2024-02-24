using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    // Categories model
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }

    }
}
