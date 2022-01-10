using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventorySystemDataAccess.Entity
{
    [Table("Stores")]
   public class Store
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Status { set; get; }
        public List<Product> LiProduct { set; get; }
    }
}
