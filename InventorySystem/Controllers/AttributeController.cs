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
    public class AttributeController : ControllerBase
    {
        IAttributeRepository attributeRepository;
        public AttributeController(IAttributeRepository _attributeRepository)
        {
            attributeRepository = _attributeRepository;
        }
        [Route("LoadAttribute")]
        public List<VmAttribute> Load()
        {
          List<VmAttribute> LiAtt=  attributeRepository.Load();
            return LiAtt;
        }
    }
}
