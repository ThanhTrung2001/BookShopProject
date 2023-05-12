using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class Author
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public string AuthorName { get; set; }
  }
}
