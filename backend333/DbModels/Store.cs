using System.ComponentModel.DataAnnotations;

namespace backend333.DbModels;

public class Store
{
    [Key] public int Id { get; set; }
    public string Heading { get; set; }
    public string MainText { get; set; }
}