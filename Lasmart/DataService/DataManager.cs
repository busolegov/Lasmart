namespace Lasmart.DataService
{
    public class DataManager
    {
        public IPointService PointService { get; set; }
        public ICommentService CommentService { get; set; }

        public DataManager(IPointService pointService, ICommentService commentService)
        {
            PointService = pointService;
            CommentService = commentService;
        }
    }
}
