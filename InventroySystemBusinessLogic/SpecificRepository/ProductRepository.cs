using InventorySystemDataAccess.Context;
using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
   public class ProductRepository : IProductRepository
    {
        public Product Edit(int ID)
        {
            IGeneric<Product> generic = new Generic<Product>();
            Product obj = generic.Edit(ID);
            return obj;
        }

        public void Insert(Product obj)
        {
            IGeneric<Product> generic = new Generic<Product>();
            generic.Insert(obj);
        }

        public List<AttributeValue> loadColor()
        {
            InventoryContext context = new InventoryContext();
            List<AttributeValue> LiAttVal = context.AttributeValue.Where(a => a.Attribute_ID == 1).ToList();
            return LiAttVal;
        }

        public List<Product> LoadProduct()
        {
            IGeneric<Product> generic = new Generic<Product>();
           List<Product> LiProduct= generic.Load();
            return LiProduct;
        }

        public List<AttributeValue> loadSize()
        {
            InventoryContext context = new InventoryContext();
            List<AttributeValue> LiAttVal = context.AttributeValue.Where(a => a.Attribute_ID == 2).ToList();
            return LiAttVal;
        }
    }
}
