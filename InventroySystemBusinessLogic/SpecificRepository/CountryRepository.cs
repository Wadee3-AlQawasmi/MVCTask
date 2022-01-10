using InventorySystemDataAccess.Context;
using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
    public class CountryRepository : ICountryRepository
    {
        public List<Country> LoadCountry()
        {
            IGeneric<Country> generic = new Generic<Country>();
            List<Country> LiCountry = generic.Load();
            return LiCountry;
        }

    }
}
