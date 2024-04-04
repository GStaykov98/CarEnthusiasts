using CarEnthusiasts.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Models
{
    public class NewsInformationViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public int ViewsCounter { get; set; } = 0;

        public DateTime CreatedOn { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
