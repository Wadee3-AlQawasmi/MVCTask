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
    public class AttributeValueController : ControllerBase
    {
        IAttributeValueRepository attributeValueRepository;
        public AttributeValueController(IAttributeValueRepository _attributeValueRepository)
        {
            attributeValueRepository = _attributeValueRepository;
        }
        [Route("LoadAttribute")]
        public List<AttributeValue> Load(int ID)
        {
           List<AttributeValue> LiAttributeValue= attributeValueRepository.Load(ID);
            return LiAttributeValue;
        }
    }
}
