using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class Faq
{
    [Key] public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public bool Active { get; set; }
}

public class FaqActive
{
    public int Id { get; set; }
}
  