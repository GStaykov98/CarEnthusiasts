using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Models
{
	public class BuyPartViewModel
	{
		public int Id { get; set; }

		public string PartName { get; set; } = string.Empty;

		public double Price { get; set; }

		[Required]
		public string BuyerName { get; set; } = string.Empty;

		[Required]
		public string BuyerEmail {  get; set; } = string.Empty;

		[Required]
		public string DeliveryAddress { get; set;} = string.Empty;

		public string ImageUrl { get; set; } = string.Empty;
	}
}
