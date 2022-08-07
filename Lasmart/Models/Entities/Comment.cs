using System.ComponentModel.DataAnnotations;

namespace Lasmart.Models
{
    public class Comment
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string BackgroundColor { get; set; }
        public Point Point { get; set; }
        public Guid PointId { get; set; }
    }
}
