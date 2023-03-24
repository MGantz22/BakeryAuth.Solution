using System.ComponentModel.DataAnnotations;

namespace BakeAuth.ViewModels
{
  public class AddTreatViewModel
  {
    [Required]
    [Display(Name = "Name")]
    public string name { get; set; }
    [Display(Name = "Description")]
    public string description { get; set; }
  }
}