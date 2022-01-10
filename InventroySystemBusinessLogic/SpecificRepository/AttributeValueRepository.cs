using InventorySystemDataAccess.Context;
using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
    public class AttributeValueRepository : IAttributeValueRepository
    {
        public List<AttributeValue> Load(int ID)
        {
            InventoryContext context = new InventoryContext();
            List<AttributeValue> LiAttributeValue= context.AttributeValue.Where(a => a.Attribute_ID == ID).ToList();
            return LiAttributeValue;
        }
    }
}
