using Lasmart.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lasmart.Models
{
    public class Point : FigureBase
    {
        [Required]
        public float Radius { get; set; }
    }
}
