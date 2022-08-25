using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class WeddingContactUs
{
  [Key] public Guid Id { get; set; } = Guid.NewGuid();
  [Required] public string Name { get; set; }
  public string Others { get; set; }
  [Required] public int children { get; set; }
  [Required] public int Amount { get; set; }
}