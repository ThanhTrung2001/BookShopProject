﻿namespace BookShopProject.Repository
{
  public interface IGenericRepository<T> where T : class
  {
    //Get all to a List
    IEnumerable<T> GetAll();
    //Get one by Id
    T GetById(object id);
    //Insert Object
    void Insert(T obj);
    //Update Object
    void Update(T obj);
    //Delete Object
    void Delete(object id);
    //Save Change to Database
    void Save();

  }
}
