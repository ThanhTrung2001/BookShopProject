﻿using System.ComponentModel.DataAnnotations;

namespace BookShopProject.Models
{
  public class BookType
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public string TypeName { get; set; }
  }
}
