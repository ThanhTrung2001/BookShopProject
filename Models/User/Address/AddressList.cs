using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class AddressList
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public List<Address> Addresses { get; set; }


  }
}
