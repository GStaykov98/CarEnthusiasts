using CarEnthusiasts.Data.Models.Enums;

namespace CarEnthusiasts.Models
{
    public class ForumTopicViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Creator { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }

        public int Likes { get; set; }

        public ForumTopicType TopicType { get; set; }
    }
}
