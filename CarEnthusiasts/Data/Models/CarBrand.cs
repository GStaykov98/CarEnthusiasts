using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Data.Models
{
    public class CarBrand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstraints.CarBrandMaxLength, MinimumLength = DataConstraints.CarBrandMinLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        public virtual ICollection<CarModel> Models { get; set; } = new List<CarModel>();
    }
}
