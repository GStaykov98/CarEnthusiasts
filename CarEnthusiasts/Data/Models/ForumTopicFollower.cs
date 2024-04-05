using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarEnthusiasts.Data.Models
{
    public class ForumTopicFollower
    {
        [Required]
        public string FollowerId { get; set; } = string.Empty;

        [ForeignKey(nameof(FollowerId))]
        public IdentityUser Follower { get; set; } = null!;


        [Required]
        public int ForumTopicId { get; set; }

        [ForeignKey(nameof(ForumTopicId))]
        public ForumTopic Topic { get; set; } = null!;
    }
}
