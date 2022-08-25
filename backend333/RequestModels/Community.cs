using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class Community
{
  [Key] public Guid Id { get; set; } = Guid.NewGuid();
    public string Question { get; set; }
    public bool Active { get; set; }
    public int Count { get; set; }
    public List<CommunityComment> Comment { get; set; } = new List<CommunityComment>();
}

public class CommunityIdentity
{
     public Guid Id { get; set; }
}