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
    public class ProductController : ControllerBase
    {
        IProductRepository productRepository;
        IBrandRepository brandRepository;
        ICategoryRepository categoryRepository;
        IStoreRepository storeRepository;      
        public ProductController(IProductRepository _productRepository ,IBrandRepository _brandRepository , ICategoryRepository _categoryRepository ,IStoreRepository _storeRepository)
        {
            productRepository = _productRepository;
            brandRepository = _brandRepository;
            categoryRepository = _categoryRepository;
            storeRepository = _storeRepository;
        }
        [Route("LoadColor")]
        public List<AttributeValue> loadColor()
        {
           List<AttributeValue> LiAttVal= productRepository.loadColor();
            return LiAttVal;
        }

        [Route("LoadSize")]
        public List<AttributeValue> LoadSize()
        {
            List<AttributeValue> LiAttVal = productRepository.loadSize();
            return LiAttVal;
        }

        [Route("LoadBrand")]
        public List<Brand> LoadBrand()
        {
           List<Brand> LiBrand= brandRepository.Load();
            return LiBrand;
        }

        [Route("LoadCategory")]
        public List<Category> LoadCategory()
        {
            List<Category> LiCategory = categoryRepository.Load();
            return LiCategory;
        }

        [Route("LoadStore")]
        public List<Store> LoadStore()
        {
            List<Store> LiStore = storeRepository.Load();
            return LiStore;
        }

        [Route("Insert")]
        public void Insert(Product obj)
        {
            productRepository.Insert(obj);
        }

        [Route("LoadProduct")]
        public List<Product> LoadProduct()
        {
            List<Product> LiProduct = productRepository.LoadProduct();
            return LiProduct;
        }

        [Route("Edit")]
        public Product Edit(int ID)
        {
            Product obj = productRepository.Edit(ID);
            return obj;
        }
    }
}
