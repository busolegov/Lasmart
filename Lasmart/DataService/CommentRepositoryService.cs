using Lasmart.Models;

namespace Lasmart.DataService
{
    public class CommentRepositoryService : ICommentService
    {
        private readonly ApplicationDbContext _context;
        public CommentRepositoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetCommentsByIdAsync(Guid id)
        {
            var point = await _context.Points.FindAsync(id);
            var comments = point.Comments.ToList();
            return comments;
        }
    }
}
