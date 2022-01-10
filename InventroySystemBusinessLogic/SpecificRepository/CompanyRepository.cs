using InventorySystemDataAccess.Entity;
using InventorySystemDataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventroySystemBusinessLogic.SpecificRepository
{
    public class CompanyRepository : ICompanyRepository
    {
        public void Insert(Company obj)
        {
            IGeneric<Company> generic = new Generic<Company>();
            generic.Insert(obj);


        }
    }
}
