using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventorySystemDataAccess.Entity
{
    [Table("Categories")]
     public class Category
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Status { set; get; }

        public List<Product> LiProduct { set; get; }
    }
}
