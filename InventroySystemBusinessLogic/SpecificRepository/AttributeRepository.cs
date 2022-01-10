using InventorySystemDataAccess.Context;
using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
    public class AttributeRepository : IAttributeRepository
    {
        public List<VmAttribute> Load()
        {
            InventoryContext context = new InventoryContext();
            List<VmAttribute> li = context.Attribute.Select(data =>
            
                new VmAttribute()
                {
                    Attribute = data,
                    Count = data.LiAttributeValue.Count()
                }

            ).ToList();
            return li;
        }
    }
}
