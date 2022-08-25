using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class Store
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    public string Heading { get; set; }
    public string MainText { get; set; }
}