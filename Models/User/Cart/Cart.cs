using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class Cart
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public float Cost { get; set; }

    public string SaleCode { get; set; }
    [Required]
    public float TotalCost { get; set; }
  }
}
