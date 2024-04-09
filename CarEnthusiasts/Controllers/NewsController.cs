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
               .FirstOrDefaultAsync(x => x.Id == id);

            if (reviews == null)
            {
                return BadRequest();

            }

            var currentReview = await data.Reviews.FindAsync(id);

            if (currentReview != null)
            {

                currentReview.ViewsCounter++;
            }

            await data.SaveChangesAsync();

            return View(reviews);
        }

        [HttpPost]
        public async Task<IActionResult> PostReviewComment(string text, int reviewId, string userId)
        {
            if (!ModelState.IsValid ||
                text is null ||
                !data.Reviews.Any(x => x.Id == reviewId) ||
                User.FindFirstValue(ClaimTypes.NameIdentifier) != userId)
            {
                return BadRequest();
            }

            var comment = new Comment
            {
                ReviewId = reviewId,
                UserId = userId,
                CreatedDate = DateTime.Now,
                Text = text
            };

            await data.Comments.AddAsync(comment);
            await data.SaveChangesAsync();

            return RedirectToAction(nameof(ReviewInformation), new { id = reviewId });
        }

        [HttpGet]
        public async Task<IActionResult> EditComment(int id)
        {
            var comment = await data.Comments.FindAsync(id);

            if (comment is null)
            {
                return BadRequest();
            }

            if (comment.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return BadRequest();
            }

            var editCommentForm = new EditCommentViewModel()
            {
                Id = comment.Id,
                Text = comment.Text
            };

            return View(editCommentForm);
        }

        [HttpPost]
        public async Task<IActionResult> EditComment(EditCommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var comment = await data.Comments.FindAsync(model.Id);

            if (comment is null)
            {
                return BadRequest();
            }

            if (comment.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return BadRequest();
            }

            comment.Text = model.Text;

            await data.SaveChangesAsync();

            if (comment.NewsId != null)
            {
                return RedirectToAction(nameof(NewsInformation), new { id = comment.NewsId });
            }
            else
            {
                return RedirectToAction(nameof(ReviewInformation), new { id = comment.ReviewId });
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await data.Comments.FindAsync(id);

            if (comment is null)
            {
                return BadRequest();
            }

            if (comment.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return Unauthorized();
            }

            var commentModel = new DeleteCommentViewModel()
            {
                Id = comment.Id,
                Text = comment.Text,
            };

            if (comment.NewsId != null)
            {
                commentModel.NewsId = comment.NewsId;
            }
            else
            {
                commentModel.ReviewId = comment.ReviewId;
            }

            return View(commentModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(DeleteCommentViewModel model)
        {
            var comment = await data.Comments.FindAsync(model.Id);

            if (!ModelState.IsValid ||
                comment is null ||
                comment.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return BadRequest();
            }

            model.ForumTopicId = comment.ForumTopicId;

            data.Comments.Remove(comment);
            await data.SaveChangesAsync();

            if (comment.NewsId != null)
            {
                return RedirectToAction(nameof(NewsInformation), new { id = comment.NewsId });
            }
            else
            {
                return RedirectToAction(nameof(ReviewInformation), new { id = comment.ReviewId });
            }
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
