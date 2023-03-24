using System.ComponentModel.DataAnnotations;

namespace BakeAuth.ViewModels
{
  public class AddFlavorViewModel
  {
    [Required]
    [Display(Name = "Name")]
    public string name { get; set; }
  }
}