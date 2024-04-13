using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace CarEnthusiasts.Models
{
    public class ForumTopicDetailsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Text { get; set; } = string.Empty;

        public IdentityUser Creator { get; set; } = null!;

        public int LikeCounter { get; set; } = 0;

        public int FollowerCounter { get; set; } = 0;

        public DateTime CreatedOn { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<ForumTopicFollower> ForumTopicsFollowers { get; set; } = new List<ForumTopicFollower>();

        public ICollection<ForumTopicLikes> ForumTopicsLikes { get; set; } = new List<ForumTopicLikes>();
    }
}
