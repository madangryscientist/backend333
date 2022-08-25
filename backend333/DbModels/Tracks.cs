using System.ComponentModel.DataAnnotations;

namespace backend333.DbModels;

public class Tracks
{
    [Key] public int Id { get; set; } 
    public string TrackName { get; set; }
    public int Bpm { get; set; }
    public string Tune { get; set; }
    public string SongUrl { get; set; }
    
}