using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class Book
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string ImageLink { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string AuthorId { get; set; }
    [Required]
    public List<Type> Types { get; set; }
    [Required]
    public DateTime PublishDay { get; set; }
    [Required]
    public float Price { get; set; }
    [Required]
    public int NumberLeft { get; set; }
    [Required]
    public bool IsSale { get; set; }

    public float SalePercent { get; set; }

  }
}
