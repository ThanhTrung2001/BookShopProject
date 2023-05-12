using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class UserAccount : Account
  {
    [Required]
    public string AddressList { get; set; }
    [Required]
    public string CartId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string CitizenIden { get; set; }
    [Required]
    public DateTime DOB { get; set; }
    [Required]
    public DateTime CreateDate { get; set; }

  }
}
