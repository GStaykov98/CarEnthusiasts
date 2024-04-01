using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Data.Models
{
    public class CarModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstraints.CarModelMaxLength, MinimumLength = DataConstraints.CarModelMinLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int ProductionStartYear { get; set; }

        [Required]
        public int ProductionEndYear { get; set; }

        [Required]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
