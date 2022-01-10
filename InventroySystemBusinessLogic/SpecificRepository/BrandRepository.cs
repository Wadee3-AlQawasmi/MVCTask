using InventorySystemDataAccess.Context;
using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
  public class BrandRepository:IBrandRepository
    {
       

        public void Insert(Brand obj) {

            IGeneric <Brand> generic = new Generic<Brand>();
            generic.Insert(obj);
        
        }

        public List<Brand> Load()
        {
            IGeneric<Brand> generic = new Generic<Brand>();
            List<Brand> LiBrand= generic.Load();
            return LiBrand;
        }

        public void Delete(int ID)
        {
            IGeneric<Brand> generic = new Generic<Brand>();
            generic.Delete(ID);
        }

        public List<Brand> Search(string Name)
        {
            InventoryContext context = new InventoryContext();
            List<Brand> LiBrand = (context.Brand.Where(a => a.Name == Name)).ToList();
            return LiBrand;


        }

        public Brand Edit(int ID)
        {
            IGeneric<Brand> generic = new Generic<Brand>();
            Brand obj = generic.Edit(ID);
            return obj;
        }

        public void Update(Brand obj)
        {
            IGeneric<Brand> generic = new Generic<Brand>();
            generic.Update(obj);
        }
    }
}
