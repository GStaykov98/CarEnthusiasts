using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Data.Models
{
    public class TuningPartCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        public ICollection<TuningPart> TuningParts { get; set; } = new List<TuningPart>();
    }
}
