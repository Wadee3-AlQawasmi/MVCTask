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
    public class BrandController : ControllerBase
    {
        IBrandRepository brandRepository;
        public BrandController(IBrandRepository _brandRepository)
        {
            brandRepository = _brandRepository;
        }

        [Route("Insert")]
        public void Insert(Brand obj)
        {
            brandRepository.Insert(obj);  
        }

        [Route("Load")]
        public List<Brand> Load()
        {
            List<Brand> liBrand= brandRepository.Load();
            return liBrand;
        }

        [Route("Delete")]
        public void Delete(int ID)
        {
            brandRepository.Delete(ID);
        }

        [Route("Search")]
        public List<Brand> Search(string Name)
        {
           List<Brand> LiBrand= brandRepository.Search(Name);
            return LiBrand;
        }

        [Route("Edit")]
        public Brand Edit(int ID)
        {
            Brand obj = brandRepository.Edit(ID);
            return obj;
        }
        
        [Route("Update")]
        public void Update(Brand obj)
        {
            brandRepository.Update(obj);
        }
    }
}
