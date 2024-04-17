using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Models;

namespace CarEnthusiasts.Data.Contracts.Comments
{
    public interface ICommentService
    {
        Task PostNewsComment(string text, int newsId, string userId);
        Task PostReviewComment(string text, int reviewId, string userId);
        Task PostForumComment(string text, int topicId, string userId);
        Task<bool> CommentExists(int id);
        Task<bool> UserCommented(int id, string userId);
        Task<EditCommentViewModel> GetCommentForm(int id);
        Task EditComment(int id, string text);
        Task<Comment> GetComment(int id);
        Task DeleteComment(int id);
    }
}
