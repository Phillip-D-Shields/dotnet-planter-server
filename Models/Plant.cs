using System
using System.ComponentModel.DataAnnotations;

namespace Planter.Models
{
  public class Plant
  {
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    [Required]
    public string CareInstructions { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime UpdatedAt { get; set; }
  }
}