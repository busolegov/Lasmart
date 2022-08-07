using Lasmart.Models;

namespace Lasmart.DataService
{
    public static class Databaseinitializer
    {
        public static void Init(this ApplicationDbContext context)
        {
            Point point1 = new Point
            {
                Id= Guid.NewGuid(),
                CoordinateX = 50,
                CoordinateY = 20,
                Radius = 15,
                Color = "Black",
            };

            Point point2 = new Point
            {
                Id= Guid.NewGuid(),
                CoordinateX = 100,
                CoordinateY = 200,
                Radius = 30,
                Color = "Blue",
            };

            Point point3 = new Point
            {
                Id= Guid.NewGuid(),
                CoordinateX = 100,
                CoordinateY = 400,
                Radius = 50,
                Color = "Red",
            };

            Comment comment1 = new Comment
            {
                Id = Guid.NewGuid(),
                Text = "This is 1 comment...",
                BackgroundColor = "Grey",
                PointId = point1.Id
            };

            Comment comment2 = new Comment
            {
                Id = Guid.NewGuid(),
                Text = "This is 2 comment...",
                BackgroundColor = "White",
                PointId = point1.Id
            };

            Comment comment3 = new Comment
            {
                Id = Guid.NewGuid(),
                Text = "This is 3 comment...",
                BackgroundColor = "Yellow",
                PointId = point2.Id
            };

            Comment comment4 = new Comment
            {
                Id = Guid.NewGuid(),
                Text = "This is 4 comment...",
                BackgroundColor = "Green",
                PointId = point2.Id
            };

            Comment comment5 = new Comment
            {
                Id = Guid.NewGuid(),
                Text = "This is 5 comment...",
                BackgroundColor = "Grey",
                PointId = point2.Id
            };

            Comment comment6 = new Comment
            {
                Id = Guid.NewGuid(),
                Text = "This is 6 comment...",
                BackgroundColor = "Blue",
                PointId = point2.Id
            };

            Comment comment7 = new Comment
            {
                Id = Guid.NewGuid(),
                Text = "This is 7 comment...",
                BackgroundColor = "Blue",
                PointId = point3.Id
            };

            Comment comment8 = new Comment
            {
                Id = Guid.NewGuid(),
                Text = "This is 8 comment...",
                BackgroundColor = "Red",
                PointId = point3.Id
            };

            context.AddRange(point1, point2, comment1, comment2, comment3, comment4, comment5, comment6);
            context.SaveChanges();
        }
    }
}
