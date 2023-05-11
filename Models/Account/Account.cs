using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public abstract class Account
  {
    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(8)]
    public string Password { get; set; }
    [Required]
    public int Permission { get; set; }
  }
}
