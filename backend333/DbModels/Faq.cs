using System.ComponentModel.DataAnnotations;

namespace backend333.DbModels;

public class Faq
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    public string Question { get; set; }
    public string Answer { get; set; }
    public bool Active { get; set; }
 
    public string Email{ get; set; }
    public string Name{ get; set; }
}


  