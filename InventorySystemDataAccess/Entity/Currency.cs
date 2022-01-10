using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventorySystemDataAccess.Entity
{
    [Table("Currencies")]
   public class Currency
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Company> LiCompany { set; get; }
    }
}
