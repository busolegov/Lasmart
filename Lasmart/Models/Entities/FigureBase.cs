using System.ComponentModel.DataAnnotations;

namespace Lasmart.Models.Entities
{
    public class FigureBase
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public float CoordinateX { get; set; }

        [Required]
        public float CoordinateY { get; set; }

        [Required]
        public string Color { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
