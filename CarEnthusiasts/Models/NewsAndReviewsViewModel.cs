namespace CarEnthusiasts.Models
{
    public class NewsAndReviewsViewModel
    {
        public List<NewsViewModel> News { get; set; } = new List<NewsViewModel>();

        public List<ReviewViewModel> Reviews { get; set; } = new List<ReviewViewModel>();
    }
}
