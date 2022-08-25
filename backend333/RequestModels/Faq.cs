using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class FaqRequestModels
{
    public string Question { get; set; }
    public string Email{ get; set; }
    public string Name{ get; set; }
}

public class FaqActive
{
    public Guid Id { get; set; }
}
  