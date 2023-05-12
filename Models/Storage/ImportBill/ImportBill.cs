using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class ImportBill
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public int StaffId { get; set; }
    [Required]
    public DateTime CreateDate { get; set; }
    [Required]
    public float Cost { get; set; }
    [Required]
    public float ReducePercent { get; set; }
    [Required]
    public float Total { get; set; }
  }
}
