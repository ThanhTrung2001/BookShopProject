﻿using BookShopProject.Services;

namespace BookShopProject.UnitOfWork
{
  public interface IUnitOfWork<TContext> where TContext : ApplicationDbContext
  {
    //The following Property is going to hold the context object
    ApplicationDbContext Context { get; }
    //Start the database Transaction
    void CreateTransaction();
    //Commit the database Transaction
    void Commit();
    //Rollback the database Transaction
    void Rollback();
    //DbContext Class SaveChanges method
    void Save();
  }
}
