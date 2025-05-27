using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


public class MediaType{

  [Key]
  public int MediaTypeId {get; set;}
  
  public string? Name {get; set;}
  
  
}