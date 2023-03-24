using System.ComponentModel.DataAnnotations;

namespace BakeAuth.Models 
{
  public class Flavor {
    [Key]
    public int flavor_id {get; set;}
    public string user_id {get; set;}
    public string name {get; set;}
  }
}