using CarEnthusiasts.Data.Models;

namespace CarEnthusiasts.Models
{
    public class ComparedCarViewModel
    {
        public string Brand { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public int ProductionStartYear { get; set; }

        public int ProductionEndYear { get; set; }

        public string DriveWheel { get; set; } = string.Empty;

        public int Weigth { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public CarEngine Engine { get; set; } = new CarEngine();
    }
}
