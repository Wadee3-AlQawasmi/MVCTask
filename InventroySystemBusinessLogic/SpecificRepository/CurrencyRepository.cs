using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
   public class CurrencyRepository : ICurrencyRepository
    {
        public List<Currency> LoadCurrency()
        {
            IGeneric<Currency> generic = new Generic<Currency>();
            List<Currency> LiCurrency = generic.Load();
            return LiCurrency;
        }
    }
}
