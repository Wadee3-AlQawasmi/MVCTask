using InventorySystemDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
   public interface ICategoryRepository
    {
        List<Category> Load();
        void Insert(Category obj);
        void Delete(int id);
        void Update(Category obj);
        Category Edit(int id);
        List<Category> Search(string name);
    }
}
