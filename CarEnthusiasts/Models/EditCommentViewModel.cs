using System.ComponentModel.DataAnnotations;

namespace CarEnthusiasts.Models
{
    public class EditCommentViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } = string.Empty;
    }
}
