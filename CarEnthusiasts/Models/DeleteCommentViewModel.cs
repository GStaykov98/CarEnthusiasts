using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Models
{
    public class DeleteCommentViewModel
    {
        [Required]
        public int Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public int? ForumTopicId { get; set; }

        public int? ReviewId { get; set; }

        public int? NewsId { get; set; }
    }
}
