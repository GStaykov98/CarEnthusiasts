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
        Task<bool> NewsExists(int id);
        Task<bool> ReviewExists(int id);
    }
}
