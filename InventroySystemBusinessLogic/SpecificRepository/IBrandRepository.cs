using InventorySystemDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
   public interface IBrandRepository
    {
        void Insert(Brand brand);
        List<Brand> Load();
        void Delete(int ID);
        Brand Edit(int ID);

        void Update(Brand obj);
        List<Brand> Search(string Name);
    }
}
