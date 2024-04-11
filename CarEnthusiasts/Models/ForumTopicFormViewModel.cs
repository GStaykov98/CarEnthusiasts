using CarEnthusiasts.Data.Models.Enums;
using CarEnthusiasts.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Models
{
    public class ForumTopicFormViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Text { get; set; } = string.Empty;

        [Required]
        public ForumTopicType TopicType { get; set; }

        public List<ForumTopicType> TopicTypes { get; set; } = new List<ForumTopicType>();
    }
}
