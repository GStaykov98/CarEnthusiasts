using CarEnthusiasts.Data.Models;

namespace CarEnthusiasts.Models
{
    public class CarModelsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int ProductionStartYear { get; set; }

        public int ProductionEndYear { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public CarBrand Brand { get; set; } = new CarBrand();
    }
}
