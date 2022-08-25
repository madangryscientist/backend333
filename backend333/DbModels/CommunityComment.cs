using System.ComponentModel.DataAnnotations;

namespace backend333.DbModels;

public class CommunityComment
{
    [Key] public int Id { get; set; }
    public string Comment { get; set; } = "";
    public int CommunityId { get; set; }
    
}