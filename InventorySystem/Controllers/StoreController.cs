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
    public class StoreController : ControllerBase
    {
        IStoreRepository storeService;
        public StoreController(IStoreRepository _storeService)
        {
            storeService = _storeService;
        }
        
        [Route("Insert")]
        public void Insert(Store obj)
        {
            storeService.Insert(obj);
        }

        [Route("Load")]
        public List<Store> Load()
        {
            List<Store> LiStore = storeService.Load();
            return LiStore;
        }

        [Route("Delete")]
        public void Delete(int ID)
        {
            storeService.Delete(ID);
        }

        [Route("Search")]
        public List<Store> Search(string Name)
        {
            List<Store> LiStore = storeService.Search(Name);
            return LiStore;
        }

        [Route("Edit")]
        public Store Edit(int ID)
        {
            Store obj = storeService.Edit(ID);
            return obj;
        }

        [Route("Update")]
        public void Update(Store obj)
        {
            storeService.Update(obj);
        }
    }
}
