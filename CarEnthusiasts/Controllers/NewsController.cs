﻿using CarEnthusiasts.Data.Contracts.Comments;
using CarEnthusiasts.Data.Contracts.News;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarEnthusiasts.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService newsService;
        private readonly ICommentService commentService;

        public NewsController(INewsService _news, ICommentService _commentService)
        {
            newsService = _news;
            commentService = _commentService;
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

            await commentService.PostNewsComment(text, newsId, userId);

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

            await commentService.PostReviewComment(text, reviewId, userId);

            return RedirectToAction(nameof(ReviewInformation), new { id = reviewId });
        }

        [HttpGet]
        public async Task<IActionResult> EditComment(int id)
        {
            if (!await commentService.CommentExists(id))
            {
                return BadRequest();
            }

            if (!await commentService.UserCommented(id, GetUserId()))
            {
                return BadRequest();
            }

            var editCommentForm = await commentService.GetCommentForm(id);

            return View(editCommentForm);
        }

        [HttpPost]
        public async Task<IActionResult> EditComment(EditCommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!await commentService.CommentExists(model.Id))
            {
                return BadRequest();
            }

            if (!await commentService.UserCommented(model.Id, GetUserId()))
            {
                return BadRequest();
            }

            await commentService.EditComment(model.Id, model.Text);

            var comment = await commentService.GetComment(model.Id);

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
            if (!await commentService.CommentExists(id))
            {
                return BadRequest();
            }

            if (!await commentService.UserCommented(id, GetUserId()))
            {
                return Unauthorized();
            }

            var comment = await commentService.GetComment(id);

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
                !await commentService.CommentExists(model.Id) ||
                !await commentService.UserCommented(model.Id, GetUserId()))
            {
                return BadRequest();
            }

            var comment = await commentService.GetComment(model.Id);
            await commentService.DeleteComment(model.Id);

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
