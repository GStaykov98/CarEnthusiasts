using CarEnthusiasts.Data;
using CarEnthusiasts.Data.Contracts.Comments;
using CarEnthusiasts.Data.Contracts.Forum;
using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Data.Models.Enums;
using CarEnthusiasts.Data.Services.Comments;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using System.Security.Claims;

namespace CarEnthusiasts.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext data;
        private readonly IForumService forumService;
        private readonly ICommentService commentService;

        public ForumController(ApplicationDbContext context, IForumService _forumService, ICommentService _commentService)
        {
            data = context;
            forumService = _forumService;
            commentService = _commentService;
        }

        public async Task<IActionResult> Home()
        {
            var topics = await forumService.GetAllTopics();

            ForumTopicType[] forumTopics = { ForumTopicType.General,
                ForumTopicType.CommonProblems,
                ForumTopicType.TechnicalQuestions,
                ForumTopicType.CarMeets };

            ViewBag.ForumTypes = forumTopics;

            return View(topics);
        }

        public async Task<IActionResult> TopicDetails(int id)
        {
            if (!await forumService.TopicExist(id))
            {
                return BadRequest();
            }

            var currentTopic = await forumService.GetTopic(id);

            ViewBag.Title = currentTopic.Title;

            return View(currentTopic);

        }

        [HttpPost]
        public async Task<IActionResult> PostComment(string text, int topicId, string userId)
        {
            if (!ModelState.IsValid ||
                text is null ||
                !await forumService.TopicExist(topicId) ||
                GetUserId() != userId)
            {
                return BadRequest();
            }

            await commentService.PostForumComment(text, topicId, userId);

            return RedirectToAction(nameof(TopicDetails), new { id = topicId });
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

            var comment = await commentService.GetComment(model.Id);
            await commentService.EditComment(model.Id, model.Text);

            return RedirectToAction(nameof(TopicDetails), new { id = comment.ForumTopicId });
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
                ForumTopicId = comment.ForumTopicId
            };

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

            model.ForumTopicId = comment.ForumTopicId;

            await commentService.DeleteComment(model.Id);

            return RedirectToAction(nameof(TopicDetails), new { id = model.ForumTopicId});
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddTopic()
        {
            var topic = new ForumTopicFormViewModel();

            List<ForumTopicType> forumTopicTypes = Enum.GetValues(typeof(ForumTopicType))
                .Cast<ForumTopicType>()
                .ToList();

            topic.TopicTypes = forumTopicTypes;

            return View(topic);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddTopic(ForumTopicFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await forumService.AddTopic(model, GetUserId());
            return RedirectToAction(nameof(Home));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> EditTopic(int id)
        {
            if (!await forumService.TopicExist(id))
            {
                return BadRequest();
            }

            if (!await forumService.UserIsCreator(id, GetUserId()))
            {
                return BadRequest();
            }

            var topicModel = await forumService.GetTopicForm(id);

            return View(topicModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> EditTopic(ForumTopicFormViewModel model)
        {
            if (!await forumService.TopicExist(model.Id))
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await forumService.EditTopic(model);

            return RedirectToAction(nameof(TopicDetails), new { id = model.Id});
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> DeleteTopic(int id)
        {
            if (!await forumService.TopicExist(id))
            {
                return BadRequest();
            }

            if (!await forumService.UserIsCreator(id, GetUserId()))
            {
                return BadRequest();
            }

            var topicModel = await forumService.GetDeleteForm(id);

            return View(topicModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteTopicConfirmed(ForumTopicDeleteViewModel model)
        {
            if (!await forumService.TopicExist(model.Id))
            {
                return BadRequest();
            }

            if (!await forumService.UserIsCreator(model.Id, GetUserId()))
            {
                return BadRequest();
            }

            await forumService.DeleteTopic(model.Id);

            return RedirectToAction(nameof(Home));
        }

        [Authorize]
        public async Task<IActionResult> LikeTopic(int id)
        {
            if (!await forumService.TopicExist(id))
            {
                return BadRequest();
            }

            if (await forumService.TopicIsLiked(id, GetUserId()))
            {
                return BadRequest();
            }

            await forumService.LikeTopic(id, GetUserId());

            return RedirectToAction(nameof(TopicDetails), new { id });
        }

        [Authorize]
        public async Task<IActionResult> RemoveLike(int id)
        {
            if (!await forumService.TopicExist(id))
            {
                return BadRequest();
            }

            if (!await forumService.TopicIsLiked(id, GetUserId()))
            {
                return BadRequest();
            }

            await forumService.RemoveLike(id, GetUserId());

            return RedirectToAction(nameof(TopicDetails), new { id });
        }

        [Authorize]
        public async Task<IActionResult> FollowTopic(int id)
        {
            if (!await forumService.TopicExist(id))
            {
                return BadRequest();
            }

            if (await forumService.TopicIsFollowed(id, GetUserId()))
            {
                return BadRequest();
            }

            await forumService.FollowTopic(id, GetUserId());

            return RedirectToAction(nameof(TopicDetails), new { id });
        }

        [Authorize]
        public async Task<IActionResult> UnfollowTopic(int id)
        {
            if (!await forumService.TopicExist(id))
            {
                return BadRequest();
            }
            if (!await forumService.TopicIsFollowed(id, GetUserId()))
            {
                return BadRequest();
            }

            await forumService.UnfollowTopic(id, GetUserId());

            return RedirectToAction(nameof(TopicDetails), new { id });
        }

        [Authorize]
        public async Task<IActionResult> FollowedTopics()
        {
            var topics = await forumService.GetFollowedTopics(GetUserId());

            return View(topics);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
