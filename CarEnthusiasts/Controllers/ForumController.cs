using CarEnthusiasts.Data;
using CarEnthusiasts.Data.Models.Enums;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;

namespace CarEnthusiasts.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext data;

        public ForumController(ApplicationDbContext context)
        {
            data = context;
        }

        public async Task<IActionResult> Home()
        {
            var topics = await data.ForumTopics
                .Include(f => f.ForumTopicsFollowers)
                .Select(x => new ForumTopicViewModel
                {
                    Id = x.Id,
                    Creator = x.Creator.UserName,
                    CreatedOn = x.CreatedOn,
                    Likes = x.LikeCounter, 
                    Title = x.Title,
                    TopicType = x.TopicType
                })
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            ForumTopicType[] forumTopics = { ForumTopicType.General, ForumTopicType.CommonProblems, ForumTopicType.TechnicalQuestions, ForumTopicType.CarMeets };

            ViewBag.ForumTypes = forumTopics;

            return View(topics);
        }

        public async Task<IActionResult> TopicDetails(int id)
        {
            if (id < 0 &&
                data.ForumTopics.Find(id) == null)
            {
                return BadRequest();
            }

            var currentTopic = await data.ForumTopics
                .Include(c => c.Comments)
                .ThenInclude(u => u.User)
                .Select(x => new ForumTopicDetailsViewModel
                {
                    Id = x.Id,
                    Creator = x.Creator,
                    CreatedOn = x.CreatedOn,
                    LikeCounter = x.LikeCounter,
                    Title = x.Title,
                    Comments = x.Comments,
                    FollowerCounter = x.ForumTopicsFollowers.Count,
                    ForumTopicsFollowers = x.ForumTopicsFollowers,
                    Text = x.Text
                })
                .FirstOrDefaultAsync(x => x.Id == id);

            if (currentTopic is null)
            {
                return BadRequest();
            }

            ViewBag.Title = currentTopic.Title;

            return View(currentTopic);

        }
    }
}
