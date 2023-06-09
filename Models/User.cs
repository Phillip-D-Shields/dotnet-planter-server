using System
using System.ComponentModel.DataAnnotations;

namespace Planter.Models
{
  public class User
  {
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; }
  }
}