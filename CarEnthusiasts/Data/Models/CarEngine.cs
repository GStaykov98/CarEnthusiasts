using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarEnthusiasts.Data.Models
{
    public class CarEngine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int HorsePower { get; set; }

        [Required]
        public int Torque { get; set; }

        [Required]
        public int Displacement { get; set; }

        [Required]
        public string Type { get; set; } = string.Empty;

        [Required]
        public string Aspiration { get; set; } = string.Empty;

        [Required]
        public int TopSpeed { get; set; }

        [Required]
        public double Acceleration { get; set; }

        [Required]
        public string Gearbox { get; set; } = string.Empty;

        [Required]
        public int CarModelId { get; set; }

        [ForeignKey(nameof(CarModelId))]
        public CarModel CarModel { get; set; } = null!;
    }
}
