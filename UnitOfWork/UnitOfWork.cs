using BookShopProject.Services;
using Microsoft.EntityFrameworkCore.Storage;

namespace BookShopProject.UnitOfWork
{
  public class UnitOfWork<TContext> : IUnitOfWork<TContext>, IDisposable where TContext : ApplicationDbContext
  {
    public ApplicationDbContext Context { get; }
    private IDbContextTransaction? transaction;

    public UnitOfWork(ApplicationDbContext context)
    {
      Context = context;
    }

    //Create transaction for do database operations
    public void CreateTransaction()
    {
      if (transaction == null)
      {
        transaction = Context.Database.BeginTransaction();
      }
    }

    //When all transactions complete -> Call Commit for give the changes permanently in database (not for save-luu tru)
    public void Commit()
    {
      try
      {
        transaction?.Commit();
      }
      catch
      {
        Rollback();
        throw;
      }
      finally
      {
        DisposeTransaction();
      }
    }

    //If at least 1 transaction failed -> Rollback to give database to previous state 
    public void Rollback()
    {
      try
      {
        transaction?.Rollback();
      }
      finally
      {
        DisposeTransaction();
      }
    }

    //And finally, When Do a Transaction, we must alway need to call Save() from make the changes in the database permanently, to apply changes to database permanently(this is save-luu tru database)
    public void Save()
    {
      try
      {
        Context.SaveChanges();
      }
      catch
      {
        Rollback();
        throw;
      }
    }
    // Use to free unmanaged resources like files, database connections etc. at any time.
    public void Dispose()
    {
      DisposeTransaction();
      Context.Dispose();
    }

    private void DisposeTransaction()
    {
      transaction?.Dispose();
      transaction = null;
    }
  }
}
