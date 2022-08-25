using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class Faq
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    public string Question { get; set; }
    public string Answer { get; set; }
    public bool Active { get; set; }
}

public class FaqActive
{
    public Guid Id { get; set; }
}
  