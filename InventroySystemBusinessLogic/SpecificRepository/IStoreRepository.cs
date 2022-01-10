using InventorySystemDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
   public interface IStoreRepository
    {
        void Insert(Store obj);
        List<Store> Load();
        
        void Delete(int ID);
        Store Edit(int ID);

        void Update(Store obj);
        List<Store> Search(string Name);
    }
}
