using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventorySystemDataAccess.Entity
{
    [Table("Orders")]
   public class Order
    {
        public int ID { get; set; }
        [Required]
        public string Customer_Name { get; set; }
        public string Customer_Addres { get; set; }
        public string Customer_Phone { get; set; }
        public int QTY { get; set; }
        public int Rate { get; set; }
        public double Gross_Amount { get; set; }
        public double Vat { get; set; }
        public int Discount { get; set; }
        public double Net_Amount { get; set; }
        public double Charge_Amount { get; set; }
        public string Paid_Status { get; set; }
        public DateTime Order_Date { get; set; }

        [ForeignKey("product")]
        public int Product_ID { set; get; }
        public Product product { set; get; }

    }
}
