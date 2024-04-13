﻿namespace CarEnthusiasts.Models
{
    public class TuningPartViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public double Price { get; set; }

        public int Quantity {  get; set; }
    }
}
