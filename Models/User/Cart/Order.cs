using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class Order
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public float Cost { get; set; }
    [Required]
    public Address Address { get; set; }
    [Required]
    public DateTime CreateDate { get; set; }
    [Required]
    public PurchaseType WayToPay { get; set; }
    [Required]
    public bool IsPurchase { get; set; }
    [Required]
    public bool IsCancel { get; set; }
  }

  public enum PurchaseType
  {
    OnlineBanking,
    PayWhenReceive
  }
}
