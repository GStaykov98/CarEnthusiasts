namespace CarEnthusiasts.Models
{
    public class CarEnginesViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int HorsePower { get; set; }

        public int Torque { get; set; }

        public int Displacement { get; set; }

        public string Type { get; set; } = string.Empty;

        public string Aspiration { get; set; } = string.Empty;

        public double Acceleration { get; set; }

        public int TopSpeed { get; set; }

        public string Gearbox { get; set; } = string.Empty;
    }
}
