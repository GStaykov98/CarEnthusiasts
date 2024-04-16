using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Models;

namespace CarEnthusiasts.Data.Contracts.News
{
    public interface INewsService
    {
        Task<NewsAndReviewsViewModel> GetNewsAndReviews();
        Task<IEnumerable<NewsViewModel>> GetAllNews();
        Task<IEnumerable<ReviewViewModel>> GetAllReviews();
        Task<NewsInformationViewModel> GetNewsInformation(int id);
        Task<ReviewInformationViewModel> GetReviewInformation(int id);
        Task IncreaseNewsViewsCounter(int id);
        Task IncreaseReviewViewsCounter(int id);
        Task PostNewsComment(string text, int newsId, string userId);
        Task PostReviewComment(string text, int reviewId, string userId);
        Task<bool> NewsExists(int id);
        Task<bool> ReviewExists(int id);
        Task<bool> CommentExists(int id);
        Task<bool> UserCommented(int id, string userId);
        Task<EditCommentViewModel> GetCommentForm(int id);
        Task EditComment(int id, string text);
        Task<Comment> GetComment(int id);
        Task DeleteComment(int id);
    }
}
