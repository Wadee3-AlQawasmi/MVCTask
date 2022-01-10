using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using Microsoft.AspNetCore.Http;

namespace InventorySystemDataAccess.Entity
{
    [Table("Products")]
  public class Product
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int QTY { get; set; }
        public string Description { get; set; }

        /*   [NotMapped]
        public IFormFile Image { set; get; }
        public string ImgPath { get; set; }
        */ 
        public string Availability { set; get; }

        [ForeignKey("brand")]
        public int Brand_ID { set; get; }
        public Brand brand { set; get; }

        [ForeignKey("category")]
        public int Category_ID { set; get; }
        public Category category { set; get; }
        
        [ForeignKey("store")]
        public int Store_ID { set; get; }
        public Store store { set; get; }

        public List<Order> LiOrder { set; get; }
    
        [ForeignKey("Color")]
        public int Color_ID { set; get; }
        public AttributeValue Color { set; get; }

        [ForeignKey("Size")]
        public int Size_ID { set; get; }
        public AttributeValue Size { set; get; }
    }
}
