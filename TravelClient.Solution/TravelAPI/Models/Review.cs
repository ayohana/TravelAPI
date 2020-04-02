using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [StringLength(15, ErrorMessage="Destination cannot exceed 15 characters")]
        public string Destination { get; set; }
       
        [MaxLength(30, ErrorMessage="Title cannot exceed 30 characters.")]
        public string Title { get; set; }
       
        [MinLength(5, ErrorMessage="Description must be at least 5 characters.")]
        public string Description { get; set; }
      
        [Range(1, 5, ErrorMessage="Rating must be between 1 and 5.")]
        public int Rating { get; set; }
        [Required]
        [StringLength(10)]
        public string user_name { get; set; }
    }
}