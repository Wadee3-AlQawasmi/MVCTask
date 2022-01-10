using InventorySystemDataAccess.Context;
using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
   public class StoreRepository : IStoreRepository
    {
        public void Delete(int ID)
        {
            IGeneric<Store> generic = new Generic<Store>();
            generic.Delete(ID);
        }

        public Store Edit(int ID)
        {
            IGeneric<Store> generic = new Generic<Store>();
            Store obj = generic.Edit(ID);
            return obj;
        }

        public void Insert(Store obj)
        {
            IGeneric<Store> generic = new Generic<Store>();
            generic.Insert(obj);
        }

        public List<Store> Load()
        {
            IGeneric<Store> generic = new Generic<Store>();
           List<Store> LiStore =generic.Load();
            return LiStore;
        }

        public List<Store> Search(string Name)
        {
            InventoryContext context = new InventoryContext();
            List<Store> LiStore = (context.Store.Where(a => a.Name == Name)).ToList();
            return LiStore;
        }

        public void Update(Store obj)
        {
            IGeneric<Store> generic = new Generic<Store>();
            generic.Update(obj);
        }
    }
}
