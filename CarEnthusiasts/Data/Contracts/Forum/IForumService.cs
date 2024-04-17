using CarEnthusiasts.Models;

namespace CarEnthusiasts.Data.Contracts.Forum
{
    public interface IForumService
    {
        Task<IEnumerable<ForumTopicViewModel>> GetAllTopics();
        Task<bool> TopicExist(int id);
        Task<ForumTopicDetailsViewModel> GetTopic(int id);
        Task AddTopic(ForumTopicFormViewModel model, string userId);
        Task<bool> UserIsCreator(int topicId, string userId);
        Task<ForumTopicFormViewModel> GetTopicForm(int id);
        Task EditTopic (ForumTopicFormViewModel model);
        Task<ForumTopicDeleteViewModel> GetDeleteForm(int id);
        Task DeleteTopic(int id);
        Task<bool> TopicIsLiked(int topicId, string userId);
        Task LikeTopic(int topicId, string userId);
        Task RemoveLike(int topicId, string userId);
        Task<bool> TopicIsFollowed(int topicId, string userId);
        Task FollowTopic(int topicId, string userId);
        Task UnfollowTopic(int topicId, string userId);
        Task<IEnumerable<ForumTopicViewModel>> GetFollowedTopics(string userId);
    }
}
