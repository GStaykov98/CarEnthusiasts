using CarEnthusiasts.Data;
using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

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

        public async Task<IActionResult> NewsInformation(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }

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
                .FirstOrDefaultAsync(x => x.Id == id);

            if (news == null)
            {
                return BadRequest();
            }

            var currentNews = await data.News.FindAsync(id);

            if (currentNews != null)
            {

                currentNews.ViewsCounter++;
            }

            await data.SaveChangesAsync();

            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult> PostNewsComment(string text, int newsId, string userId)
        {
            if (!ModelState.IsValid ||
                text is null ||
                !data.News.Any(x => x.Id == newsId) ||
                User.FindFirstValue(ClaimTypes.NameIdentifier) != userId)
            {
                return BadRequest();
            }

            var comment = new Comment
            {
                NewsId = newsId,
                UserId = userId,
                CreatedDate = DateTime.Now,
                Text = text
            };

            await data.Comments.AddAsync(comment);
            await data.SaveChangesAsync();

            return RedirectToAction(nameof(NewsInformation), new { id = newsId});
        }

        public async Task<IActionResult> ReviewInformation(int id)
        {
            var reviews = await data.Reviews
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
               .FirstOrDefaultAsync(x => x.Id == id);

            if (reviews == null)
            {
                return BadRequest();

            }

            data.Reviews.Find(id).ViewsCounter++;
            await data.SaveChangesAsync();

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
