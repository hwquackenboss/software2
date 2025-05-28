using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Playlist{

  [Key]
  public int PlaylistId {get; set;}
  
  public required string Name {get; set;}

  public ICollection<Track> Tracks { get; set; } = new List<Track>();

}