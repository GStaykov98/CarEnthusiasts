namespace CarEnthusiasts.Models
{
    public class CarsDropdownViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public List<EnginesDropdownViewModel> Engines { get; set; } = new List<EnginesDropdownViewModel>();
    }
}
