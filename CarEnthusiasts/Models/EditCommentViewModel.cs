using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Models
{
    public class EditCommentViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } = string.Empty;
    }
}
