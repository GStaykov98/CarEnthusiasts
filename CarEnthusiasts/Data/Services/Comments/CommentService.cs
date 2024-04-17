using CarEnthusiasts.Data.Contracts.Comments;
using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Models;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Data.Services.Comments
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext data;

        public CommentService(ApplicationDbContext context)
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

        public async Task PostForumComment(string text, int topicId, string userId)
        {
            var comment = new Comment
            {
                ForumTopicId = topicId,
                UserId = userId,
                CreatedDate = DateTime.Now,
                Text = text
            };

            await data.Comments.AddAsync(comment);
            await data.SaveChangesAsync();
        }
    }
}
