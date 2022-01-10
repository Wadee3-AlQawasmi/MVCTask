using InventorySystemDataAccess.Entity;
using InventroySystemBusinessLogic.SpecificRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        ICurrencyRepository currencyRepository;
        ICountryRepository countryRepository;
        ICompanyRepository companyRepository;
        public CompanyController(ICurrencyRepository _currencyRepository,ICountryRepository _countryRepository,ICompanyRepository _companyRepository)
        {
            countryRepository = _countryRepository;
            currencyRepository = _currencyRepository;
            companyRepository = _companyRepository;
        }

        [Route("LoadCountry")]
        public List<Country> LoadCountry()
        {
            List<Country> LiCountry = countryRepository.LoadCountry();
            return LiCountry;
        }

        [Route("LoadCurrency")]
        public List<Currency> LoadCurrency()
        {
            List<Currency> LiCurrency = currencyRepository.LoadCurrency();
            return LiCurrency;
        }
        [Route("Insert")]
        public void Insert(Company obj)
        {
            companyRepository.Insert(obj);
        }
    }
}
