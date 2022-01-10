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
    public class CategoryController : ControllerBase
    {
        ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }

        
        [Route("Load")]
        public List<Category> Load()
        {
            List<Category> LiCategory= categoryRepository.Load();
            return LiCategory;
        }

        [Route("Insert")]
        public void Insert(Category obj)
        {
            categoryRepository.Insert(obj);
        }
        [Route("Delete")]
        public void Delete(int id)
        {
            categoryRepository.Delete(id);
        }

        [Route("Edit")]
        public Category Edit(int id)
        {
            Category obj = categoryRepository.Edit(id);
            return obj;
        }

        [Route("Update")]
        public void Update(Category obj)
        {
            categoryRepository.Update(obj);
        }

        [Route("Search")]
        public List<Category> Search(string name)
        {
           List<Category> LiCategory= categoryRepository.Search(name);
            return LiCategory;
        }
    }
}
