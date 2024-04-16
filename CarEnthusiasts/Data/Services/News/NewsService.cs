using CarEnthusiasts.Data.Contracts.News;
using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CarEnthusiasts.Data.Services.News
{
    public class NewsService : INewsService
    {
        private readonly ApplicationDbContext data;

        public NewsService(ApplicationDbContext context)
        {
            data = context;
        }

        public async Task<bool> CommentExists(int id)
        {
            return await data.Comments.AnyAsync(c => c.Id == id);
        }

        public async Task<EditCommentViewModel> GetCommentForm(int id)
        {
            var comment = await data.Comments.FirstAsync(x => x.Id == id);

            var editCommentForm = new EditCommentViewModel()
            {
                Id = comment.Id,
                Text = comment.Text
            };

            return editCommentForm;
        }

        public async Task<IEnumerable<NewsViewModel>> GetAllNews()
        {
            var news = await data.News
                .OrderBy(d => d.CreatedOn)
                .Select(x => new NewsViewModel
                {
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Title = x.Title
                })
                .ToListAsync();

            return news;
        }

        public async Task<IEnumerable<ReviewViewModel>> GetAllReviews()
        {
            var reviews = await data.Reviews
               .OrderBy(x => x.CreatedOn)
               .Select(x => new ReviewViewModel
               {
                   Id = x.Id,
                   ImageUrl = x.ImageUrl,
                   Title = x.Title
               })
               .ToListAsync();

            return reviews;
        }

        public async Task<NewsAndReviewsViewModel> GetNewsAndReviews()
        {
            var news = await data.News
                .OrderBy(d => d.CreatedOn)
                .Select(x => new NewsViewModel
                {
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Title = x.Title
                })
                .ToListAsync();

            var reviews = await data.Reviews
                .OrderBy(x => x.CreatedOn)
                .Select(x => new ReviewViewModel
                {
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Title = x.Title
                })
                .ToListAsync();

            var model = new NewsAndReviewsViewModel
            {
                News = news,
                Reviews = reviews
            };

            return model;
        }

        public async Task<NewsInformationViewModel> GetNewsInformation(int id)
        {
            var news = await data.News
                .Include(c => c.Comments)
                .ThenInclude(u => u.User)
                .Select(x => new NewsInformationViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    ViewsCounter = x.ViewsCounter,
                    CreatedOn = x.CreatedOn,
                    Comments = x.Comments
                })
                .FirstAsync(x => x.Id == id);

            return news;
        }

        public async Task<ReviewInformationViewModel> GetReviewInformation(int id)
        {
            var review = await data.Reviews
               .Include(c => c.Comments)
               .ThenInclude(u => u.User)
               .Select(x => new ReviewInformationViewModel
               {
                   Id = x.Id,
                   Title = x.Title,
                   ImageUrl = x.ImageUrl,
                   Description = x.Description,
                   ViewsCounter = x.ViewsCounter,
                   CreatedOn = x.CreatedOn,
                   Comments = x.Comments
               })
               .FirstAsync(x => x.Id == id);

            return review;
        }

        public async Task IncreaseNewsViewsCounter(int id)
        {
            var currentNews = await data.News.FindAsync(id);

            if (currentNews != null)
            {

                currentNews.ViewsCounter++;
            }

            await data.SaveChangesAsync();
        }

        public async Task IncreaseReviewViewsCounter(int id)
        {
            var currentReview = await data.Reviews.FindAsync(id);

            if (currentReview != null)
            {
                currentReview.ViewsCounter++;
            }

            await data.SaveChangesAsync();
        }

        public async Task<bool> NewsExists(int id)
        {
            return await data.News.AnyAsync(x => x.Id == id);
        }

        public async Task PostNewsComment(string text, int newsId, string userId)
        {
            var comment = new Comment
            {
                NewsId = newsId,
                UserId = userId,
                CreatedDate = DateTime.Now,
                Text = text
            };

            await data.Comments.AddAsync(comment);
            await data.SaveChangesAsync();
        }

        public async Task PostReviewComment(string text, int reviewId, string userId)
        {
            var comment = new Comment
            {
                ReviewId = reviewId,
                UserId = userId,
                CreatedDate = DateTime.Now,
                Text = text
            };

            await data.Comments.AddAsync(comment);
            await data.SaveChangesAsync();
        }

        public async Task<bool> ReviewExists(int id)
        {
            return await data.Reviews.AnyAsync(x => x.Id == id);
        }

        public async Task<bool> UserCommented(int id, string userId)
        {
            var comment = await data.Comments.FirstAsync(x => x.Id == id);

            return comment.UserId == userId;
        }

        public async Task EditComment(int id, string text)
        {
            var comment = await data.Comments.FirstAsync(x => x.Id == id);

            comment.Text = text;

            await data.SaveChangesAsync();
        }

        public async Task<Comment> GetComment(int id)
        {
            return await data.Comments.FirstAsync(x => x.Id == id);
        }

        public async Task DeleteComment(int id)
        {
            var comment = await data.Comments.FirstAsync(x => x.Id == id);

            data.Comments.Remove(comment);
            await data.SaveChangesAsync();
        }
    }
}
