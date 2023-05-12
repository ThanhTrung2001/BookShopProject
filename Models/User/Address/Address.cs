using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class Address
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string DetailAddress { get; set; }
    [Required]
    public string Phone { get; set; }
  }
}
