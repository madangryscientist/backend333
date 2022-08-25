using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class Tracks
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    public string TrackName { get; set; }
    public int Bpm { get; set; }
    public string Tune { get; set; }
    public string SongUrl { get; set; }
    
}