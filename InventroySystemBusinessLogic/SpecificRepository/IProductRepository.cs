using InventorySystemDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
  public interface IProductRepository
    {
        List<AttributeValue> loadColor();

        List<AttributeValue> loadSize();
        void Insert(Product obj);

        List<Product> LoadProduct();

        Product Edit(int ID);
    }
}
