using InventorySystemDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
   public interface IAttributeRepository
    {
        List<VmAttribute> Load();
    }
}
