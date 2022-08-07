using Lasmart.Models;

namespace Lasmart.DataService
{
    public class PointRepositoryService : IPointService
    {
        private readonly ApplicationDbContext _context;
        public PointRepositoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Point> GetPoints()
        {
            return _context.Points;
        }

        public async Task RemovePointAsync(Guid id)
        {
            var point = await _context.Points.FindAsync(id);
            if (point != null) 
            {
                _context.Points.Remove(point);
                await _context.SaveChangesAsync();
            }
        }
    }
}
