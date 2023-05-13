using BookShopProject.Services;
using BookShopProject.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace BookShopProject.Repository
{
  public class GenericRepository<T> : IGenericRepository<T> where T : class
  {
    //Call ApplicationContextDb
    private ApplicationDbContext? db = null;
    //DBSet for each table type
    private DbSet<T> table;
    public GenericRepository(IUnitOfWork<ApplicationDbContext> unitOfWork) : this(unitOfWork.Context) { }

    public GenericRepository(ApplicationDbContext dbContext)
    {
      this.db = dbContext;
      table = db.Set<T>();
    }


    public IEnumerable<T> GetAll()
    {
      return table.ToList();
    }

    public T GetById(object id)
    {
      return table.Find(id);
    }

    public void Insert(T obj)
    {
      if (table == null)
      {
        throw new ArgumentNullException("Table");
      }
      table.Add(obj);
    }

    public void Update(T obj)
    {
      throw new NotImplementedException();
    }

    public void Delete(object id)
    {
      throw new NotImplementedException();
    }

    public void Save()
    {
      throw new NotImplementedException();
    }
  }
}
