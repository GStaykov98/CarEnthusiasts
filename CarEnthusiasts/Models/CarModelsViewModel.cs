using CarEnthusiasts.Data;
using CarEnthusiasts.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Models
{
    public class CarModelsViewModel
    {
        public CarModelsViewModel(
            int id,
            string name,
            int productionStartYear,
            int productionEndYear,
            string imageUrl,
            CarBrand brand)
        {
            Id = id;
            Name = name;
            ProductionStartYear = productionStartYear;
            ProductionEndYear = productionEndYear;
            ImageUrl = imageUrl;
            Brand = brand;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ProductionStartYear { get; set; }

        public int ProductionEndYear { get; set; }

        public string ImageUrl { get; set; }

        public CarBrand Brand { get; set; }
    }
}
