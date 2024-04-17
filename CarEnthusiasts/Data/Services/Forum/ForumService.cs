using CarEnthusiasts.Data.Contracts.Forum;
using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Models;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Data.Services.Forum
{
    public class ForumService : IForumService
    {
        private readonly ApplicationDbContext data;

        public ForumService(ApplicationDbContext context)
        {
            data = context;
        }

        public async Task AddTopic(ForumTopicFormViewModel model, string userId)
        {
            var topic = new ForumTopic()
            {
                Title = model.Title,
                CreatedOn = DateTime.Now,
                CreatorId = userId,
                Text = model.Text,
                TopicType = model.TopicType
            };

            await data.ForumTopics.AddAsync(topic);
            await data.SaveChangesAsync();
        }

        public async Task DeleteTopic(int id)
        {
            var topic = await data.ForumTopics
                .Include(x => x.ForumTopicsFollowers)
                .Include(c => c.Comments)
                .FirstAsync(x => x.Id == id);

            var topicFollowers = topic.ForumTopicsFollowers.FirstOrDefault(x => x.ForumTopicId == topic.Id);
            var comments = topic.Comments.FirstOrDefault(x => x.ForumTopicId == topic.Id);

            if (comments is not null)
            {
                data.Comments.Remove(comments);
            }

            if (topicFollowers is not null)
            {
                data.ForumTopicsFollowers.Remove(topicFollowers);
            }

            data.ForumTopics.Remove(topic);
            await data.SaveChangesAsync();
        }

        public async Task EditTopic(ForumTopicFormViewModel model)
        {
            var topic = await data.ForumTopics.FirstAsync(x => x.Id == model.Id);

            topic.Title = model.Title;
            topic.Text = model.Text;

            await data.SaveChangesAsync();
        }

        public async Task FollowTopic(int topicId, string userId)
        {
            var topic = await data.ForumTopics.FirstAsync(x => x.Id == topicId);

            var topicFollower = new ForumTopicFollower
            {
                ForumTopicId = topicId,
                FollowerId = userId
            };

            topic.FollowerCounter++;
            await data.ForumTopicsFollowers.AddAsync(topicFollower);
            await data.SaveChangesAsync();
        }

        public async Task<IEnumerable<ForumTopicViewModel>> GetAllTopics()
        {
            var topics = await data.ForumTopics
                .Include(f => f.ForumTopicsFollowers)
                .Select(x => new ForumTopicViewModel
                {
                    Id = x.Id,
                    Creator = x.Creator.UserName,
                    CreatedOn = x.CreatedOn,
                    Title = x.Title,
                    TopicType = x.TopicType
                })
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            return topics;
        }

        public async Task<ForumTopicDeleteViewModel> GetDeleteForm(int id)
        {
            var topic = await data.ForumTopics.FirstAsync(x => x.Id == id);

            var form = new ForumTopicDeleteViewModel
            {
                Id = topic.Id,
                Title = topic.Title
            };

            return form;
        }

        public async Task<IEnumerable<ForumTopicViewModel>> GetFollowedTopics(string userId)
        {
            var topics = await data.ForumTopics
                .Where(x => x.ForumTopicsFollowers.Any(z => z.FollowerId == userId))
                .Select(x => new ForumTopicViewModel
                {
                    Id = x.Id,
                    Creator = x.Creator.UserName,
                    CreatedOn = x.CreatedOn,
                    Title = x.Title
                })
                .ToListAsync();

            return topics;
        }

        public async Task<ForumTopicDetailsViewModel> GetTopic(int id)
        {
            var currentTopic = await data.ForumTopics
                .Include(f => f.ForumTopicsFollowers)
                .Include(l => l.ForumTopicsLikes)
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
                    ForumTopicsLikes = x.ForumTopicsLikes,
                    Text = x.Text
                })
                .FirstAsync(x => x.Id == id);

            return currentTopic;
        }

        public async Task<ForumTopicFormViewModel> GetTopicForm(int id)
        {
            var topic = await data.ForumTopics.FirstAsync(x => x.Id == id);

            var form = new ForumTopicFormViewModel
            {
                Id = topic.Id,
                Text = topic.Text,
                Title = topic.Title,
                TopicType = topic.TopicType
            };

            return form;
        }

        public async Task LikeTopic(int topicId, string userId)
        {
            var topic = await data.ForumTopics.FirstAsync(x => x.Id == topicId);

            var topicLikeInteractor = new ForumTopicLikes
            {
                UserId = userId,
                ForumTopicId = topicId
            };

            topic.LikeCounter++;
            await data.ForumTopicsLikes.AddAsync(topicLikeInteractor);
            await data.SaveChangesAsync();
        }

        public async Task RemoveLike(int topicId, string userId)
        {
            var topic = await data.ForumTopics.FirstAsync(x => x.Id == topicId);

            var topicLikeInteractor = await data.ForumTopicsLikes
                .FirstAsync(x => x.ForumTopicId == topicId && x.UserId == userId);

            topic.LikeCounter--;
            data.ForumTopicsLikes.Remove(topicLikeInteractor);
            await data.SaveChangesAsync();
        }

        public async Task<bool> TopicExist(int id)
        {
            return await data.ForumTopics.AnyAsync(x => x.Id == id);
        }

        public async Task<bool> TopicIsFollowed(int topicId, string userId)
        {
            var topic = await data.ForumTopics
                .Include(f => f.ForumTopicsFollowers)
                .FirstAsync(x => x.Id == topicId);

            return topic.ForumTopicsFollowers.Any(x => x.FollowerId == userId);
        }

        public async Task<bool> TopicIsLiked(int topicId, string userId)
        {
            var topic = await data.ForumTopics
                .Include(l => l.ForumTopicsLikes)
                .FirstAsync(x => x.Id == topicId);

            return topic.ForumTopicsLikes.Any(x => x.UserId == userId);
        }

        public async Task UnfollowTopic(int topicId, string userId)
        {
            var topic = await data.ForumTopics.FirstAsync(x => x.Id == topicId);

            var topicFollower = await data.ForumTopicsFollowers
                .FirstAsync(x => x.ForumTopicId == topicId && x.FollowerId == userId);

            topic.FollowerCounter--;
            data.ForumTopicsFollowers.Remove(topicFollower);
            await data.SaveChangesAsync();
        }

        public async Task<bool> UserIsCreator(int topicId, string userId)
        {
            var topic = await data.ForumTopics
                .Include(u => u.Creator)
                .FirstAsync(x => x.Id == topicId);

            return topic.Creator.Id == userId;
        }
    }
}
