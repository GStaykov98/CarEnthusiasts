namespace CarEnthusiasts.Models
{
    public class CarBrandsViewModel
    {
        public CarBrandsViewModel(
            int id,
            string name,
            string imageUrl) 
        {
            Id = id;
            Name = name;
            ImageURl = imageUrl;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURl { get; set; }
    }
}
