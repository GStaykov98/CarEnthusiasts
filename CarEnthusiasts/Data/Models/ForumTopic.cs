using CarEnthusiasts.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarEnthusiasts.Data.Models
{
    public class ForumTopic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Text { get; set; } = string.Empty;

        [Required]
        public string CreatorId { get; set; } = string.Empty;

        [ForeignKey(nameof(CreatorId))]
        public IdentityUser Creator { get; set; } = null!;

        public int LikeCounter { get; set; } = 0;

        public int FollowerCounter { get; set; } = 0;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public ForumTopicType TopicType { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<ForumTopicFollower> ForumTopicsFollowers { get; set; } = new List<ForumTopicFollower>();
    }
}
