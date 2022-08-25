using System.ComponentModel.DataAnnotations;

namespace backend333.DbModels;

public class Community
{
    [Key] public int Id { get; set; }
    public string Question { get; set; }
    public bool Active { get; set; }
    public int Count { get; set; }
    public List<CommunityComment> Comment { get; set; } = new List<CommunityComment>();
}

public class CommunityIdentity
{
     public int Id { get; set; }
}