using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventorySystemDataAccess.Entity
{
    [Table("Companies")]
  public class Company
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public double Charge_Amount { get; set; }
        public double Vat_Charge { get; set; }
        public string Massage { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        
        [ForeignKey("country")]
        public int Country_ID { set; get; }
        public Country country { set; get; }

        [ForeignKey("currency")]
        public int Currency_ID { set; get; }
        public Currency currency { set; get; }

    }
}
