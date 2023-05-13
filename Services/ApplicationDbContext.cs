using BookShopProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopProject.Services
{
  public class ApplicationDbContext : DbContext
  {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<StaffAccount> Staffs { get; set; }
    public DbSet<UserAccount> Users { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Storage> Storage { get; set; }
    public DbSet<ImportBill> ImportBills { get; set; }
    public DbSet<ImportBillInfo> ImportBillInfos { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<AddressList> AddressLists { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartInfo> CartInfos { get; set; }
    public DbSet<Order> Orders { get; set; }
  }
}
