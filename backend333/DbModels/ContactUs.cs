using System.ComponentModel.DataAnnotations;

namespace backend333.DbModels;

public class ContactUs
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
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