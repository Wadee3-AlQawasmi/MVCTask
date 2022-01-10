using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventorySystemDataAccess.Entity
{
    [Table("Attributes-Value")]
  public class AttributeValue
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("attribute")]
        public int Attribute_ID { set; get; }
        public Attributes attribute { set; get; }


        [InverseProperty("Size")]
        public List<Product> LiProductSize { set; get; } // Bnst5dem Hay Lma Ykoon 3na 2 foregin key la nafs El-Table

        [InverseProperty("Color")]
        public List<Product> LiProductColor { set; get; }

        
    }
}
