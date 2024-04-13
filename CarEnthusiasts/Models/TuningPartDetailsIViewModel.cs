using CarEnthusiasts.Data.Models;

namespace CarEnthusiasts.Models
{
    public class TuningPartDetailsIViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public double Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public TuningPartCategory Category { get; set; } = null!;

        public ICollection<TuningPartCarModel> TuningPartsCarModels { get; set; } = new List<TuningPartCarModel>();

        public ICollection<TuningPartCarModelViewModel> CarModels { get; set; } = new List<TuningPartCarModelViewModel>();
    }
}
