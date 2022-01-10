using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventorySystemDataAccess.Entity
{
    [Table("Attributes")]
   public class Attributes
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Status { get; set; }
        public List<AttributeValue> LiAttributeValue { set; get; }
    
    }
}
