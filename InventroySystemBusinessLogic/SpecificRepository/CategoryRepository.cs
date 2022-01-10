using InventorySystemDataAccess.Context;
using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Delete(int id)
        {
            IGeneric<Category> generic = new Generic<Category>();
            generic.Delete(id);
        }

        public Category Edit(int id)
        {
            IGeneric<Category> generic = new Generic<Category>();
            Category obj= generic.Edit(id);
            return obj;
        }

        public void Insert(Category obj)
        {
            IGeneric<Category> generic = new Generic<Category>();
            generic.Insert(obj);
        }

        public List<Category> Load()
        {
            IGeneric<Category> generic= new Generic<Category>();
           List<Category> LiCategory= generic.Load();
            return LiCategory;
        }

        public List<Category> Search(string name)
        {
            InventoryContext context = new InventoryContext();
            List<Category> LiCategory= (context.Category.Where(a => a.Name == name)).ToList();
            return LiCategory;
        }

        public void Update(Category obj)
        {
            IGeneric<Category> generic = new Generic<Category>();
            generic.Update(obj);
        }



    }
}
