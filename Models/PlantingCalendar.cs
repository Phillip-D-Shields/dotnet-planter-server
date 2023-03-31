using System
using System.ComponentModel.DataAnnotations;

namespace Planter.Models
{
  public class PlantingCalendar
  {
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid UserId { get; set; }

    [Required]
    public string? Description { get; set; }
    [Required]
    public List<Plant> Plants { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime UpdatedAt { get; set; }
  }
}