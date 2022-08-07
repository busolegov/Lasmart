using Lasmart.Models;

namespace Lasmart.DataService
{
    public interface ICommentService
    {
        Task<List<Comment>> GetCommentsByIdAsync(Guid id);
    }
}
