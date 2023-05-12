using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class Type
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public string TyppeName { get; set; }
  }
}
