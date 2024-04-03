namespace CarEnthusiasts.Models
{
    public class ShowComparedCarsViewModel
    {
        public string FirstCarId { get; set; } = string.Empty;

        public string SecondCarId { get; set; } = string.Empty;

        public ComparedCarViewModel FirstCarFullInformation { get; set; } = new ComparedCarViewModel();

        public ComparedCarViewModel SecondCarFullInformation { get; set; } = new ComparedCarViewModel();
    }
}
