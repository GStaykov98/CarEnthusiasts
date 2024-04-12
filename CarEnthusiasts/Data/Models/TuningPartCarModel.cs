using System.ComponentModel.DataAnnotations.Schema;

namespace CarEnthusiasts.Data.Models
{
    public class TuningPartCarModel
    {
        public int CarModelId { get; set; }

        [ForeignKey(nameof(CarModelId))]
        public CarModel CarModel { get; set; } = new CarModel();


        public int TuningPartId { get; set; }

        [ForeignKey(nameof(TuningPartId))]
        public TuningPart TuningPart { get; set; } = new TuningPart();

    }
}
