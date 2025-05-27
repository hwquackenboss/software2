using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SQLitePCL;


public class Genre{

  [Key]
  public int GenreId {get; set;}
  
  public string? Name {get; set;}
  
  public ICollection<Track> Tracks {get; set;} = new List<Track>();

}