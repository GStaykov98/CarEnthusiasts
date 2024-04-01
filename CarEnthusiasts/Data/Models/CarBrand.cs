using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Data.Models
{
    public class CarBrand
    {
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstraints.CarBrandMaxLength, MinimumLength = DataConstraints.CarBrandMinLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ImageURL { get; set; } = string.Empty;
    }
}
