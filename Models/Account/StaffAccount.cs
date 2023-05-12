using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class StaffAccount : Account
  {
    [Required]
    public string Name { get; set; }
    [Required]
    [MaxLength(12)]
    public string CitizenIden { get; set; }
    [Required]
    public DateTime ContractDate { get; set; }
    [Required]
    public DateTime EndOfContract { get; set; }
    [Required]
    public float Salary { get; set; }
  }
}
