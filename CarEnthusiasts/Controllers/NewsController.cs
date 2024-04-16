using CarEnthusiasts.Data.Contracts.News;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarEnthusiasts.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService newsService;

        public NewsController(INewsService _news)
        {
            newsService = _news;
        }

        public async Task<IActionResult> Index()
        {
            var model = await newsService.GetNewsAndReviews();

            return View(model);
        }

        public async Task<IActionResult> AllNews()
        {
            var news = await newsService.GetAllNews();

            return View(news);
        }

        public async Task<IActionResult> AllReviews()
        {
            var reviews = await newsService.GetAllReviews();

            return View(reviews);
        }

        public async Task<IActionResult> NewsInformation(int id)
        {
            if (!await newsService.NewsExists(id))
            {
                return BadRequest();
            }

            var news = await newsService.GetNewsInformation(id);
            await newsService.IncreaseNewsViewsCounter(news.Id);

            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult> PostNewsComment(string text, int newsId, string userId)
        {
            if (!ModelState.IsValid ||
                text is null ||
                !await newsService.NewsExists(newsId) ||
                User.FindFirstValue(ClaimTypes.NameIdentifier) != userId)
            {
                return BadRequest();
            }

            await newsService.PostNewsComment(text, newsId, userId);

            return RedirectToAction(nameof(NewsInformation), new { id = newsId});
        }

        public async Task<IActionResult> ReviewInformation(int id)
        {
            if (!await newsService.ReviewExists(id))
            {
                return BadRequest();
            }

            var review = await newsService.GetReviewInformation(id);
            await newsService.IncreaseReviewViewsCounter(review.Id);

            return View(review);
        }

        [HttpPost]
        public async Task<IActionResult> PostReviewComment(string text, int reviewId, string userId)
        {
            if (!ModelState.IsValid ||
                text is null ||
                !await newsService.ReviewExists(reviewId) ||
                User.FindFirstValue(ClaimTypes.NameIdentifier) != userId)
            {
                return BadRequest();
            }

            await newsService.PostReviewComment(text, reviewId, userId);

            return RedirectToAction(nameof(ReviewInformation), new { id = reviewId });
        }

        [HttpGet]
        public async Task<IActionResult> EditComment(int id)
        {
            if (!await newsService.CommentExists(id))
            {
                return BadRequest();
            }

            if (!await newsService.UserCommented(id, GetUserId()))
            {
                return BadRequest();
            }

            var editCommentForm = await newsService.GetCommentForm(id);

            return View(editCommentForm);
        }

        [HttpPost]
        public async Task<IActionResult> EditComment(EditCommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!await newsService.CommentExists(model.Id))
            {
                return BadRequest();
            }

            if (!await newsService.UserCommented(model.Id, GetUserId()))
            {
                return BadRequest();
            }

            await newsService.EditComment(model.Id, model.Text);

            var comment = await newsService.GetComment(model.Id);

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
            if (!await newsService.CommentExists(id))
            {
                return BadRequest();
            }

            if (!await newsService.UserCommented(id, GetUserId()))
            {
                return Unauthorized();
            }

            var comment = await newsService.GetComment(id);

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
            if (!ModelState.IsValid ||
                !await newsService.CommentExists(model.Id) ||
                !await newsService.UserCommented(model.Id, GetUserId()))
            {
                return BadRequest();
            }

            var comment = await newsService.GetComment(model.Id);
            await newsService.DeleteComment(model.Id);

            if (comment.NewsId != null)
            {
                return RedirectToAction(nameof(NewsInformation), new { id = comment.NewsId });
            }
            else
            {
                return RedirectToAction(nameof(ReviewInformation), new { id = comment.ReviewId });
            }
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
