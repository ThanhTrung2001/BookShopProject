using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class ImportBillInfo
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public int ImpoortBillId { get; set; }
    [Required]
    public int BookId { get; set; }
    [Required]
    public int Number { get; set; }
    [Required]
    public float Price { get; set; }
  }
}
