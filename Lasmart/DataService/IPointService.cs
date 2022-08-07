using Lasmart.Models;

namespace Lasmart.DataService
{
    public interface IPointService
    {
        IQueryable<Point> GetPoints();
        Task RemovePointAsync(Guid id);
    }
}
