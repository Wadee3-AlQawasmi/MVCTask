using InventorySystemDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystemDataAccess.Generic
{
  public interface IGeneric<T> where T:class
    {
        void Insert(T obj);

        List<T> Load();

        void Delete(int ID);

        T Edit(int ID);
        void Update(T obj);
    }
}
