using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class ContactUs
{
    [Required]
    public string FirstName{ get; set; }
    [Required]
    public string LastName{ get; set; }
    [EmailAddress]
    public string Email{ get; set; }
    [Url]
    public string SocialMedia{ get; set; }
}