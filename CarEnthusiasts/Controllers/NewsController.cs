using CarEnthusiasts.Data;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CarEnthusiasts.Controllers
{
    public class NewsController : Controller
    {
        private readonly ApplicationDbContext data;

        public NewsController(ApplicationDbContext context)
        {
            data = context;
        }

        public IActionResult Index()
        {
            var news = GetNews();

            var reviews = GetReviews();

            var model = new NewsAndReviewsViewModel
            {
                News = news,
                Reviews = reviews
            };

            return View(model);
        }

        public async Task<IActionResult> AllNews()
        {
            var news = await GetNewsAsync();

            return View(news);
        }

        public async Task<IActionResult> AllReviews()
        {
            var reviews = await GetReviewsAsync();

            return View(reviews);
        }

        private List<NewsViewModel> GetNews()
        {
            var news = data.News
                .OrderBy(d => d.CreatedOn)
                .Select(x => new NewsViewModel
                {
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Title = x.Title
                })
                .ToList();

            return news;
        }

        private List<ReviewViewModel> GetReviews()
        {
            var reviews = data.Reviews
                .OrderBy(d => d.CreatedOn)
                .Select(x => new ReviewViewModel
                {
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Title = x.Title
                })
                .ToList();

            return reviews;
        }
        private async Task<List<NewsViewModel>> GetNewsAsync()
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

        private async Task<List<ReviewViewModel>> GetReviewsAsync()
        {
            var reviews = await data.Reviews
                .OrderBy(d => d.CreatedOn)
                .Select(x => new ReviewViewModel
                {
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Title = x.Title
                })
                .ToListAsync();

            return reviews;
        }
    }
}
