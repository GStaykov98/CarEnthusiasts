using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarEnthusiasts.Data.Models
{
    public class TuningPartCarModel
    {
        [Required]
        public int CarModelId { get; set; }

        [ForeignKey(nameof(CarModelId))]
        public CarModel CarModel { get; }

        [Required]
        public int TuningPartId { get; set; }

        [ForeignKey(nameof(TuningPartId))]
        public TuningPart TuningPart { get; }

    }
}
