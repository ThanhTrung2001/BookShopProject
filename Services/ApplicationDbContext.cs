using Microsoft.EntityFrameworkCore;

namespace BookShopProject.Services
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

  }
}
