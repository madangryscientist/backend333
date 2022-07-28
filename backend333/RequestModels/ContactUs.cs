using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace backend333.RequestModels;

public class ContactUs
{
    [Key] public int Id { get; set; }
    [Required]
    public string FirstName{ get; set; }
    [Required]
    public string LastName{ get; set; }
    [EmailAddress]
    public string Email{ get; set; }
    
    public string Instagram{ get; set; }
    
    public string Twitter{ get; set; }
    
    public string SoundCloud{ get; set; }
    
    public bool artist { get; set; }
    
    public bool producer { get; set; }

    
    
    
}