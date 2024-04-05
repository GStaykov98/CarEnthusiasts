using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarEnthusiasts.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;


        public int? NewsId { get; set; }


        [ForeignKey(nameof(NewsId))]
        public News? News { get; set; }


        public int? ReviewId { get; set; }


        [ForeignKey(nameof(ReviewId))]
        public Review? Review { get; set; }


        public int? ForumTopicId { get; set; }


        [ForeignKey(nameof(ForumTopicId))]
        public ForumTopic? ForumTopic { get; set; }
    }
}
