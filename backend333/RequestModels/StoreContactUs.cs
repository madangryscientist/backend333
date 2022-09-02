using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class StoreContactUs
{
    public int TrackId { get; set; }
    [Required]
    public string Name { get; set; }
   [Required]
   [EmailAddress]
    public string Email { get; set; }
}