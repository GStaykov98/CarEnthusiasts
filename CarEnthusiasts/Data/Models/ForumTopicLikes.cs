using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarEnthusiasts.Data.Models
{
    public class ForumTopicLikes
    {
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;


        [Required]
        public int ForumTopicId { get; set; }

        [ForeignKey(nameof(ForumTopicId))]
        public ForumTopic Topic { get; set; } = null!;
    }
}
