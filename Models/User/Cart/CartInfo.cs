using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class CartInfo
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public int CartId { get; set; }
    [Required]
    public int BookId { get; set; }
    [Required]
    public int Number { get; set; }
    [Required]
    public float Price { get; set; }
    [Required]
    public bool IsSelected { get; set; }

  }
}
