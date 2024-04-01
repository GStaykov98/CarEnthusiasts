using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarEnthusiasts.Data.Models
{
    public class CarModel
    {
        [Key]
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

        [Required]
        public int BrandId { get; set; }

        [ForeignKey(nameof(BrandId))]
        public CarBrand Brand { get; set; } = null!;
    }
}
