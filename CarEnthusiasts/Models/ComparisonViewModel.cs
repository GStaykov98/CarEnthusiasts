namespace CarEnthusiasts.Models
{
    public class ComparisonViewModel
    {
        public List<CarsDropdownViewModel> Cars { get; set; } = new List<CarsDropdownViewModel>();
        public string SelectedCar1Id { get; set; } = string.Empty;
        public string SelectedCar2Id { get; set; } = string.Empty;

        public ComparedCarViewModel FirstCarFullInformation { get; set; } = new ComparedCarViewModel();

        public ComparedCarViewModel SecondCarFullInformation { get; set; } = new ComparedCarViewModel();
    }
}
