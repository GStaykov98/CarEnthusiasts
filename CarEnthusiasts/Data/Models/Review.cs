using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        public int ViewsCounter { get; set; } = 0;

        [Required]
        public DateTime CreatedOn { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
