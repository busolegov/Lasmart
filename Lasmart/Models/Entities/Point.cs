using Lasmart.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Lasmart.Models
{
    public class Point : FigureBase
    {
        [Required]
        public float Radius { get; set; }
    }
}
